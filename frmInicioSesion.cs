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
            if (txtNombreDeUsuario.Text == "usuario" && txtContraseña.Text == "clave")
            {
                frmInicio frmInicio = new frmInicio();
                frmInicio.ShowDialog();
                this.Close();
            }
        }
        
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
