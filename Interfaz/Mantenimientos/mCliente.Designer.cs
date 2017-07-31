namespace Interfaz.Mantenimientos
{
    partial class mCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mCliente));
            this.tbcInformacion = new System.Windows.Forms.TabControl();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.ltvInformacion = new System.Windows.Forms.ListView();
            this.colIdIGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbpInformacion = new System.Windows.Forms.TabPage();
            this.gboDescripcion = new System.Windows.Forms.GroupBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tspBarraMenu = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblIdTipoCliente = new System.Windows.Forms.Label();
            this.lnkPersona = new System.Windows.Forms.LinkLabel();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
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
            this.colIdIGenero,
            this.ColDescripcion});
            this.ltvInformacion.GridLines = true;
            this.ltvInformacion.Location = new System.Drawing.Point(6, 6);
            this.ltvInformacion.Name = "ltvInformacion";
            this.ltvInformacion.Size = new System.Drawing.Size(540, 340);
            this.ltvInformacion.TabIndex = 0;
            this.ltvInformacion.UseCompatibleStateImageBehavior = false;
            this.ltvInformacion.View = System.Windows.Forms.View.Details;
            // 
            // colIdIGenero
            // 
            this.colIdIGenero.Text = "Identificador Genero";
            this.colIdIGenero.Width = 114;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Text = "Descripcion";
            this.ColDescripcion.Width = 421;
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
            // gboDescripcion
            // 
            this.gboDescripcion.Controls.Add(this.txtNombre);
            this.gboDescripcion.Controls.Add(this.txtIdPersona);
            this.gboDescripcion.Controls.Add(this.lnkPersona);
            this.gboDescripcion.Controls.Add(this.comboBox2);
            this.gboDescripcion.Controls.Add(this.lblIdTipoCliente);
            this.gboDescripcion.Controls.Add(this.lblIdentificador);
            this.gboDescripcion.Controls.Add(this.lblId);
            this.gboDescripcion.Location = new System.Drawing.Point(6, 12);
            this.gboDescripcion.Name = "gboDescripcion";
            this.gboDescripcion.Size = new System.Drawing.Size(539, 105);
            this.gboDescripcion.TabIndex = 5;
            this.gboDescripcion.TabStop = false;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
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
            this.tspBarraMenu.Size = new System.Drawing.Size(580, 25);
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
            this.panel1.Size = new System.Drawing.Size(580, 66);
            this.panel1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(79, 69);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // lblIdTipoCliente
            // 
            this.lblIdTipoCliente.AutoSize = true;
            this.lblIdTipoCliente.Location = new System.Drawing.Point(7, 72);
            this.lblIdTipoCliente.Name = "lblIdTipoCliente";
            this.lblIdTipoCliente.Size = new System.Drawing.Size(66, 13);
            this.lblIdTipoCliente.TabIndex = 5;
            this.lblIdTipoCliente.Text = "Tipo Cliente:";
            // 
            // lnkPersona
            // 
            this.lnkPersona.AutoSize = true;
            this.lnkPersona.Location = new System.Drawing.Point(7, 46);
            this.lnkPersona.Name = "lnkPersona";
            this.lnkPersona.Size = new System.Drawing.Size(49, 13);
            this.lnkPersona.TabIndex = 7;
            this.lnkPersona.TabStop = true;
            this.lnkPersona.Text = "Persona:";
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Location = new System.Drawing.Point(79, 43);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(58, 20);
            this.txtIdPersona.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(383, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // mCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 503);
            this.Controls.Add(this.tspBarraMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcInformacion);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mCliente";
            this.Text = "Cliente";
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
        private System.Windows.Forms.ColumnHeader colIdIGenero;
        private System.Windows.Forms.ColumnHeader ColDescripcion;
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblIdTipoCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.LinkLabel lnkPersona;
    }
}