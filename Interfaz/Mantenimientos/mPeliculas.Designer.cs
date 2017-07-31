namespace Interfaz.Mantenimientos
{
    partial class mPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mPeliculas));
            this.tspBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdEstadoSala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gboDescripcion = new System.Windows.Forms.GroupBox();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTituloPelícula = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombrePelicula = new System.Windows.Forms.TextBox();
            this.lblNombrePelicula = new System.Windows.Forms.Label();
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
            this.tspBarraMenu.Size = new System.Drawing.Size(607, 25);
            this.tspBarraMenu.TabIndex = 23;
            this.tspBarraMenu.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Interfaz.Properties.Resources.boton_de_suma;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnAgregar.Text = "Agregar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Interfaz.Properties.Resources.editar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Interfaz.Properties.Resources.eliminar__1_;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 66);
            this.panel1.TabIndex = 22;
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
            this.tbcInformacion.Location = new System.Drawing.Point(12, 95);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(586, 339);
            this.tbcInformacion.TabIndex = 21;
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
            this.colIdEstadoSala,
            this.ColDescripcion});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(6, 6);
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(557, 340);
            this.ltvInformacion.TabIndex = 0;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            // 
            // colIdEstadoSala
            // 
            this.colIdEstadoSala.Text = "Identificador Estado Sala";
            this.colIdEstadoSala.Width = 135;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Text = "Descripcion";
            this.ColDescripcion.Width = 417;
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
            // 
            // gboDescripcion
            // 
            this.gboDescripcion.Controls.Add(this.txtTituloPelicula);
            this.gboDescripcion.Controls.Add(this.txtIdioma);
            this.gboDescripcion.Controls.Add(this.comboBox1);
            this.gboDescripcion.Controls.Add(this.lblSubtitulo);
            this.gboDescripcion.Controls.Add(this.lblTituloPelícula);
            this.gboDescripcion.Controls.Add(this.lblIdioma);
            this.gboDescripcion.Controls.Add(this.lblIdentificador);
            this.gboDescripcion.Controls.Add(this.lblId);
            this.gboDescripcion.Controls.Add(this.txtNombrePelicula);
            this.gboDescripcion.Controls.Add(this.lblNombrePelicula);
            this.gboDescripcion.Location = new System.Drawing.Point(15, 12);
            this.gboDescripcion.Name = "gboDescripcion";
            this.gboDescripcion.Size = new System.Drawing.Size(557, 119);
            this.gboDescripcion.TabIndex = 5;
            this.gboDescripcion.TabStop = false;
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Location = new System.Drawing.Point(96, 64);
            this.txtTituloPelicula.MaxLength = 40;
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(255, 20);
            this.txtTituloPelicula.TabIndex = 9;
            // 
            // txtIdioma
            // 
            this.txtIdioma.FormattingEnabled = true;
            this.txtIdioma.Location = new System.Drawing.Point(419, 64);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(132, 21);
            this.txtIdioma.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(357, 41);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(56, 13);
            this.lblSubtitulo.TabIndex = 6;
            this.lblSubtitulo.Text = "Subtitulos:";
            // 
            // lblTituloPelícula
            // 
            this.lblTituloPelícula.AutoSize = true;
            this.lblTituloPelícula.Location = new System.Drawing.Point(7, 67);
            this.lblTituloPelícula.Name = "lblTituloPelícula";
            this.lblTituloPelícula.Size = new System.Drawing.Size(78, 13);
            this.lblTituloPelícula.TabIndex = 5;
            this.lblTituloPelícula.Text = "Titulo Película:";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(357, 67);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma.TabIndex = 4;
            this.lblIdioma.Text = "Idioma:";
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
            // txtNombrePelicula
            // 
            this.txtNombrePelicula.Location = new System.Drawing.Point(96, 38);
            this.txtNombrePelicula.MaxLength = 40;
            this.txtNombrePelicula.Name = "txtNombrePelicula";
            this.txtNombrePelicula.Size = new System.Drawing.Size(255, 20);
            this.txtNombrePelicula.TabIndex = 0;
            // 
            // lblNombrePelicula
            // 
            this.lblNombrePelicula.AutoSize = true;
            this.lblNombrePelicula.Location = new System.Drawing.Point(7, 41);
            this.lblNombrePelicula.Name = "lblNombrePelicula";
            this.lblNombrePelicula.Size = new System.Drawing.Size(83, 13);
            this.lblNombrePelicula.TabIndex = 1;
            this.lblNombrePelicula.Text = "Nombre Pelíula:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 438);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 460);
            this.Controls.Add(this.tspBarraMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mPeliculas";
            this.Text = "Peliculas";
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
        private System.Windows.Forms.ColumnHeader colIdEstadoSala;
        private System.Windows.Forms.ColumnHeader ColDescripcion;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gboDescripcion;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombrePelicula;
        private System.Windows.Forms.Label lblNombrePelicula;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.ComboBox txtIdioma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTituloPelícula;
        private System.Windows.Forms.Label lblIdioma;
    }
}