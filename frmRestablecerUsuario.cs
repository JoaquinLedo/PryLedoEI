using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLedoEI.Resources
{
    public partial class frmRestablecerUsuario : Form
    {
        public frmRestablecerUsuario()
        {
            InitializeComponent();
        }
        public static string usuarioReestablecerContraseña;
        public static string contraseñaReestablecerContraseña;
        public static string repitaContraseñaReestablecerContraseña;
        public static string contraseñasIguales;
        private void frmRestablecerUsuario_Load(object sender, EventArgs e)
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

        private void BtnRestablecerContraseña_Click(object sender, EventArgs e)
        {
            usuarioReestablecerContraseña = txtUsuariosRestablecer.Text;
            contraseñaReestablecerContraseña = txtNuevaContraseña.Text;
            repitaContraseñaReestablecerContraseña = txtRContraseña.Text;

            clsUsuarios objLogs = new clsUsuarios();

            if (contraseñaReestablecerContraseña == repitaContraseñaReestablecerContraseña)
            {
                contraseñasIguales = contraseñaReestablecerContraseña;

                MessageBox.Show("Contraseña reestablecida con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                clsUsuarios objLogin = new clsUsuarios();

                objLogin.ReestablecerContraseña(usuarioReestablecerContraseña);


            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
