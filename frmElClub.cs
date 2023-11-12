using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;



namespace pryLedoEI
{
    public partial class frmElClub : Form
    {
        clsArchivo objBaseDatos;
        int id = 0;
        public frmElClub()
        {
            InitializeComponent();
        }

        private void frmElClub_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsArchivo();
            objBaseDatos.ConectarBDElClub();
            objBaseDatos.TraerDatosElClub(dtvDatosElClub);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarPorCodigoDatosElClub(int.Parse(txtBuscarCliente.Text));

            txtBuscarCliente.Clear();
        }

        private void btnBuscarClientePorApellido_Click(object sender, EventArgs e)
        {

            objBaseDatos.BuscarPorApellidoDatosElClub(txtBuscarClientePorApellido.Text);

            txtBuscarClientePorApellido.Clear();
        }

        private void btnVolverElClub_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCambiarEstadoActivo_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtCambiarEstadoActivo.Text);

            clsArchivo objLogin = new clsArchivo();

            objLogin.ModificarEstadoSocio(id);

        }

        private void txtBuscarClientePorApellido_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCambiarEstadoActivo_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(txtCambiarEstadoActivo.Text);

            clsArchivo objLogin = new clsArchivo();
            txtCambiarEstadoActivo.Clear();
        }

        private void xtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
