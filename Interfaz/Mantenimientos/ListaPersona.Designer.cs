namespace Interfaz.Mantenimientos
{
    partial class ListaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPersona));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coIIdTipoPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrimerApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSegundoApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaNacimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 66);
            this.panel1.TabIndex = 17;
            // 
            // ltvInformacion
            // 
            this.ltvInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvInformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdPersona,
            this.coIIdTipoPersona,
            this.colNombre,
            this.colPrimerApellido,
            this.colSegundoApellido,
            this.colFechaNacimiento});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(12, 72);
            this.ltvInformacion.MultiSelect = false;
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(655, 430);
            this.ltvInformacion.TabIndex = 18;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            this.ltvInformacion.DoubleClick += new System.EventHandler(this.ltvInformacion_DoubleClick);
            // 
            // colIdPersona
            // 
            this.colIdPersona.Text = "ID";
            this.colIdPersona.Width = 106;
            // 
            // coIIdTipoPersona
            // 
            this.coIIdTipoPersona.Text = "Tipo Persona";
            this.coIIdTipoPersona.Width = 96;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 123;
            // 
            // colPrimerApellido
            // 
            this.colPrimerApellido.Text = "Primer Apellido";
            this.colPrimerApellido.Width = 111;
            // 
            // colSegundoApellido
            // 
            this.colSegundoApellido.Text = "Segundo Apellido";
            this.colSegundoApellido.Width = 105;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.Text = "Fecha Nacimiento";
            this.colFechaNacimiento.Width = 110;
            // 
            // ListaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 537);
            this.Controls.Add(this.ltvInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaPersona";
            this.Text = "ListaPersona";
            this.Load += new System.EventHandler(this.ListaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ltvInformacion;
        private System.Windows.Forms.ColumnHeader colIdPersona;
        private System.Windows.Forms.ColumnHeader coIIdTipoPersona;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colPrimerApellido;
        private System.Windows.Forms.ColumnHeader colSegundoApellido;
        private System.Windows.Forms.ColumnHeader colFechaNacimiento;
    }
}