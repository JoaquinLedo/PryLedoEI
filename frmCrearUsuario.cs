using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLedoEI
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        public static string Crearusuario;
        public static string contraseña;
        public static string repitaContraseña;
        public static string ContraseñasIguales;
        public static string CrearPerfilCuenta;

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCargarContraseña_Click(object sender, EventArgs e)
        {
            Crearusuario = txtNuevoUusario.Text;
            contraseña = txtContraseñaNueva.Text;
            repitaContraseña = txtContraseñaNuevaR.Text;
            CrearPerfilCuenta = txtPerfil.Text;
            clsUsuarios objLogs = new clsUsuarios();

            if (contraseña == repitaContraseña)
            {
                ContraseñasIguales = contraseña;

                MessageBox.Show("Cuenta creada con éxito");

                clsUsuarios objLogin = new clsUsuarios();

                objLogin.CrearCuenta();

            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.");

            }
        }
    }
}
