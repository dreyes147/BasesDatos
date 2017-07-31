namespace Interfaz.Mantenimientos
{
    partial class mPromocion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mPromocion));
            this.tspBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdPromocion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdPelicula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdTipoPromocion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gboDescripcion = new System.Windows.Forms.GroupBox();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboTipoPromocion = new System.Windows.Forms.ComboBox();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.lblIdPelicula = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblTipoPromocion = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspBarraMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcInformacion.SuspendLayout();
            this.tbpLista.SuspendLayout();
            this.tbpInformacion.SuspendLayout();
            this.gboDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspBarraMenu
            // 
            this.tspBarraMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar});
            this.tspBarraMenu.Location = new System.Drawing.Point(0, 66);
            this.tspBarraMenu.Name = "tspBarraMenu";
            this.tspBarraMenu.Size = new System.Drawing.Size(602, 25);
            this.tspBarraMenu.TabIndex = 27;
            this.tspBarraMenu.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Interfaz.Properties.Resources.boton_de_suma;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Interfaz.Properties.Resources.editar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Interfaz.Properties.Resources.eliminar__1_;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 66);
            this.panel1.TabIndex = 26;
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
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpInformacion);
            this.tbcInformacion.Location = new System.Drawing.Point(9, 95);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(586, 339);
            this.tbcInformacion.TabIndex = 25;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.ltvInformacion);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(578, 313);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // ltvInformacion
            // 
            this.ltvInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvInformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdPromocion,
            this.colIdPelicula,
            this.colIdTipoPromocion,
            this.colFechaInicio,
            this.colFechaFinal});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(6, 6);
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(566, 301);
            this.ltvInformacion.TabIndex = 0;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            // 
            // colIdPromocion
            // 
            this.colIdPromocion.Text = "Identificador Promoción";
            this.colIdPromocion.Width = 125;
            // 
            // colIdPelicula
            // 
            this.colIdPelicula.Text = "Id Película";
            this.colIdPelicula.Width = 98;
            // 
            // colIdTipoPromocion
            // 
            this.colIdTipoPromocion.Text = "Id Tipo Promoción";
            this.colIdTipoPromocion.Width = 123;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.Text = "FechaInicio";
            this.colFechaInicio.Width = 111;
            // 
            // colFechaFinal
            // 
            this.colFechaFinal.Text = "Fecha Final";
            this.colFechaFinal.Width = 105;
            // 
            // tbpInformacion
            // 
            this.tbpInformacion.Controls.Add(this.btnSalir);
            this.tbpInformacion.Controls.Add(this.btnAceptar);
            this.tbpInformacion.Controls.Add(this.btnRegresar);
            this.tbpInformacion.Controls.Add(this.gboDescripcion);
            this.tbpInformacion.Location = new System.Drawing.Point(4, 22);
            this.tbpInformacion.Name = "tbpInformacion";
            this.tbpInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformacion.Size = new System.Drawing.Size(578, 313);
            this.tbpInformacion.TabIndex = 1;
            this.tbpInformacion.Text = "Información";
            this.tbpInformacion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Interfaz.Properties.Resources.logout__1_;
            this.btnSalir.Location = new System.Drawing.Point(25, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Interfaz.Properties.Resources.comprobado;
            this.btnAceptar.Location = new System.Drawing.Point(385, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Interfaz.Properties.Resources.flecha_atras_izquierda_de_angulo_de_regresar;
            this.btnRegresar.Location = new System.Drawing.Point(466, 274);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gboDescripcion
            // 
            this.gboDescripcion.Controls.Add(this.dtpFechaFinal);
            this.gboDescripcion.Controls.Add(this.dtpFechaInicio);
            this.gboDescripcion.Controls.Add(this.cboTipoPromocion);
            this.gboDescripcion.Controls.Add(this.cboPelicula);
            this.gboDescripcion.Controls.Add(this.lblIdPelicula);
            this.gboDescripcion.Controls.Add(this.lblFechaFinal);
            this.gboDescripcion.Controls.Add(this.lblTipoPromocion);
            this.gboDescripcion.Controls.Add(this.lblIdentificador);
            this.gboDescripcion.Controls.Add(this.lblId);
            this.gboDescripcion.Controls.Add(this.lblFechaInicio);
            this.gboDescripcion.Location = new System.Drawing.Point(15, 12);
            this.gboDescripcion.Name = "gboDescripcion";
            this.gboDescripcion.Size = new System.Drawing.Size(551, 119);
            this.gboDescripcion.TabIndex = 5;
            this.gboDescripcion.TabStop = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(96, 67);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaFinal.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(96, 41);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaInicio.TabIndex = 9;
            // 
            // cboTipoPromocion
            // 
            this.cboTipoPromocion.FormattingEnabled = true;
            this.cboTipoPromocion.Location = new System.Drawing.Point(337, 65);
            this.cboTipoPromocion.Name = "cboTipoPromocion";
            this.cboTipoPromocion.Size = new System.Drawing.Size(200, 21);
            this.cboTipoPromocion.TabIndex = 8;
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(337, 38);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(200, 21);
            this.cboPelicula.TabIndex = 7;
            // 
            // lblIdPelicula
            // 
            this.lblIdPelicula.AutoSize = true;
            this.lblIdPelicula.Location = new System.Drawing.Point(285, 38);
            this.lblIdPelicula.Name = "lblIdPelicula";
            this.lblIdPelicula.Size = new System.Drawing.Size(46, 13);
            this.lblIdPelicula.TabIndex = 6;
            this.lblIdPelicula.Text = "Película";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(7, 67);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinal.TabIndex = 5;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblTipoPromocion
            // 
            this.lblTipoPromocion.AutoSize = true;
            this.lblTipoPromocion.Location = new System.Drawing.Point(247, 68);
            this.lblTipoPromocion.Name = "lblTipoPromocion";
            this.lblTipoPromocion.Size = new System.Drawing.Size(84, 13);
            this.lblTipoPromocion.TabIndex = 4;
            this.lblTipoPromocion.Text = "Tipo Promoción:";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(7, 16);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(21, 13);
            this.lblIdentificador.TabIndex = 3;
            this.lblIdentificador.Text = "ID:";
            this.lblIdentificador.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(34, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(7, 41);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 1;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(602, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 465);
            this.Controls.Add(this.tspBarraMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mPromocion";
            this.Text = "Promocion";
            this.Load += new System.EventHandler(this.mPromocion_Load);
            this.tspBarraMenu.ResumeLayout(false);
            this.tspBarraMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcInformacion.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
            this.tbpInformacion.ResumeLayout(false);
            this.gboDescripcion.ResumeLayout(false);
            this.gboDescripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspBarraMenu;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tbcInformacion;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.ListView ltvInformacion;
        private System.Windows.Forms.ColumnHeader colIdPromocion;
        private System.Windows.Forms.ColumnHeader colIdPelicula;
        private System.Windows.Forms.ColumnHeader colIdTipoPromocion;
        private System.Windows.Forms.ColumnHeader colFechaInicio;
        private System.Windows.Forms.ColumnHeader colFechaFinal;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gboDescripcion;
        private System.Windows.Forms.ComboBox cboTipoPromocion;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Label lblIdPelicula;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblTipoPromocion;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
    }
}