namespace Interfaz.Mantenimientos
{
    partial class mPersonalAdministrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mPersonalAdministrativo));
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdTIpoPersona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gboDescripcion = new System.Windows.Forms.GroupBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
            this.lnkPersona = new System.Windows.Forms.LinkLabel();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tspBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colIdArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbcInformacion.SuspendLayout();
            this.tbpLista.SuspendLayout();
            this.tbpInformacion.SuspendLayout();
            this.gboDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tspBarraMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcInformacion
            // 
            this.tbcInformacion.Controls.Add(this.tbpLista);
            this.tbcInformacion.Controls.Add(this.tbpInformacion);
            this.tbcInformacion.Location = new System.Drawing.Point(12, 94);
            this.tbcInformacion.Name = "tbcInformacion";
            this.tbcInformacion.SelectedIndex = 0;
            this.tbcInformacion.Size = new System.Drawing.Size(559, 378);
            this.tbcInformacion.TabIndex = 8;
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.ltvInformacion);
            this.tbpLista.Location = new System.Drawing.Point(4, 22);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(551, 352);
            this.tbpLista.TabIndex = 0;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // ltvInformacion
            // 
            this.ltvInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltvInformacion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdPersona,
            this.colIdTIpoPersona,
            this.colIdArea});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(6, 6);
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(540, 340);
            this.ltvInformacion.TabIndex = 0;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            // 
            // colIdPersona
            // 
            this.colIdPersona.Text = "Identificador Persona";
            this.colIdPersona.Width = 179;
            // 
            // colIdTIpoPersona
            // 
            this.colIdTIpoPersona.Text = "Id Tipo Persona";
            this.colIdTIpoPersona.Width = 194;
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
            this.tbpInformacion.Size = new System.Drawing.Size(551, 352);
            this.tbpInformacion.TabIndex = 1;
            this.tbpInformacion.Text = "Información";
            this.tbpInformacion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Interfaz.Properties.Resources.logout__1_;
            this.btnSalir.Location = new System.Drawing.Point(16, 317);
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
            this.btnAceptar.Location = new System.Drawing.Point(376, 317);
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
            this.btnRegresar.Location = new System.Drawing.Point(457, 317);
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
            this.gboDescripcion.Controls.Add(this.cboArea);
            this.gboDescripcion.Controls.Add(this.lblArea);
            this.gboDescripcion.Controls.Add(this.txtNombre);
            this.gboDescripcion.Controls.Add(this.txtIdPersona);
            this.gboDescripcion.Controls.Add(this.lnkPersona);
            this.gboDescripcion.Controls.Add(this.lblIdentificador);
            this.gboDescripcion.Controls.Add(this.lblId);
            this.gboDescripcion.Location = new System.Drawing.Point(6, 12);
            this.gboDescripcion.Name = "gboDescripcion";
            this.gboDescripcion.Size = new System.Drawing.Size(539, 105);
            this.gboDescripcion.TabIndex = 5;
            this.gboDescripcion.TabStop = false;
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(62, 61);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(121, 21);
            this.cboArea.TabIndex = 14;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 64);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 13;
            this.lblArea.Text = "Área";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Location = new System.Drawing.Point(62, 35);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(58, 20);
            this.txtIdPersona.TabIndex = 11;
            // 
            // lnkPersona
            // 
            this.lnkPersona.AutoSize = true;
            this.lnkPersona.Location = new System.Drawing.Point(7, 38);
            this.lnkPersona.Name = "lnkPersona";
            this.lnkPersona.Size = new System.Drawing.Size(49, 13);
            this.lnkPersona.TabIndex = 10;
            this.lnkPersona.TabStop = true;
            this.lnkPersona.Text = "Persona:";
            this.lnkPersona.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPersona_LinkClicked);
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(579, 22);
            this.statusStrip1.TabIndex = 10;
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
            // tspBarraMenu
            // 
            this.tspBarraMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar});
            this.tspBarraMenu.Location = new System.Drawing.Point(0, 66);
            this.tspBarraMenu.Name = "tspBarraMenu";
            this.tspBarraMenu.Size = new System.Drawing.Size(579, 25);
            this.tspBarraMenu.TabIndex = 18;
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
            this.panel1.Size = new System.Drawing.Size(579, 66);
            this.panel1.TabIndex = 17;
            // 
            // colIdArea
            // 
            this.colIdArea.Text = "Id Área";
            this.colIdArea.Width = 161;
            // 
            // mPersonalAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 502);
            this.Controls.Add(this.tspBarraMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mPersonalAdministrativo";
            this.Text = "PersonalAdministrativo";
            this.Load += new System.EventHandler(this.mPersonalAdministrativo_Load);
            this.tbcInformacion.ResumeLayout(false);
            this.tbpLista.ResumeLayout(false);
            this.tbpInformacion.ResumeLayout(false);
            this.gboDescripcion.ResumeLayout(false);
            this.gboDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tspBarraMenu.ResumeLayout(false);
            this.tspBarraMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbcInformacion;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.ListView ltvInformacion;
        private System.Windows.Forms.ColumnHeader colIdPersona;
        private System.Windows.Forms.ColumnHeader colIdTIpoPersona;
        private System.Windows.Forms.TabPage tbpInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox gboDescripcion;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tspBarraMenu;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.LinkLabel lnkPersona;
        private System.Windows.Forms.ColumnHeader colIdArea;
    }
}