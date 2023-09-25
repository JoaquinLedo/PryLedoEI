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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tvwMostrarProveedores = new System.Windows.Forms.TreeView();
            this.lvwMostrarProveedores = new System.Windows.Forms.ListView();
            this.clmhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhUlt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvMostrarProveedores = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJuzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLiqRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvwMostrarProveedores);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 510);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMostrarProveedores);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMostrarProveedores);
            this.groupBox3.Location = new System.Drawing.Point(214, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 260);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // tvwMostrarProveedores
            // 
            this.tvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwMostrarProveedores.Location = new System.Drawing.Point(3, 16);
            this.tvwMostrarProveedores.Name = "tvwMostrarProveedores";
            this.tvwMostrarProveedores.Size = new System.Drawing.Size(190, 491);
            this.tvwMostrarProveedores.TabIndex = 1;
            // 
            // lvwMostrarProveedores
            // 
            this.lvwMostrarProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhName,
            this.clmhTipo,
            this.clmhUlt});
            this.lvwMostrarProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostrarProveedores.HideSelection = false;
            this.lvwMostrarProveedores.Location = new System.Drawing.Point(3, 16);
            this.lvwMostrarProveedores.Name = "lvwMostrarProveedores";
            this.lvwMostrarProveedores.Size = new System.Drawing.Size(673, 303);
            this.lvwMostrarProveedores.TabIndex = 1;
            this.lvwMostrarProveedores.UseCompatibleStateImageBehavior = false;
            this.lvwMostrarProveedores.View = System.Windows.Forms.View.Details;
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
            this.dgvMostrarProveedores.Location = new System.Drawing.Point(3, 10);
            this.dgvMostrarProveedores.Name = "dgvMostrarProveedores";
            this.dgvMostrarProveedores.Size = new System.Drawing.Size(673, 247);
            this.dgvMostrarProveedores.TabIndex = 2;
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
            // frmMostrarProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(897, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarProvedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarProvedores";
            this.Load += new System.EventHandler(this.frmMostrarProvedores_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TreeView tvwMostrarProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListView lvwMostrarProveedores;
        private System.Windows.Forms.ColumnHeader clmhName;
        private System.Windows.Forms.ColumnHeader clmhTipo;
        private System.Windows.Forms.ColumnHeader clmhUlt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvMostrarProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJuzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJurisdiccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLiqRes;
    }
}