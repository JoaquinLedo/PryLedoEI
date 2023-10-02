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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        frmMostrarProvedores frmMostrarProvedores = new frmMostrarProvedores();
        frmProvedores frmCargarProvedores = new frmProvedores();
        public static int contProv = 0;
        public static int contCargar = 0;
        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void pROVEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void prestadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(contProv == 0)
            {
                frmMostrarProvedores.Activate();
                frmMostrarProvedores.Show();
                frmMostrarProvedores.TopMost = true;
                contProv = 1;
                frmMostrarProvedores.Hide();
                contCargar = 0;

            }
            else
            {

                contProv = 0;
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contCargar == 0)
            {
                frmProvedores.Show();
                frmProvedores.TopMost = true;
                contCargar = 1;
                frmMostrarProvedores.Hide();
                contProv = 0;

            }
            else
            {
                contCargar = 0;
            }
        }
    }
}
