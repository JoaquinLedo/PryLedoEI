namespace pryLedoEI
{
    partial class frmMostrarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarProveedores));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwMostrarProveedores = new System.Windows.Forms.TreeView();
            this.dgvMostrarProveedores = new System.Windows.Forms.DataGridView();
            this.lvwMostrarProveedores = new System.Windows.Forms.ListView();
            this.clmhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhUlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnActualizar);
            this.splitContainer1.Panel1.Controls.Add(this.tvwMostrarProveedores);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMostrarProveedores);
            this.splitContainer1.Panel2.Controls.Add(this.lvwMostrarProveedores);
            this.splitContainer1.Size = new System.Drawing.Size(799, 411);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvwMostrarProveedores
            // 
            this.tvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvwMostrarProveedores.Location = new System.Drawing.Point(0, 0);
            this.tvwMostrarProveedores.Name = "tvwMostrarProveedores";
            this.tvwMostrarProveedores.Size = new System.Drawing.Size(265, 450);
            this.tvwMostrarProveedores.TabIndex = 1;
            this.tvwMostrarProveedores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMostrarProveedores_NodeMouseClick);
            // 
            // dgvMostrarProveedores
            // 
            this.dgvMostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarProveedores.Location = new System.Drawing.Point(0, 189);
            this.dgvMostrarProveedores.Name = "dgvMostrarProveedores";
            this.dgvMostrarProveedores.Size = new System.Drawing.Size(530, 222);
            this.dgvMostrarProveedores.TabIndex = 2;
            this.dgvMostrarProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarProveedores_CellClick);
            this.dgvMostrarProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarProveedores_CellContentDoubleClick);
            this.dgvMostrarProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMostrarProveedores_CellContentDoubleClick);
            // 
            // lvwMostrarProveedores
            // 
            this.lvwMostrarProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhName,
            this.clmhTipo,
            this.clmhUlt});
            this.lvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostrarProveedores.HideSelection = false;
            this.lvwMostrarProveedores.Location = new System.Drawing.Point(0, 0);
            this.lvwMostrarProveedores.Name = "lvwMostrarProveedores";
            this.lvwMostrarProveedores.Size = new System.Drawing.Size(530, 222);
            this.lvwMostrarProveedores.TabIndex = 1;
            this.lvwMostrarProveedores.UseCompatibleStateImageBehavior = false;
            this.lvwMostrarProveedores.View = System.Windows.Forms.View.Details;
            this.lvwMostrarProveedores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvwMostrarProveedores_NodeMouseClick);
            // 
            // clmhName
            // 
            this.clmhName.Text = "Nombre";
            // 
            // clmhTipo
            // 
            this.clmhTipo.Text = "Tipo";
            // 
            // clmhUlt
            // 
            this.clmhUlt.Text = "Ult. Modificacion";
            this.clmhUlt.Width = 98;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::pryLedoEI.Properties.Resources.descarga__5_;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(213, 359);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(49, 49);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // frmMostrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarProveedores";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView tvwMostrarProveedores;
        public System.Windows.Forms.DataGridView dgvMostrarProveedores;
        public System.Windows.Forms.ListView lvwMostrarProveedores;
        private System.Windows.Forms.ColumnHeader clmhName;
        private System.Windows.Forms.ColumnHeader clmhTipo;
        private System.Windows.Forms.ColumnHeader clmhUlt;
        private System.Windows.Forms.Button btnActualizar;
    }
}