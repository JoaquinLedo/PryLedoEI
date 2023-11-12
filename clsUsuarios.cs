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
            try
            {
                ConectarBD();

                //Creo una instancia de la clase OleDbCommand para ejecutar los comandos en la base de datos 
                comandoBD = new OleDbCommand();

                //Establezco la conexión, para que cuando se ejecute el comando lo opere en la base de datos que debe hacerse
                comandoBD.Connection = conexionBD;

                //Establezco el tipo de comando, con este comando le indico que voy a leer una tabla en específica
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla es la que se va a leer
                comandoBD.CommandText = "Usuarios";

                //Ejecuto el comando y leo la los resultados de la consulta
                lectorBD = comandoBD.ExecuteReader();

                //Si tiene filas quiere decir que hay datos 
                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        //Almaceno los datos del registro que estoy leyendo en dos variables
                        //Columna[1] (campo Usuario), columna[2] (campo Contraseña)
                        string usuarioBD = lectorBD[1].ToString();
                        string contraseñaBD = lectorBD[2].ToString();

                        //Si las variables del formulario inicio sesión donde esta guardado el usuario
                        //y la contraseña que ingreso el usuario son iguales entonces
                        //la variable booleana acceso va a ser verdadera y rompo el bucle
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
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }

        public void CrearCuenta()
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;

                //Establezco el tipo de comando, con este comando le indico que voy a trabajar con una tabla específica
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                //Le digo que tabla quiero traer
                comandoBD.CommandText = "Usuarios";

                //Creo el objeto DataAdapter pasando como parámetro el objeto comando que quiero vincular
                adaptadorBD = new OleDbDataAdapter(comandoBD);

                //Ejecuto la lectura de la tabla y almaceno su contenido en el dataAdapter
                adaptadorBD.Fill(objDS, "Usuarios");

                //Obtengo una referencia a la tabla

                DataTable objTabla = objDS.Tables["Usuarios"];

                //Creo el nuevo DataRow con la estructura de campos de la tabla de la cual quiero traer los datos
                DataRow nuevoRegistro = objTabla.NewRow();

                //Asigno los valores a todos los campos del DataRow
                nuevoRegistro["Usuario"] = frmCrearUsuario.usuarioCrearCuenta;
                nuevoRegistro["Contraseña"] = frmCrearUsuario.lasContraseñasSonIguales;

                //Agrego el DataRow a la tabla
                objTabla.Rows.Add(nuevoRegistro);


                //Creo el objeto OledBCommandBuilder pasando como parámetro el DataAdapter
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                //Actualizo la base con los cambios realizados
                adaptadorBD.Update(objDS, "Usuarios");

                estadoConexion = "Cuenta creada con éxito";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
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
            try
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
            catch (Exception error)
            {
                estadoDeConexion = error.Message;
            }
        }


        public void RegistroLogInicioSesionFallido()
        {
            try
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
            catch (Exception error)
            {

                estadoDeConexion = error.Message;
            }
        }

    }
}
