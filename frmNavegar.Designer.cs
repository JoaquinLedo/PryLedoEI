namespace pryLedoEI
{
    partial class frmNavegar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nodo6");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nodo7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("a", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Provedores");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("s");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.HotTrack, null);
            this.ventanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrirCarpetas = new System.Windows.Forms.Button();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.btnGrabarArchivo = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAbrirCarpetas
            // 
            this.btnAbrirCarpetas.Location = new System.Drawing.Point(176, 259);
            this.btnAbrirCarpetas.Name = "btnAbrirCarpetas";
            this.btnAbrirCarpetas.Size = new System.Drawing.Size(186, 32);
            this.btnAbrirCarpetas.TabIndex = 0;
            this.btnAbrirCarpetas.Text = "Abrir navegador carpeta";
            this.btnAbrirCarpetas.UseVisualStyleBackColor = true;
            this.btnAbrirCarpetas.Click += new System.EventHandler(this.btnAbrirCarpetas_Click);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplo.Location = new System.Drawing.Point(379, 253);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(146, 36);
            this.lblEjemplo.TabIndex = 1;
            this.lblEjemplo.Text = "Ejemplo...";
            // 
            // btnGrabarArchivo
            // 
            this.btnGrabarArchivo.Location = new System.Drawing.Point(12, 363);
            this.btnGrabarArchivo.Name = "btnGrabarArchivo";
            this.btnGrabarArchivo.Size = new System.Drawing.Size(180, 37);
            this.btnGrabarArchivo.TabIndex = 2;
            this.btnGrabarArchivo.Text = "Grabar archivo";
            this.btnGrabarArchivo.UseVisualStyleBackColor = true;
            this.btnGrabarArchivo.Click += new System.EventHandler(this.btnGrabarArchivo_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(58, 253);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArchivo.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Nodo0";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Nodo1";
            treeNode3.Name = "Nodo2";
            treeNode3.Text = "Nodo2";
            treeNode4.Name = "Nodo3";
            treeNode4.Text = "Nodo3";
            treeNode5.Name = "Nodo4";
            treeNode5.Text = "Nodo4";
            treeNode6.Name = "Nodo5";
            treeNode6.Text = "Nodo5";
            treeNode7.Name = "Nodo6";
            treeNode7.Text = "Nodo6";
            treeNode8.Name = "Nodo7";
            treeNode8.Text = "Nodo7";
            treeNode9.Name = "Nodo0";
            treeNode9.Text = "a";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(167, 197);
            this.treeView1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "listViewGroup4";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.HideSelection = false;
            listViewItem3.IndentCount = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(289, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(156, 197);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmNavegar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnGrabarArchivo);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.btnAbrirCarpetas);
            this.Name = "frmNavegar";
            this.Text = "frmNavegar";
            this.Load += new System.EventHandler(this.frmNavegar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog ventanaCarpetas;
        private System.Windows.Forms.Button btnAbrirCarpetas;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.Button btnGrabarArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}