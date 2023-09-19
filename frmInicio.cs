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
            this.Dispose();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void pROVEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvedores frmProvedores = new frmProvedores ();
            frmProvedores.ShowDialog();
        }

        private void prestadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
