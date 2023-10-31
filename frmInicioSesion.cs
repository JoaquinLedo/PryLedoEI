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

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            clsUsuarios objUsuario = new clsUsuarios();

            objUsuario.ValidarUsuario(txtNombreDeUsuario.Text, txtContraseña.Text);

            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Ingrese al sistema...");
                objUsuario.RegistroLogInicioSesion();
            }
            else
            {
                MessageBox.Show("No pasaràs...");
                objUsuario.RegistroLogInicioSesion();
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
    }
}
