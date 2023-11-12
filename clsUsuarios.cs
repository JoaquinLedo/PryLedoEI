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

            try
            {
                cadenaConexionBase = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionBase;
                conexionBD.Open();

                objDS = new DataSet();

                estadoDeConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
            // Constructor para inicializar la conexión y el comando.
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }


        public void ConectarBD()
        {
            try
            {
                string conexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\BaseDatosUsuarios.accdb";

                conexionBD.ConnectionString = conexion;
                conexionBD.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show(Convert.ToString(error));
            }
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

                estadoConexion = "Cuenta creada con éxito";
        }

        public void ReestablecerContraseña(string usuario)
        {

            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objAdaptador;
            DataSet objDataSet = new DataSet();

            try
            {
                ConectarBD();
                estadoConexion = "Conectado";

            }
            catch (Exception ex)
            {
                estadoConexion = "Error" + ex.Message;
            }

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

                //Establezco el tipo de comando, con este comando le indico que voy a trabajar con una tabla específica
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla quiero traer
                comandoBD.CommandText = "Logs";

                //Creo el objeto DataAdapter pasando como parámetro el objeto comando que quiero vincular
                adaptadorBD = new OleDbDataAdapter(comandoBD);

                //Ejecuto la lectura de la tabla y almaceno su contenido en el dataAdapter
                adaptadorBD.Fill(objDS, "Logs");

                //Obtengo una referencia a la tabla

                DataTable objTabla = objDS.Tables["Logs"];

                //Creo el nuevo DataRow con la estructura de campos de la tabla de la cual quiero traer los datos
                DataRow nuevoRegistro = objTabla.NewRow();

                //Asigno los valores a todos los campos del DataRow
                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";
                nuevoRegistro["Usuario"] = frmInicioSesion.usuario;

                //Agrego el DataRow a la tabla
                objTabla.Rows.Add(nuevoRegistro);


                //Creo el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                //Actualizo la base con los cambios realizados
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
            
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
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio fallido";
                nuevoRegistro["Usuario"] = frmInicioSesion.usuario;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoDeConexion = "Registro exitoso de log";
           
        }

    }
}
