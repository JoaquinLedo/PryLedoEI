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
      
        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        frmMostrarProveedores frmMostrarProveedoress = new frmMostrarProveedores();
        frmCargarProveedores frmCargarProveedoress = new frmCargarProveedores();
        public static int contProv = 0;
        public static int contCargar = 0;

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


        private void btnSalir1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion frminiciar = new frmInicioSesion();
            frminiciar.Show();
        }

        private void mostrarProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (contProv == 0)
            {
                frmMostrarProveedoress.Activate();
                frmMostrarProveedoress.Show();
                frmMostrarProveedoress.TopMost = true;
                contProv = 1;
                frmCargarProveedoress.Hide();
                contCargar = 0;

            }
            else
            {

                contProv = 0;
            }
        }

        private void cargarProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contCargar == 0)
            {
                frmCargarProveedoress.Show();
                frmCargarProveedoress.TopMost = true;
                contCargar = 1;
                frmMostrarProveedoress.Hide();
                contProv = 0;

            }
            else
            {
                contCargar = 0;
            }

        }

        private void elClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmElClub frmElClub = new frmElClub();
            frmElClub.Show();
        }
    }
}
