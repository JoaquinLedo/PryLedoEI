using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using pryLedoEI.Resources;

namespace pryLedoEI
{
   
    internal class clsUsuarios
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS = new DataSet();

        string cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";
        public string estadoConexion = "";
        public string estadoDeConexion;

        public static bool acceso;
        frmInicioSesion frmInicioSesion = new frmInicioSesion();
        public clsUsuarios()
        {
                cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionBase;
                conexionBD.Open();

                objDS = new DataSet();

                estadoDeConexion = "Conectado";
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }


        public void ConectarBD()
        {
                string conexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

                conexionBD.ConnectionString = conexion;
                conexionBD.Open();
        }

        public void BuscarUsuario()
        {
            
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                comandoBD.CommandText = "Usuarios";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                  
                        string usuarioBD = lectorBD[1].ToString();
                        string contraseñaBD = lectorBD[2].ToString();

                        if (usuarioBD == frmInicioSesion.usuario & contraseñaBD == frmInicioSesion.contraseña)
                        {
                            acceso = true;
                            break;
                        }
                        else
                        {
                            acceso = false;
                        }
                    }
                }
            
        }

        public void CrearCuenta()
        {
            
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                comandoBD.CommandText = "Usuarios";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Usuarios");

                DataTable objTabla = objDS.Tables["Usuarios"];

                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Usuario"] = frmCrearUsuario.Crearusuario;
                nuevoRegistro["Contraseña"] = frmCrearUsuario.ContraseñasIguales;
                nuevoRegistro["Perfil"] = frmCrearUsuario.CrearPerfilCuenta;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDS, "Usuarios");

                estadoConexion = "Cuenta creada con exito";
        }

        public void ReestablecerContraseña(string usuario)
        {

            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objAdaptador;
            DataSet objDataSet = new DataSet();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "Usuarios";

            objAdaptador = new OleDbDataAdapter(comandoBD);

            objAdaptador.Fill(objDataSet, "USUARIOS");


            DataTable dt = objDataSet.Tables["USUARIOS"];


            foreach (DataRow registro in dt.Rows)
            {

                if (registro["Usuario"].ToString() == usuario)
                {
                    registro.BeginEdit();

                    registro["Contraseña"] = frmRestablecerUsuario.contraseñasIguales;

                    registro.EndEdit();
                    break;
                }
            }
            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            objAdaptador.Update(objDataSet, "Usuarios");

        }

        public void RegistroLogInicioSesionExitoso()
        {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDS, "Logs");
                DataTable objTabla = objDS.Tables["Logs"];

                DataRow nuevoRegistro = objTabla.NewRow();
                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["Fecha"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";
                nuevoRegistro["Usuario"] = frmInicioSesion.usuario;

                objTabla.Rows.Add(nuevoRegistro);
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");
        }


        public void RegistroLogInicioSesionFallido()
        {
            
                ConectarBD();

                comandoBD = new OleDbCommand();


                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["Fecha"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio fallido";
                nuevoRegistro["Usuario"] = frmInicioSesion.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
           
        }

    }
}
