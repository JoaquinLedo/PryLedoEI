﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pryLedoEI.Properties;
using System.Data;
using System.Windows.Forms;

namespace pryLedoEI
{
    public partial class frmMostrarProveedores : Form
    {
        private frmModificarProveedor ModificarProveedor;
        public frmMostrarProveedores()
        {
            InitializeComponent();
            PopulateTreeView();
            ModificarProveedor = new frmModificarProveedor();
        }
        public void frmMostrarProveedores_Load(object sender, EventArgs e)
        {
            
            frmModificarProveedor modificarProveedor = new frmModificarProveedor();

        }
        public void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Carpetas de Proveedores");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                tvwMostrarProveedores.Nodes.Add(rootNode);
            }
        }

        public void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private void tvwMostrarProveedores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            {
                TreeNode newSelected = e.Node;
                lvwMostrarProveedores.Items.Clear();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                        {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    lvwMostrarProveedores.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    lvwMostrarProveedores.Items.Add(item);
                }

                lvwMostrarProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;
        private void tvwMostrarProveedores_NodeMouseClick(object sender, MouseEventArgs e)
        {

        }
        public void lvwMostrarProveedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            if (!grillaCreada)
            {
                
                StreamReader sr = new StreamReader("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv");
                string leerLinea;
                string[] separarDatos;

                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');

                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dgvMostrarProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }

                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgvMostrarProveedores.Rows.Add(separarDatos);
                }

                sr.Close();

                grillaCreada = true;
            }
            else
            {

            }


        }

        private void dgvMostrarProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static int pos;
        private void dgvMostrarProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = 1 + dgvMostrarProveedores.CurrentRow.Index;

            ModificarProveedor.lblModificarNumProveedor.Text = dgvMostrarProveedores[0, pos - 1].Value.ToString();
            ModificarProveedor.txtModificarEntidad.Text = dgvMostrarProveedores[1, pos].Value.ToString();
            ModificarProveedor.txtModificarApertura.Text = dgvMostrarProveedores[2, pos].Value.ToString();
            ModificarProveedor.txtModificarExpediente.Text = dgvMostrarProveedores[3, pos].Value.ToString();
            ModificarProveedor.txtModificarJuzgado.Text = dgvMostrarProveedores[4, pos].Value.ToString();
            ModificarProveedor.txtModificarJurisdiccion.Text = dgvMostrarProveedores[5, pos].Value.ToString();
            ModificarProveedor.txtModificarDireccion.Text = dgvMostrarProveedores[6, pos].Value.ToString();
            ModificarProveedor.txtModificarLiquidador.Text = dgvMostrarProveedores[7, pos].Value.ToString();

            this.Hide();
            ModificarProveedor.Show();
        }

        private void dgvMostrarProveedores_CellContentDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            dgvMostrarProveedores.Rows.Clear();
            dgvMostrarProveedores.Columns.Clear();

            StreamReader sr = new StreamReader("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv");

            string leerLinea;
            string[] separarDatos;

            leerLinea = sr.ReadLine();
            separarDatos = leerLinea.Split(';');

            for (int indice = 0; indice < separarDatos.Length; indice++)
            {
                dgvMostrarProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
            }

            while (sr.EndOfStream == false)
            {
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvMostrarProveedores.Rows.Add(separarDatos);

            }

            sr.Close();

            MessageBox.Show("Actualizada");
        }
    }
}
