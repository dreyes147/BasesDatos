namespace Interfaz.Mantenimientos
{
    partial class mAsientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mAsientos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTipoAsiento = new System.Windows.Forms.Label();
            this.lblEstadoAsiento = new System.Windows.Forms.Label();
            this.cboEstadoAsiento = new System.Windows.Forms.ComboBox();
            this.cboTipoAsiento = new System.Windows.Forms.ComboBox();
            this.gboInformacion = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 66);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.curves_295400_640;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 230);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(422, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTipoAsiento
            // 
            this.lblTipoAsiento.AutoSize = true;
            this.lblTipoAsiento.Location = new System.Drawing.Point(7, 42);
            this.lblTipoAsiento.Name = "lblTipoAsiento";
            this.lblTipoAsiento.Size = new System.Drawing.Size(69, 13);
            this.lblTipoAsiento.TabIndex = 20;
            this.lblTipoAsiento.Text = "Tipo Asiento:";
            // 
            // lblEstadoAsiento
            // 
            this.lblEstadoAsiento.AutoSize = true;
            this.lblEstadoAsiento.Location = new System.Drawing.Point(7, 69);
            this.lblEstadoAsiento.Name = "lblEstadoAsiento";
            this.lblEstadoAsiento.Size = new System.Drawing.Size(81, 13);
            this.lblEstadoAsiento.TabIndex = 19;
            this.lblEstadoAsiento.Text = "Estado Asiento:";
            // 
            // cboEstadoAsiento
            // 
            this.cboEstadoAsiento.FormattingEnabled = true;
            this.cboEstadoAsiento.Location = new System.Drawing.Point(130, 66);
            this.cboEstadoAsiento.Name = "cboEstadoAsiento";
            this.cboEstadoAsiento.Size = new System.Drawing.Size(219, 21);
            this.cboEstadoAsiento.TabIndex = 18;
            // 
            // cboTipoAsiento
            // 
            this.cboTipoAsiento.FormattingEnabled = true;
            this.cboTipoAsiento.Location = new System.Drawing.Point(130, 39);
            this.cboTipoAsiento.Name = "cboTipoAsiento";
            this.cboTipoAsiento.Size = new System.Drawing.Size(219, 21);
            this.cboTipoAsiento.TabIndex = 17;
            // 
            // gboInformacion
            // 
            this.gboInformacion.Controls.Add(this.btnRegresar);
            this.gboInformacion.Controls.Add(this.cboTipoAsiento);
            this.gboInformacion.Controls.Add(this.lblTipoAsiento);
            this.gboInformacion.Controls.Add(this.cboEstadoAsiento);
            this.gboInformacion.Controls.Add(this.lblEstadoAsiento);
            this.gboInformacion.Location = new System.Drawing.Point(12, 72);
            this.gboInformacion.Name = "gboInformacion";
            this.gboInformacion.Size = new System.Drawing.Size(390, 143);
            this.gboInformacion.TabIndex = 21;
            this.gboInformacion.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Interfaz.Properties.Resources.flecha_atras_izquierda_de_angulo_de_regresar;
            this.btnRegresar.Location = new System.Drawing.Point(212, 105);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Interfaz.Properties.Resources.comprobado;
            this.btnAceptar.Location = new System.Drawing.Point(143, 177);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 252);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gboInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mAsientos";
            this.Text = "Asientos";
            this.Load += new System.EventHandler(this.mAsientos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboInformacion.ResumeLayout(false);
            this.gboInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblTipoAsiento;
        private System.Windows.Forms.Label lblEstadoAsiento;
        private System.Windows.Forms.ComboBox cboEstadoAsiento;
        private System.Windows.Forms.ComboBox cboTipoAsiento;
        private System.Windows.Forms.GroupBox gboInformacion;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAceptar;
    }
}