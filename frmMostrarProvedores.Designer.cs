namespace pryLedoEI
{
    partial class frmMostrarProvedores
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvwMostrarProveedores = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMostrarProveedores = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJuzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLiqRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvwMostrarProvedores = new System.Windows.Forms.ListView();
            this.clmhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhUlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.splitContainer1.Panel1.Controls.Add(this.tvwMostrarProveedores);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvMostrarProveedores);
            this.splitContainer1.Panel2.Controls.Add(this.lvwMostrarProvedores);
            this.splitContainer1.Size = new System.Drawing.Size(897, 536);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvwMostrarProveedores
            // 
            this.tvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMostrarProveedores.Location = new System.Drawing.Point(0, 0);
            this.tvwMostrarProveedores.Name = "tvwMostrarProveedores";
            this.tvwMostrarProveedores.Size = new System.Drawing.Size(299, 536);
            this.tvwMostrarProveedores.TabIndex = 2;
            this.tvwMostrarProveedores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwMostrarProveedores_NodeMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMostrarProveedores
            // 
            this.dgvMostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnEntidad,
            this.ColumnApertura,
            this.ColumnNumExp,
            this.ColumnJuzgado,
            this.ColumnJurisdiccion,
            this.ColumnDirección,
            this.ColumnLiqRes});
            this.dgvMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarProveedores.Location = new System.Drawing.Point(0, 248);
            this.dgvMostrarProveedores.Name = "dgvMostrarProveedores";
            this.dgvMostrarProveedores.Size = new System.Drawing.Size(594, 288);
            this.dgvMostrarProveedores.TabIndex = 3;
            this.dgvMostrarProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarProveedores_CellClick);
            this.dgvMostrarProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarProveedores_CellContentDoubleClick);
            this.dgvMostrarProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMostrarProveedores_CellMouseDoubleClick);
            // 
            // ColumnNum
            // 
            this.ColumnNum.HeaderText = "N°";
            this.ColumnNum.Name = "ColumnNum";
            // 
            // ColumnEntidad
            // 
            this.ColumnEntidad.HeaderText = "Entidad";
            this.ColumnEntidad.Name = "ColumnEntidad";
            // 
            // ColumnApertura
            // 
            this.ColumnApertura.HeaderText = "Apertura";
            this.ColumnApertura.Name = "ColumnApertura";
            // 
            // ColumnNumExp
            // 
            this.ColumnNumExp.HeaderText = "N° Expediente";
            this.ColumnNumExp.Name = "ColumnNumExp";
            // 
            // ColumnJuzgado
            // 
            this.ColumnJuzgado.HeaderText = "Juzgado";
            this.ColumnJuzgado.Name = "ColumnJuzgado";
            // 
            // ColumnJurisdiccion
            // 
            this.ColumnJurisdiccion.HeaderText = "Jurisdicción";
            this.ColumnJurisdiccion.Name = "ColumnJurisdiccion";
            // 
            // ColumnDirección
            // 
            this.ColumnDirección.HeaderText = "Dirección";
            this.ColumnDirección.Name = "ColumnDirección";
            // 
            // ColumnLiqRes
            // 
            this.ColumnLiqRes.HeaderText = "Liq Responsable";
            this.ColumnLiqRes.Name = "ColumnLiqRes";
            // 
            // lvwMostrarProvedores
            // 
            this.lvwMostrarProvedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhName,
            this.clmhTipo,
            this.clmhUlt});
            this.lvwMostrarProvedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostrarProvedores.HideSelection = false;
            this.lvwMostrarProvedores.Location = new System.Drawing.Point(0, 0);
            this.lvwMostrarProvedores.Name = "lvwMostrarProvedores";
            this.lvwMostrarProvedores.Size = new System.Drawing.Size(594, 242);
            this.lvwMostrarProvedores.TabIndex = 2;
            this.lvwMostrarProvedores.UseCompatibleStateImageBehavior = false;
            this.lvwMostrarProvedores.View = System.Windows.Forms.View.Details;
            this.lvwMostrarProvedores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwMostrarProveedores_MouseDoubleClick);
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
            // frmMostrarProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(897, 536);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarProvedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarProvedores";
            this.Load += new System.EventHandler(this.frmMostrarProvedores_Load);
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
        public System.Windows.Forms.ListView lvwMostrarProvedores;
        private System.Windows.Forms.ColumnHeader clmhName;
        private System.Windows.Forms.ColumnHeader clmhTipo;
        private System.Windows.Forms.ColumnHeader clmhUlt;
        private System.Windows.Forms.DataGridView dgvMostrarProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJuzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJurisdiccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLiqRes;
        private System.Windows.Forms.Button button1;
    }
}