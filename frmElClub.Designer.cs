namespace pryLedoEI
{
    partial class frmElClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElClub));
            this.btnCambiarEstadoActivo = new System.Windows.Forms.Button();
            this.txtCambiarEstadoActivo = new System.Windows.Forms.TextBox();
            this.lblCambiarEstadoActivo = new System.Windows.Forms.Label();
            this.btnVolverElClub = new System.Windows.Forms.Button();
            this.btnBuscarClientePorApellido = new System.Windows.Forms.Button();
            this.txtBuscarClientePorApellido = new System.Windows.Forms.TextBox();
            this.lblBuscarClientePorApellido = new System.Windows.Forms.Label();
            this.lblBuscarClientePorID = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dtvDatosElClub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatosElClub)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiarEstadoActivo
            // 
            this.btnCambiarEstadoActivo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCambiarEstadoActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstadoActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstadoActivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstadoActivo.Location = new System.Drawing.Point(152, 202);
            this.btnCambiarEstadoActivo.Name = "btnCambiarEstadoActivo";
            this.btnCambiarEstadoActivo.Size = new System.Drawing.Size(81, 26);
            this.btnCambiarEstadoActivo.TabIndex = 23;
            this.btnCambiarEstadoActivo.Text = "Cambiar";
            this.btnCambiarEstadoActivo.UseVisualStyleBackColor = false;
            this.btnCambiarEstadoActivo.Click += new System.EventHandler(this.btnCambiarEstadoActivo_Click);
            // 
            // txtCambiarEstadoActivo
            // 
            this.txtCambiarEstadoActivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambiarEstadoActivo.Location = new System.Drawing.Point(116, 170);
            this.txtCambiarEstadoActivo.Name = "txtCambiarEstadoActivo";
            this.txtCambiarEstadoActivo.Size = new System.Drawing.Size(143, 26);
            this.txtCambiarEstadoActivo.TabIndex = 22;
            this.txtCambiarEstadoActivo.TextChanged += new System.EventHandler(this.txtCambiarEstadoActivo_TextChanged);
            // 
            // lblCambiarEstadoActivo
            // 
            this.lblCambiarEstadoActivo.AutoSize = true;
            this.lblCambiarEstadoActivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarEstadoActivo.Location = new System.Drawing.Point(12, 144);
            this.lblCambiarEstadoActivo.Name = "lblCambiarEstadoActivo";
            this.lblCambiarEstadoActivo.Size = new System.Drawing.Size(205, 18);
            this.lblCambiarEstadoActivo.TabIndex = 21;
            this.lblCambiarEstadoActivo.Text = "Cambiar estado mediate ID:";
            // 
            // btnVolverElClub
            // 
            this.btnVolverElClub.BackColor = System.Drawing.Color.CadetBlue;
            this.btnVolverElClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverElClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverElClub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverElClub.Location = new System.Drawing.Point(696, 234);
            this.btnVolverElClub.Name = "btnVolverElClub";
            this.btnVolverElClub.Size = new System.Drawing.Size(99, 29);
            this.btnVolverElClub.TabIndex = 20;
            this.btnVolverElClub.Text = "Volver";
            this.btnVolverElClub.UseVisualStyleBackColor = false;
            this.btnVolverElClub.Click += new System.EventHandler(this.btnVolverElClub_Click);
            // 
            // btnBuscarClientePorApellido
            // 
            this.btnBuscarClientePorApellido.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscarClientePorApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClientePorApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClientePorApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientePorApellido.Location = new System.Drawing.Point(152, 104);
            this.btnBuscarClientePorApellido.Name = "btnBuscarClientePorApellido";
            this.btnBuscarClientePorApellido.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarClientePorApellido.TabIndex = 19;
            this.btnBuscarClientePorApellido.Text = "Buscar";
            this.btnBuscarClientePorApellido.UseVisualStyleBackColor = false;
            this.btnBuscarClientePorApellido.Click += new System.EventHandler(this.btnBuscarClientePorApellido_Click);
            // 
            // txtBuscarClientePorApellido
            // 
            this.txtBuscarClientePorApellido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClientePorApellido.Location = new System.Drawing.Point(116, 72);
            this.txtBuscarClientePorApellido.Name = "txtBuscarClientePorApellido";
            this.txtBuscarClientePorApellido.Size = new System.Drawing.Size(143, 26);
            this.txtBuscarClientePorApellido.TabIndex = 18;
            this.txtBuscarClientePorApellido.TextChanged += new System.EventHandler(this.txtBuscarClientePorApellido_TextChanged);
            // 
            // lblBuscarClientePorApellido
            // 
            this.lblBuscarClientePorApellido.AutoSize = true;
            this.lblBuscarClientePorApellido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClientePorApellido.Location = new System.Drawing.Point(13, 80);
            this.lblBuscarClientePorApellido.Name = "lblBuscarClientePorApellido";
            this.lblBuscarClientePorApellido.Size = new System.Drawing.Size(97, 18);
            this.lblBuscarClientePorApellido.TabIndex = 17;
            this.lblBuscarClientePorApellido.Text = "Por Apellido:";
            // 
            // lblBuscarClientePorID
            // 
            this.lblBuscarClientePorID.AutoSize = true;
            this.lblBuscarClientePorID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarClientePorID.Location = new System.Drawing.Point(54, 12);
            this.lblBuscarClientePorID.Name = "lblBuscarClientePorID";
            this.lblBuscarClientePorID.Size = new System.Drawing.Size(56, 18);
            this.lblBuscarClientePorID.TabIndex = 16;
            this.lblBuscarClientePorID.Text = "Por ID:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(152, 40);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(81, 26);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(116, 8);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(143, 26);
            this.txtBuscarCliente.TabIndex = 14;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.xtBuscarCliente_TextChanged);
            // 
            // dtvDatosElClub
            // 
            this.dtvDatosElClub.AllowUserToAddRows = false;
            this.dtvDatosElClub.AllowUserToDeleteRows = false;
            this.dtvDatosElClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDatosElClub.Location = new System.Drawing.Point(265, 8);
            this.dtvDatosElClub.Name = "dtvDatosElClub";
            this.dtvDatosElClub.ReadOnly = true;
            this.dtvDatosElClub.Size = new System.Drawing.Size(530, 220);
            this.dtvDatosElClub.TabIndex = 13;
            // 
            // frmElClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(807, 274);
            this.Controls.Add(this.btnCambiarEstadoActivo);
            this.Controls.Add(this.txtCambiarEstadoActivo);
            this.Controls.Add(this.lblCambiarEstadoActivo);
            this.Controls.Add(this.btnVolverElClub);
            this.Controls.Add(this.btnBuscarClientePorApellido);
            this.Controls.Add(this.txtBuscarClientePorApellido);
            this.Controls.Add(this.lblBuscarClientePorApellido);
            this.Controls.Add(this.lblBuscarClientePorID);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dtvDatosElClub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmElClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmElClub";
            this.Load += new System.EventHandler(this.frmElClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDatosElClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarEstadoActivo;
        private System.Windows.Forms.TextBox txtCambiarEstadoActivo;
        private System.Windows.Forms.Label lblCambiarEstadoActivo;
        private System.Windows.Forms.Button btnVolverElClub;
        public System.Windows.Forms.Button btnBuscarClientePorApellido;
        private System.Windows.Forms.TextBox txtBuscarClientePorApellido;
        private System.Windows.Forms.Label lblBuscarClientePorApellido;
        private System.Windows.Forms.Label lblBuscarClientePorID;
        public System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.DataGridView dtvDatosElClub;
    }
}