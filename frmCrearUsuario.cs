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

        public static string usuarioCrearCuenta;
        public static string contraseñaCrearCuenta;
        public static string repitaContraseñaCrearCuenta;
        public static string lasContraseñasSonIguales;

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
            usuarioCrearCuenta = txtNuevoUusario.Text;
            contraseñaCrearCuenta = txtContraseñaNueva.Text;
            repitaContraseñaCrearCuenta = txtContraseñaNuevaR.Text;

            clsUsuarios objLogs = new clsUsuarios();

            if (contraseñaCrearCuenta == repitaContraseñaCrearCuenta)
            {
                lasContraseñasSonIguales = contraseñaCrearCuenta;

                MessageBox.Show("Cuenta creada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                clsUsuarios objLogin = new clsUsuarios();

                objLogin.CrearCuenta();

            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
