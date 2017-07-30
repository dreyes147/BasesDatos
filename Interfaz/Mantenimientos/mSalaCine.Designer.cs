namespace Interfaz.Mantenimientos
{
    partial class mSalaCine
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mSalaCine));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tspBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColCantidadAsientos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdEstadoSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoProyeccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.gboDescripcion = new System.Windows.Forms.GroupBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsignarAsientos = new System.Windows.Forms.Button();
            this.lblEstadoSala = new System.Windows.Forms.Label();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.lblTipoProyeccion = new System.Windows.Forms.Label();
            this.cboTipoProyeccion = new System.Windows.Forms.ComboBox();
            this.cboEstadoSala = new System.Windows.Forms.ComboBox();
            this.cboTipoSala = new System.Windows.Forms.ComboBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPrecioEntrada = new System.Windows.Forms.TextBox();
            this.lblPrecioEntrada = new System.Windows.Forms.Label();
            this.tbpAsientos = new System.Windows.Forms.TabPage();
            this.btnRegresarAsiento = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.btnAsignarAsiento = new System.Windows.Forms.Button();
            this.ltvAsientos = new System.Windows.Forms.ListView();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gboBotones = new System.Windows.Forms.GroupBox();
            this.gboSala = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tspBarraMenu.SuspendLayout();
            this.tbcInformacion.SuspendLayout();
            this.tbpLista.SuspendLayout();
            this.tbpInformacion.SuspendLayout();
            this.gboDescripcion.SuspendLayout();
            this.tbpAsientos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Menu.SuspendLayout();
            this.gboBotones.SuspendLayout();
            this.gboSala.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(918, 66);
            this.panel1.TabIndex = 10;
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
            // tspBarraMenu
            // 
            this.tspBarraMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar});
            this.tspBarraMenu.Location = new System.Drawing.Point(0, 66);
            this.tspBarraMenu.Name = "tspBarraMenu";
            this.tspBarraMenu.Size = new System.Drawing.Size(918, 25);
            this.tspBarraMenu.TabIndex = 12;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpInformacion);
            this.tbcInformacion.Controls.Add(this.tbpAsientos);
            this.tbcInformacion.Location = new System.Drawing.Point(12, 103);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(898, 550);
            this.tbcInformacion.TabIndex = 13;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.ltvInformacion);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(890, 524);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // ltvInformacion
            // 
            this.ltvInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvInformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdSala,
            this.ColCantidadAsientos,
            this.colIdEstadoSala,
            this.colTipoSala,
            this.colTipoProyeccion,
            this.colPrecioEntrada});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(6, 6);
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(878, 512);
            this.ltvInformacion.TabIndex = 0;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            // 
            // colIdSala
            // 
            this.colIdSala.Text = "Identificador Sala";
            this.colIdSala.Width = 133;
            // 
            // ColCantidadAsientos
            // 
            this.ColCantidadAsientos.Text = "Cantidad Asientos";
            this.ColCantidadAsientos.Width = 114;
            // 
            // colIdEstadoSala
            // 
            this.colIdEstadoSala.Text = "Estado Sala";
            this.colIdEstadoSala.Width = 115;
            // 
            // colTipoSala
            // 
            this.colTipoSala.Text = "Tipo Sala";
            this.colTipoSala.Width = 152;
            // 
            // colTipoProyeccion
            // 
            this.colTipoProyeccion.Text = "Proyeccion";
            this.colTipoProyeccion.Width = 164;
            // 
            // colPrecioEntrada
            // 
            this.colPrecioEntrada.Text = "Precio Entrada";
            this.colPrecioEntrada.Width = 196;
            // 
            // tbpInformacion
            // 
            this.tbpInformacion.Controls.Add(this.gboBotones);
            this.tbpInformacion.Controls.Add(this.gboDescripcion);
            this.tbpInformacion.Location = new System.Drawing.Point(4, 22);
            this.tbpInformacion.Name = "tbpInformacion";
            this.tbpInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInformacion.Size = new System.Drawing.Size(890, 524);
            this.tbpInformacion.TabIndex = 1;
            this.tbpInformacion.Text = "Información";
            this.tbpInformacion.UseVisualStyleBackColor = true;
            // 
            // gboDescripcion
            // 
            this.gboDescripcion.Controls.Add(this.lblEstadoSala);
            this.gboDescripcion.Controls.Add(this.lblTipoSala);
            this.gboDescripcion.Controls.Add(this.lblTipoProyeccion);
            this.gboDescripcion.Controls.Add(this.cboTipoProyeccion);
            this.gboDescripcion.Controls.Add(this.cboEstadoSala);
            this.gboDescripcion.Controls.Add(this.cboTipoSala);
            this.gboDescripcion.Controls.Add(this.lblIdentificador);
            this.gboDescripcion.Controls.Add(this.lblId);
            this.gboDescripcion.Controls.Add(this.txtPrecioEntrada);
            this.gboDescripcion.Controls.Add(this.lblPrecioEntrada);
            this.gboDescripcion.Location = new System.Drawing.Point(6, 12);
            this.gboDescripcion.Name = "gboDescripcion";
            this.gboDescripcion.Size = new System.Drawing.Size(878, 137);
            this.gboDescripcion.TabIndex = 5;
            this.gboDescripcion.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::Interfaz.Properties.Resources.flecha_atras_izquierda_de_angulo_de_regresar;
            this.btnRegresar.Location = new System.Drawing.Point(792, 48);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Interfaz.Properties.Resources.comprobado;
            this.btnAceptar.Location = new System.Drawing.Point(706, 48);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Interfaz.Properties.Resources.logout__1_;
            this.btnSalir.Location = new System.Drawing.Point(11, 48);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsignarAsientos
            // 
            this.btnAsignarAsientos.Image = global::Interfaz.Properties.Resources.sillon__8_;
            this.btnAsignarAsientos.Location = new System.Drawing.Point(706, 19);
            this.btnAsignarAsientos.Name = "btnAsignarAsientos";
            this.btnAsignarAsientos.Size = new System.Drawing.Size(161, 23);
            this.btnAsignarAsientos.TabIndex = 8;
            this.btnAsignarAsientos.Text = "Asignar Asientos";
            this.btnAsignarAsientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignarAsientos.UseVisualStyleBackColor = true;
            this.btnAsignarAsientos.Click += new System.EventHandler(this.btnAsignarAsientos_Click);
            // 
            // lblEstadoSala
            // 
            this.lblEstadoSala.AutoSize = true;
            this.lblEstadoSala.Location = new System.Drawing.Point(8, 71);
            this.lblEstadoSala.Name = "lblEstadoSala";
            this.lblEstadoSala.Size = new System.Drawing.Size(67, 13);
            this.lblEstadoSala.TabIndex = 16;
            this.lblEstadoSala.Text = "Estado Sala:";
            // 
            // lblTipoSala
            // 
            this.lblTipoSala.AutoSize = true;
            this.lblTipoSala.Location = new System.Drawing.Point(8, 41);
            this.lblTipoSala.Name = "lblTipoSala";
            this.lblTipoSala.Size = new System.Drawing.Size(55, 13);
            this.lblTipoSala.TabIndex = 15;
            this.lblTipoSala.Text = "Tipo Sala:";
            // 
            // lblTipoProyeccion
            // 
            this.lblTipoProyeccion.AutoSize = true;
            this.lblTipoProyeccion.Location = new System.Drawing.Point(8, 98);
            this.lblTipoProyeccion.Name = "lblTipoProyeccion";
            this.lblTipoProyeccion.Size = new System.Drawing.Size(93, 13);
            this.lblTipoProyeccion.TabIndex = 14;
            this.lblTipoProyeccion.Text = "Tipo Proyeccipón:";
            // 
            // cboTipoProyeccion
            // 
            this.cboTipoProyeccion.FormattingEnabled = true;
            this.cboTipoProyeccion.Location = new System.Drawing.Point(131, 95);
            this.cboTipoProyeccion.Name = "cboTipoProyeccion";
            this.cboTipoProyeccion.Size = new System.Drawing.Size(219, 21);
            this.cboTipoProyeccion.TabIndex = 13;
            // 
            // cboEstadoSala
            // 
            this.cboEstadoSala.FormattingEnabled = true;
            this.cboEstadoSala.Location = new System.Drawing.Point(131, 68);
            this.cboEstadoSala.Name = "cboEstadoSala";
            this.cboEstadoSala.Size = new System.Drawing.Size(219, 21);
            this.cboEstadoSala.TabIndex = 12;
            // 
            // cboTipoSala
            // 
            this.cboTipoSala.FormattingEnabled = true;
            this.cboTipoSala.Location = new System.Drawing.Point(131, 38);
            this.cboTipoSala.Name = "cboTipoSala";
            this.cboTipoSala.Size = new System.Drawing.Size(219, 21);
            this.cboTipoSala.TabIndex = 11;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(8, 16);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(21, 13);
            this.lblIdentificador.TabIndex = 3;
            this.lblIdentificador.Text = "ID:";
            this.lblIdentificador.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // txtPrecioEntrada
            // 
            this.txtPrecioEntrada.Location = new System.Drawing.Point(658, 43);
            this.txtPrecioEntrada.MaxLength = 40;
            this.txtPrecioEntrada.Name = "txtPrecioEntrada";
            this.txtPrecioEntrada.Size = new System.Drawing.Size(209, 20);
            this.txtPrecioEntrada.TabIndex = 0;
            this.txtPrecioEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioEntrada.Leave += new System.EventHandler(this.txtPrecioEntrada_Leave);
            // 
            // lblPrecioEntrada
            // 
            this.lblPrecioEntrada.AutoSize = true;
            this.lblPrecioEntrada.Location = new System.Drawing.Point(572, 46);
            this.lblPrecioEntrada.Name = "lblPrecioEntrada";
            this.lblPrecioEntrada.Size = new System.Drawing.Size(80, 13);
            this.lblPrecioEntrada.TabIndex = 1;
            this.lblPrecioEntrada.Text = "Precio Entrada:";
            // 
            // tbpAsientos
            // 
            this.tbpAsientos.Controls.Add(this.gboSala);
            this.tbpAsientos.Controls.Add(this.btnRegresarAsiento);
            this.tbpAsientos.Controls.Add(this.btnAsignarAsiento);
            this.tbpAsientos.Location = new System.Drawing.Point(4, 22);
            this.tbpAsientos.Name = "tbpAsientos";
            this.tbpAsientos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsientos.Size = new System.Drawing.Size(890, 524);
            this.tbpAsientos.TabIndex = 2;
            this.tbpAsientos.Text = "Asientos";
            this.tbpAsientos.UseVisualStyleBackColor = true;
            // 
            // btnRegresarAsiento
            // 
            this.btnRegresarAsiento.Image = global::Interfaz.Properties.Resources.flecha_atras_izquierda_de_angulo_de_regresar;
            this.btnRegresarAsiento.Location = new System.Drawing.Point(419, 485);
            this.btnRegresarAsiento.Name = "btnRegresarAsiento";
            this.btnRegresarAsiento.Size = new System.Drawing.Size(125, 31);
            this.btnRegresarAsiento.TabIndex = 3;
            this.btnRegresarAsiento.Text = "Regresar";
            this.btnRegresarAsiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresarAsiento.UseVisualStyleBackColor = true;
            this.btnRegresarAsiento.Click += new System.EventHandler(this.btnRegresarAsiento_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblPantalla);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 48);
            this.panel2.TabIndex = 2;
            // 
            // lblPantalla
            // 
            this.lblPantalla.AutoSize = true;
            this.lblPantalla.Location = new System.Drawing.Point(410, 18);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Size = new System.Drawing.Size(45, 13);
            this.lblPantalla.TabIndex = 0;
            this.lblPantalla.Text = "Pantalla";
            // 
            // btnAsignarAsiento
            // 
            this.btnAsignarAsiento.Image = global::Interfaz.Properties.Resources.boton_de_suma;
            this.btnAsignarAsiento.Location = new System.Drawing.Point(272, 485);
            this.btnAsignarAsiento.Name = "btnAsignarAsiento";
            this.btnAsignarAsiento.Size = new System.Drawing.Size(122, 31);
            this.btnAsignarAsiento.TabIndex = 1;
            this.btnAsignarAsiento.Text = "Agregar Asientos";
            this.btnAsignarAsiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignarAsiento.UseVisualStyleBackColor = true;
            this.btnAsignarAsiento.Click += new System.EventHandler(this.btnAsignarAsiento_Click);
            // 
            // ltvAsientos
            // 
            this.ltvAsientos.ContextMenuStrip = this.Menu;
            this.ltvAsientos.LargeImageList = this.imageList;
            this.ltvAsientos.Location = new System.Drawing.Point(6, 67);
            this.ltvAsientos.Name = "ltvAsientos";
            this.ltvAsientos.Size = new System.Drawing.Size(866, 393);
            this.ltvAsientos.SmallImageList = this.imageList;
            this.ltvAsientos.TabIndex = 0;
            this.ltvAsientos.UseCompatibleStateImageBehavior = false;
            this.ltvAsientos.DoubleClick += new System.EventHandler(this.ltvAsientos_DoubleClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Interfaz.Properties.Resources.eliminar__1_;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "sillon (3).png");
            this.imageList.Images.SetKeyName(1, "sillon (2).png");
            this.imageList.Images.SetKeyName(2, "sillon (1).png");
            this.imageList.Images.SetKeyName(3, "sillon.png");
            // 
            // gboBotones
            // 
            this.gboBotones.Controls.Add(this.btnAsignarAsientos);
            this.gboBotones.Controls.Add(this.btnRegresar);
            this.gboBotones.Controls.Add(this.btnSalir);
            this.gboBotones.Controls.Add(this.btnAceptar);
            this.gboBotones.Location = new System.Drawing.Point(6, 149);
            this.gboBotones.Name = "gboBotones";
            this.gboBotones.Size = new System.Drawing.Size(878, 93);
            this.gboBotones.TabIndex = 9;
            this.gboBotones.TabStop = false;
            // 
            // gboSala
            // 
            this.gboSala.Controls.Add(this.panel2);
            this.gboSala.Controls.Add(this.ltvAsientos);
            this.gboSala.Location = new System.Drawing.Point(6, 6);
            this.gboSala.Name = "gboSala";
            this.gboSala.Size = new System.Drawing.Size(878, 473);
            this.gboSala.TabIndex = 4;
            this.gboSala.TabStop = false;
            // 
            // mSalaCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 684);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.tspBarraMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mSalaCine";
            this.Text = "SalaCine";
            this.Load += new System.EventHandler(this.mSalaCine_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tspBarraMenu.ResumeLayout(false);
            this.tspBarraMenu.PerformLayout();
            this.tbcInformacion.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
            this.tbpInformacion.ResumeLayout(false);
            this.gboDescripcion.ResumeLayout(false);
            this.gboDescripcion.PerformLayout();
            this.tbpAsientos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.gboBotones.ResumeLayout(false);
            this.gboSala.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tspBarraMenu;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tbcInformacion;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.ListView ltvInformacion;
        private System.Windows.Forms.ColumnHeader colIdSala;
        private System.Windows.Forms.ColumnHeader ColCantidadAsientos;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gboDescripcion;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPrecioEntrada;
        private System.Windows.Forms.TabPage tbpAsientos;
        private System.Windows.Forms.Button btnAsignarAsientos;
        private System.Windows.Forms.ListView ltvAsientos;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnAsignarAsiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label lblEstadoSala;
        private System.Windows.Forms.Label lblTipoSala;
        private System.Windows.Forms.Label lblTipoProyeccion;
        private System.Windows.Forms.ComboBox cboTipoProyeccion;
        private System.Windows.Forms.ComboBox cboEstadoSala;
        private System.Windows.Forms.ComboBox cboTipoSala;
        private System.Windows.Forms.TextBox txtPrecioEntrada;
        private System.Windows.Forms.Button btnRegresarAsiento;
        private System.Windows.Forms.ColumnHeader colIdEstadoSala;
        private System.Windows.Forms.ColumnHeader colTipoSala;
        private System.Windows.Forms.ColumnHeader colTipoProyeccion;
        private System.Windows.Forms.ColumnHeader colPrecioEntrada;
        private System.Windows.Forms.GroupBox gboBotones;
        private System.Windows.Forms.GroupBox gboSala;
    }
}