﻿using System;
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
    public partial class frmProvedores : Form
    {
        public frmProvedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmProvedores_Load(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            frmMostrarProvedores frmMostrarProvedores = new frmMostrarProvedores();
            frmMostrarProvedores.Show();
            this.Hide();
            frmMostrarProvedores.TopMost = true;
    

        }
    }
}
