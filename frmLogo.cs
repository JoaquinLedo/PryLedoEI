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
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            LblPorcentaje.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();

                frmInicioSesion frmInicioSesion = new frmInicioSesion();
                frmInicioSesion.ShowDialog();
                this.Close();
            }
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {

        }
    }
}