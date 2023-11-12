namespace pryLedoEI
{
    partial class frmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearUsuario));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.txtContraseñaNuevaR = new System.Windows.Forms.TextBox();
            this.txtNuevoUusario = new System.Windows.Forms.TextBox();
            this.BtnCargarContraseña = new System.Windows.Forms.Button();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.Controls.Add(this.BtnSalir);
            this.splitContainer1.Panel2.Controls.Add(this.BtnVolver);
            this.splitContainer1.Panel2.Controls.Add(this.txtContraseñaNuevaR);
            this.splitContainer1.Panel2.Controls.Add(this.txtNuevoUusario);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCargarContraseña);
            this.splitContainer1.Panel2.Controls.Add(this.LblContraseña);
            this.splitContainer1.Panel2.Controls.Add(this.LblConfirmarContraseña);
            this.splitContainer1.Panel2.Controls.Add(this.txtContraseñaNueva);
            this.splitContainer1.Panel2.Controls.Add(this.LblUsuario);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(795, 324);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryLedoEI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSalir.Location = new System.Drawing.Point(516, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(29, 27);
            this.BtnSalir.TabIndex = 29;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Window;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVolver.Location = new System.Drawing.Point(187, 233);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(167, 38);
            this.BtnVolver.TabIndex = 28;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // txtContraseñaNuevaR
            // 
            this.txtContraseñaNuevaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNuevaR.Location = new System.Drawing.Point(245, 135);
            this.txtContraseñaNuevaR.Name = "txtContraseñaNuevaR";
            this.txtContraseñaNuevaR.Size = new System.Drawing.Size(210, 26);
            this.txtContraseñaNuevaR.TabIndex = 27;
            // 
            // txtNuevoUusario
            // 
            this.txtNuevoUusario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoUusario.Location = new System.Drawing.Point(245, 62);
            this.txtNuevoUusario.Name = "txtNuevoUusario";
            this.txtNuevoUusario.Size = new System.Drawing.Size(210, 26);
            this.txtNuevoUusario.TabIndex = 24;
            // 
            // BtnCargarContraseña
            // 
            this.BtnCargarContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.BtnCargarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargarContraseña.Location = new System.Drawing.Point(37, 189);
            this.BtnCargarContraseña.Name = "BtnCargarContraseña";
            this.BtnCargarContraseña.Size = new System.Drawing.Size(474, 38);
            this.BtnCargarContraseña.TabIndex = 21;
            this.BtnCargarContraseña.Text = "Crear Usuario y Contraseña";
            this.BtnCargarContraseña.UseVisualStyleBackColor = false;
            this.BtnCargarContraseña.Click += new System.EventHandler(this.BtnCargarContraseña_Click);
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.LblContraseña.Location = new System.Drawing.Point(103, 100);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(136, 20);
            this.LblContraseña.TabIndex = 23;
            this.LblContraseña.Text = "Cotraseña Nueva:";
            // 
            // LblConfirmarContraseña
            // 
            this.LblConfirmarContraseña.AutoSize = true;
            this.LblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmarContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.LblConfirmarContraseña.Location = new System.Drawing.Point(79, 138);
            this.LblConfirmarContraseña.Name = "LblConfirmarContraseña";
            this.LblConfirmarContraseña.Size = new System.Drawing.Size(160, 20);
            this.LblConfirmarContraseña.TabIndex = 26;
            this.LblConfirmarContraseña.Text = "Confirmar Cotraseña:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaNueva.Location = new System.Drawing.Point(245, 97);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.Size = new System.Drawing.Size(210, 26);
            this.txtContraseñaNueva.TabIndex = 25;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.LblUsuario.Location = new System.Drawing.Point(89, 65);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(150, 20);
            this.LblUsuario.TabIndex = 22;
            this.LblUsuario.Text = "Nombre de Usuario:";
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 324);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearUsuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtContraseñaNuevaR;
        private System.Windows.Forms.TextBox txtNuevoUusario;
        private System.Windows.Forms.Button BtnCargarContraseña;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnSalir;
    }
}