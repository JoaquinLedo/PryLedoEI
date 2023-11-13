using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pryLedoEI.Resources;


namespace pryLedoEI
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        public static string usuario;
        public static string contraseña;
        int contador = 0;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            usuario = txtNombreDeUsuario.Text;
            contraseña = txtContraseña.Text;

            clsUsuarios Usuarios = new clsUsuarios();
            Usuarios.BuscarUsuario();
            clsUsuarios objLogs = new clsUsuarios();

            if (clsUsuarios.acceso == true)
            {
                objLogs.RegistroLogInicioSesionExitoso();


                this.Hide();
                frmInicio frmInicio = new frmInicio();
                frmInicio.Show();
            }
            else
            {
                objLogs.RegistroLogInicioSesionFallido();
                contador = contador + 1;
                MessageBox.Show("Usuario o contraeña incorrecto");

                if (contador > 2)
                {
                    btnIngresar.Enabled = false;
                    MessageBox.Show("Ingreso bloqueado");
                    contador = 0;
                }
            }
        }
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.Show();
            this.Hide();
        }

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            frmRestablecerUsuario restablecerUsuario = new frmRestablecerUsuario();
            restablecerUsuario.Show();
            this.Hide();
        }

        private void frmInicioSesion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void frmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                usuario = txtNombreDeUsuario.Text;
                contraseña = txtContraseña.Text;

                clsUsuarios Usuarios = new clsUsuarios();
                Usuarios.BuscarUsuario();
                clsUsuarios objLogs = new clsUsuarios();

                if (clsUsuarios.acceso == true)
                {
                    objLogs.RegistroLogInicioSesionExitoso();


                    this.Hide();
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.Show();
                }
                else
                {
                    objLogs.RegistroLogInicioSesionFallido();
                    contador = contador + 1;
                    MessageBox.Show("Usuario o contraeña incorrecto");

                    if (contador > 2)
                    {
                        btnIngresar.Enabled = false;
                        MessageBox.Show("Ingreso bloqueado");
                        contador = 0;
                    }
                }
            }
        }
    }
}
