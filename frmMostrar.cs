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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pryLedoEI
{
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
            PopulateTreeview();

        }
        private void PopulateTreeview()
        {
            TreeNode nodoMadre;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Proveedores");
            if (info.Exists == true) //POR DEFECTO el IF pregunta true
            {
                nodoMadre = new TreeNode(info.Name);
                nodoMadre.Tag = info;
                ObtenerCarpetas(info.GetDirectories(), nodoMadre);
                trvMostrar.Nodes.Add(nodoMadre);
            }

        }
        //desde info.GetDirectories() nos da todos los nombres de carpetas
        private void ObtenerCarpetas(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;

            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";

                //recursiva - se llama a si mismo para buscar màs carpetas
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    ObtenerCarpetas(subSubDirs, aNode);
                }

                nodeToAddTo.Nodes.Add(aNode);
            }
        }
        private void trvMostrar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void trvMostrar_NodeMouseClicktrvMostrar_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        //Al clickear en el treeview, este abre el menu del listview
        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listMostrar.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            //Busca las carpetas
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listMostrar.Items.Add(item);
            }

            //Busca los archivos
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listMostrar.Items.Add(item);
            }

            listMostrar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //Al hacer click en el archivo del listview, este me lleva a la grilla
        private void listMostrar_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            frmGrilla Grilla = new frmGrilla();
            Grilla.Show();
        }
    }
}
