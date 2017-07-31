namespace Interfaz.Mantenimientos
{
    partial class mCartelera
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
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdCartelera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gboDescripcion = new System.Windows.Forms.GroupBox();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.gboDetalle = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarDetalle = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarDetalle = new System.Windows.Forms.ToolStripButton();
            this.ltvDetalle = new System.Windows.Forms.ListView();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.dtpFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.dtpHoraPelicula = new System.Windows.Forms.DateTimePicker();
            this.lblHoraPelicula = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.tspBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colIdPelicula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaEstreno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaFinalizacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcInformacion.SuspendLayout();
            this.tbpLista.SuspendLayout();
            this.tbpInformacion.SuspendLayout();
            this.gboDescripcion.SuspendLayout();
            this.gboDetalle.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tspBarraMenu.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpInformacion);
            this.tbcInformacion.Location = new System.Drawing.Point(9, 95);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(554, 476);
            this.tbcInformacion.TabIndex = 4;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.ltvInformacion);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(546, 450);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // ltvInformacion
            // 
            this.ltvInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvInformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdCartelera,
            this.colIdSala});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(6, 6);
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(534, 438);
            this.ltvInformacion.TabIndex = 0;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            // 
            // colIdCartelera
            // 
            this.colIdCartelera.Text = "Identificador Cartelera";
            this.colIdCartelera.Width = 264;
            // 
            // colIdSala
            // 
            this.colIdSala.Text = "Identificador Sala Cine";
            this.colIdSala.Width = 265;
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
            this.tbpInformacion.Size = new System.Drawing.Size(546, 450);
            this.tbpInformacion.TabIndex = 1;
            this.tbpInformacion.Text = "Información";
            this.tbpInformacion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Interfaz.Properties.Resources.logout__1_;
            this.btnSalir.Location = new System.Drawing.Point(16, 414);
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
            this.btnAceptar.Location = new System.Drawing.Point(376, 414);
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
            this.btnRegresar.Location = new System.Drawing.Point(457, 414);
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
            this.gboDescripcion.Controls.Add(this.cboPelicula);
            this.gboDescripcion.Controls.Add(this.gboDetalle);
            this.gboDescripcion.Controls.Add(this.cboSala);
            this.gboDescripcion.Controls.Add(this.dtpFechaFinalizacion);
            this.gboDescripcion.Controls.Add(this.lblFechaFinalizacion);
            this.gboDescripcion.Controls.Add(this.dtpFechaEstreno);
            this.gboDescripcion.Controls.Add(this.lblFechaEstreno);
            this.gboDescripcion.Controls.Add(this.dtpHoraPelicula);
            this.gboDescripcion.Controls.Add(this.lblHoraPelicula);
            this.gboDescripcion.Controls.Add(this.dtpFecha);
            this.gboDescripcion.Controls.Add(this.lblFecha);
            this.gboDescripcion.Controls.Add(this.lblPelicula);
            this.gboDescripcion.Controls.Add(this.lblIdentificador);
            this.gboDescripcion.Controls.Add(this.lblId);
            this.gboDescripcion.Controls.Add(this.lblSala);
            this.gboDescripcion.Location = new System.Drawing.Point(6, 12);
            this.gboDescripcion.Name = "gboDescripcion";
            this.gboDescripcion.Size = new System.Drawing.Size(539, 395);
            this.gboDescripcion.TabIndex = 5;
            this.gboDescripcion.TabStop = false;
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(92, 65);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(431, 21);
            this.cboPelicula.TabIndex = 18;
            // 
            // gboDetalle
            // 
            this.gboDetalle.Controls.Add(this.toolStrip1);
            this.gboDetalle.Controls.Add(this.ltvDetalle);
            this.gboDetalle.Location = new System.Drawing.Point(11, 148);
            this.gboDetalle.Name = "gboDetalle";
            this.gboDetalle.Size = new System.Drawing.Size(515, 235);
            this.gboDetalle.TabIndex = 17;
            this.gboDetalle.TabStop = false;
            this.gboDetalle.Text = "Detalle";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarDetalle,
            this.btnEliminarDetalle});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(509, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarDetalle.Image = global::Interfaz.Properties.Resources.boton_de_suma;
            this.btnAgregarDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarDetalle.Image = global::Interfaz.Properties.Resources.eliminar__1_;
            this.btnEliminarDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(23, 22);
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // ltvDetalle
            // 
            this.ltvDetalle.CheckBoxes = true;
            this.ltvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdPelicula,
            this.colFecha,
            this.colHora,
            this.colFechaEstreno,
            this.colFechaFinalizacion});
            this.ltvDetalle.GridLines = true;
            this.ltvDetalle.Location = new System.Drawing.Point(3, 43);
            this.ltvDetalle.Name = "ltvDetalle";
            this.ltvDetalle.Size = new System.Drawing.Size(509, 186);
            this.ltvDetalle.TabIndex = 16;
            this.ltvDetalle.UseCompatibleStateImageBehavior = false;
            this.ltvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(92, 38);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(95, 21);
            this.cboSala.TabIndex = 15;
            // 
            // dtpFechaFinalizacion
            // 
            this.dtpFechaFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinalizacion.Location = new System.Drawing.Point(428, 118);
            this.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion";
            this.dtpFechaFinalizacion.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaFinalizacion.TabIndex = 14;
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(324, 124);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(98, 13);
            this.lblFechaFinalizacion.TabIndex = 13;
            this.lblFechaFinalizacion.Text = "Fecha Finalizacion:";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(92, 118);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(95, 20);
            this.dtpFechaEstreno.TabIndex = 12;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(7, 124);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(79, 13);
            this.lblFechaEstreno.TabIndex = 11;
            this.lblFechaEstreno.Text = "Fecha Estreno:";
            // 
            // dtpHoraPelicula
            // 
            this.dtpHoraPelicula.CustomFormat = "HH:mm";
            this.dtpHoraPelicula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraPelicula.Location = new System.Drawing.Point(428, 92);
            this.dtpHoraPelicula.Name = "dtpHoraPelicula";
            this.dtpHoraPelicula.Size = new System.Drawing.Size(95, 20);
            this.dtpHoraPelicula.TabIndex = 10;
            // 
            // lblHoraPelicula
            // 
            this.lblHoraPelicula.AutoSize = true;
            this.lblHoraPelicula.Location = new System.Drawing.Point(389, 98);
            this.lblHoraPelicula.Name = "lblHoraPelicula";
            this.lblHoraPelicula.Size = new System.Drawing.Size(33, 13);
            this.lblHoraPelicula.TabIndex = 9;
            this.lblHoraPelicula.Text = "Hora:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(92, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(7, 98);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(7, 68);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(49, 13);
            this.lblPelicula.TabIndex = 4;
            this.lblPelicula.Text = "Película:";
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
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(7, 41);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 1;
            this.lblSala.Text = "Sala:";
            // 
            // tspBarraMenu
            // 
            this.tspBarraMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar});
            this.tspBarraMenu.Location = new System.Drawing.Point(0, 67);
            this.tspBarraMenu.Name = "tspBarraMenu";
            this.tspBarraMenu.Size = new System.Drawing.Size(575, 25);
            this.tspBarraMenu.TabIndex = 7;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(575, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(575, 67);
            this.panel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.curves_295400_640;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // colIdPelicula
            // 
            this.colIdPelicula.Text = "Id Película";
            this.colIdPelicula.Width = 95;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 102;
            // 
            // colHora
            // 
            this.colHora.Text = "Hora";
            this.colHora.Width = 91;
            // 
            // colFechaEstreno
            // 
            this.colFechaEstreno.Text = "Fecha Estreno";
            this.colFechaEstreno.Width = 104;
            // 
            // colFechaFinalizacion
            // 
            this.colFechaFinalizacion.Text = "Fecha Finalización";
            this.colFechaFinalizacion.Width = 113;
            // 
            // mCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 598);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.tspBarraMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel);
            this.Name = "mCartelera";
            this.Text = "mCartelera";
            this.Load += new System.EventHandler(this.mCartelera_Load);
            this.tbcInformacion.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
            this.tbpInformacion.ResumeLayout(false);
            this.gboDescripcion.ResumeLayout(false);
            this.gboDescripcion.PerformLayout();
            this.gboDetalle.ResumeLayout(false);
            this.gboDetalle.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tspBarraMenu.ResumeLayout(false);
            this.tspBarraMenu.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcInformacion;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.ListView ltvInformacion;
        private System.Windows.Forms.ColumnHeader colIdCartelera;
        private System.Windows.Forms.ColumnHeader colIdSala;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gboDescripcion;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.ToolStrip tspBarraMenu;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gboDetalle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregarDetalle;
        private System.Windows.Forms.ToolStripButton btnEliminarDetalle;
        private System.Windows.Forms.ListView ltvDetalle;
        private System.Windows.Forms.ComboBox cboSala;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacion;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.DateTimePicker dtpHoraPelicula;
        private System.Windows.Forms.Label lblHoraPelicula;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.ColumnHeader colIdPelicula;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colHora;
        private System.Windows.Forms.ColumnHeader colFechaEstreno;
        private System.Windows.Forms.ColumnHeader colFechaFinalizacion;
    }
}