using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Security.Policy;

namespace pryLedoEI
{
    internal class clsArchivo
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand(); 
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;

        DataSet objDS;

        string cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public string datosTabla = "";

        public string estadoConexion = "";

        public static bool acceso;

        public void Grabar(string datosConcatenados)
        {
            StreamWriter AdeD = new StreamWriter("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv", true); 
            AdeD.WriteLine(datosConcatenados); 
            AdeD.Close();
        }

        public clsArchivo()
        { 
            cadenaConexionElClub = @"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Resources\\EL_CLUB.accdb";
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexionElClub;
            conexionBD.Open();

            objDS = new DataSet();

            estadoConexion = "Conectado";
          
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public void ConectarBDElClub()
        { 
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionElClub;
                conexionBD.Open();
                estadoConexion = "Conectado";
        }

        public void TraerDatosElClub(DataGridView grilla)
        {
            string estadoCliente = "";
            string sexo = "";

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("ID", "ID");
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Nacionalidad", "Nacionalidad");
                grilla.Columns.Add("Edad", "Edad");
                grilla.Columns.Add("Sexo", "Sexo");
                grilla.Columns.Add("Ingreso", "Ingreso");
                grilla.Columns.Add("Puntaje", "Puntaje");
                grilla.Columns.Add("Estado", "Estado");

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD.GetBoolean(8) == true)
                        {
                            estadoCliente = "Activo";
                        }
                        else
                        {
                            estadoCliente = "Inactivo";
                        }

                        if (lectorBD.GetBoolean(5) == true)
                        {
                            sexo = "Masculino";
                        }
                        else
                        {
                            sexo = "Femenino";
                        }

                        datosTabla += "-" + lectorBD[0]; 
                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], sexo, lectorBD[6], lectorBD[7], estadoCliente);

                    }
                }
           
        }

        public void BuscarPorCodigoDatosElClub(int codigoSocio)
        {
            
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";
            lectorBD = comandoBD.ExecuteReader();

            bool seEncuentra = false;

           if (lectorBD.HasRows)
           {
               while (lectorBD.Read())
               {
                  if (int.Parse(lectorBD[0].ToString()) == codigoSocio)
                  {
                     MessageBox.Show("El cliente es: \n" + lectorBD[1].ToString() + " " + lectorBD[2].ToString(), "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     seEncuentra = true;
                     break;
                  }
               }

                if (seEncuentra == false)
                {
                    MessageBox.Show("El cliente no existe");
            
                }

           }
        }

        public void BuscarPorApellidoDatosElClub(string apellidoSocio)
        {
            
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                bool seEncuentra = false;

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[2].ToString() == apellidoSocio)
                        {
                            MessageBox.Show("El cliente es: \n" + lectorBD[1].ToString() + " " + lectorBD[2].ToString(), "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            seEncuentra = true;
                            break;
                        }
                    }

                    if (seEncuentra == false)
                    {
                        MessageBox.Show("El cliente no existe");
                    }
                }

        }

        public void ModificarEstadoSocio(int id)
        {

            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objAdaptador;
            DataSet objDataSet = new DataSet();

            
            conexionBD = new OleDbConnection();
            conexionBD.ConnectionString = cadenaConexionElClub;
            conexionBD.Open();
            estadoConexion = "Conectado";


            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "SOCIOS";

            objAdaptador = new OleDbDataAdapter(comandoBD);

            objAdaptador.Fill(objDataSet, "SOCIOS");


            DataTable dt = objDataSet.Tables["SOCIOS"];


            foreach (DataRow registro in dt.Rows)
            {

                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    registro.BeginEdit();

                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    registro.EndEdit();
                    break;
                }
            }
            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            objAdaptador.Update(objDataSet, "SOCIOS");

            MessageBox.Show("Estado cambiado");

        }
    }
}
