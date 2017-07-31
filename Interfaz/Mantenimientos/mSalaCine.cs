using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Mantenimientos
{
    public partial class mSalaCine : Form
    {
        public mSalaCine()
        {
            InitializeComponent();
        }

        #region Declaracion de Variables

        private string vModo = string.Empty;

        #endregion

        #region Declaracion de Metodos

        private void Inicializar()
        {
            try
            {
                CargarVista();
                InicializarCombos();
                tbpInformacion.Parent = null;
                tbpAsientos.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CargarVista()
        {
            DataTable vResultados = new DataTable();
            Negocio.Clases.SalaCine vPrx = new Negocio.Clases.SalaCine();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPrx.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = ltvInformacion.Items.Add(vRow["IdSala"].ToString());
                    vItem.SubItems.Add(vRow["CantidadAsientos"].ToString());
                    vItem.SubItems.Add(vRow["IdEstadoSala"].ToString());
                    vItem.SubItems.Add(vRow["IdTipoSala"].ToString());
                    vItem.SubItems.Add(vRow["IdTipoProyeccion"].ToString());
                    vItem.SubItems.Add(vRow["PrecioEntrada"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        private void OcultarTab()
        {
            try
            {
                tbpInformacion.Parent = tbcInformacion;
                tbcInformacion.SelectedTab = tbpInformacion;
                tbpLista.Parent = null;
                tbpAsientos.Parent = null;
                tspBarraMenu.Visible = false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void InicializarCombos()
        {
            Negocio.Clases.TipoSala vProxyTipoSala = new Negocio.Clases.TipoSala();
            Negocio.Clases.EstadoSala vProxyEstadoSala = new Negocio.Clases.EstadoSala();
            Negocio.Clases.TipoProyeccion vProxyTipoProyeccion = new Negocio.Clases.TipoProyeccion();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();
            try
            {
                cboEstadoSala.DataSource = vProxyEstadoSala.Selecccionar(vFiltro);
                cboEstadoSala.DisplayMember = "DescripcionEstado";
                cboEstadoSala.ValueMember = "IdEstadoSala";

                cboTipoProyeccion.DataSource = vProxyTipoProyeccion.Selecccionar(vFiltro);
                cboTipoProyeccion.DisplayMember = "DescripcionTipoProyeccion";
                cboTipoProyeccion.ValueMember = "IdTipoProyeccion";

                cboTipoSala.DataSource = vProxyTipoSala.Selecccionar(vFiltro);
                cboTipoSala.DisplayMember = "DescripcionTipoSala";
                cboTipoSala.ValueMember = "IdTipoSala";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        private void Leer() {
            try
            {
                ListViewItem vAsiento = new ListViewItem();
                Negocio.Clases.AsientoSalaCine vNegocioAsientos = new Negocio.Clases.AsientoSalaCine();
                ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
                List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
                List<Comunes.Estructuras.AsientoSalaCine> vAsientos = new List<Comunes.Estructuras.AsientoSalaCine> ();
                try
                {
                        foreach (ListViewItem vItem in vSeleccionados)
                        {
                            lblId.Text = vItem.SubItems[0].Text;
                            cboEstadoSala.SelectedValue = vItem.SubItems[2].Text;
                            cboTipoSala.SelectedValue = vItem.SubItems[3].Text;
                            cboTipoProyeccion.SelectedValue = vItem.SubItems[4].Text;
                            txtPrecioEntrada.Text = vItem.SubItems[5].Text;
                        }
                        vFiltros.Add(new Comunes.Filtros.Filtro("IdSala", "=", Convert.ToInt32(lblId.Text)));
                        vAsientos = vNegocioAsientos.SelecccionarLista(vFiltros);
                        foreach (Comunes.Estructuras.AsientoSalaCine vItem in vAsientos)
                        {
                            vAsiento = new ListViewItem();
                            vAsiento.ImageIndex = 3;
                            vAsiento.Tag = vItem;
                            ltvAsientos.Items.Add(vAsiento);
                        }

                        lblId.Visible = true;
                        lblIdentificador.Visible = true;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos

        private void mSalaCine_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAsignarAsientos_Click(object sender, EventArgs e)
        {
            try
            {
                tbpAsientos.Parent= tbcInformacion ;
                tbcInformacion.SelectedTab = tbpAsientos;
                tbpInformacion.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAsignarAsiento_Click(object sender, EventArgs e)
        {
            Comunes.Estructuras.AsientoSalaCine vEstructura = new Comunes.Estructuras.AsientoSalaCine();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vItem.ImageIndex = 0;
                vItem.Tag = vEstructura;
                ltvAsientos.Items.Add(vItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ltvAsientos_DoubleClick(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mAsientos vMantenimientoAsientos = new Interfaz.Mantenimientos.mAsientos();
            try
            {
                vMantenimientoAsientos.Estructura = (Comunes.Estructuras.AsientoSalaCine)ltvAsientos.SelectedItems[0].Tag;
                vMantenimientoAsientos.StartPosition = FormStartPosition.CenterScreen;
                vMantenimientoAsientos.ShowDialog();
                ltvAsientos.SelectedItems[0].Tag = vMantenimientoAsientos.Estructura;
                ltvAsientos.SelectedItems[0].ImageIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> vItems = new List<int>();
            try
            {
                foreach (ListViewItem vItem in ltvAsientos.SelectedItems)
                {
                    vItems.Add(vItem.Index);
                }
                vItems.Sort();
                for (int i = vItems.Count - 1; i >= 0; i--)
                {
                    ltvAsientos.Items.RemoveAt(vItems[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtPrecioEntrada_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPrecioEntrada.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(txtPrecioEntrada.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                OcultarTab();
                vModo = "A";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltvInformacion.SelectedIndices.Count > 0)
                {
                    OcultarTab();
                    vModo = "M";
                    Leer();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ltvInformacion.SelectedIndices.Count > 0)
                {
                    OcultarTab();
                    vModo = "E";
                    Leer();
                    gboDescripcion.Enabled = false;
                    gboSala.Enabled = false;
                    btnAsignarAsiento.Enabled = false;
                }
                else
                {
                MessageBox.Show("Favor seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Comunes.Estructuras.SalaCine vEstructuraSalaCine = new Comunes.Estructuras.SalaCine();
            Comunes.Estructuras.AsientoSalaCine vEstructuraAsientos = new Comunes.Estructuras.AsientoSalaCine();
            Negocio.Clases.SalaCine vNegocio = new Negocio.Clases.SalaCine();
            Negocio.Clases.AsientoSalaCine vNegocioAsientos = new Negocio.Clases.AsientoSalaCine();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            List<Comunes.Estructuras.AsientoSalaCine> vAsientos = new List<Comunes.Estructuras.AsientoSalaCine>();
            int vContador = 0;
            try
            {
                if (txtPrecioEntrada.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("El campo Precio Entrada no puede contener un valor no válido, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ltvAsientos.Items.Count == 0)
                {
                    MessageBox.Show("Debe ingresar al menos un asiento, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                vEstructuraSalaCine.IdTipoSala = Convert.ToInt32(cboTipoSala.SelectedValue.ToString());
                vEstructuraSalaCine.IdTipoProyeccion = Convert.ToInt32(cboTipoProyeccion.SelectedValue.ToString());
                vEstructuraSalaCine.IdEstadoSala = Convert.ToInt32(cboEstadoSala.SelectedValue.ToString());
                vEstructuraSalaCine.CantidadAsientos = ltvAsientos.Items.Count;
                vEstructuraSalaCine.PrecioEntrada = Convert.ToDecimal(txtPrecioEntrada.Text);

                foreach (ListViewItem vItem in ltvAsientos.Items)
                {
                    vContador += 1;
                    vEstructuraAsientos = (Comunes.Estructuras.AsientoSalaCine)vItem.Tag;
                    vEstructuraAsientos.IdNumeroAsiento = vContador;
                    vEstructuraAsientos.IdSala = Convert.ToInt32(lblId.Text);
                    vAsientos.Add(vEstructuraAsientos);
                }


                switch (vModo)
                {
                    case "A":
                        vEstructuraSalaCine.IdSala = 0;
                        vNegocio.Insertar(vEstructuraSalaCine, vAsientos);
                        break;
                    case "M":
                        vEstructuraSalaCine.IdSala = Convert.ToInt32(lblId.Text);
                        vFiltros.Add(new Comunes.Filtros.Filtro("IdSala", "=", Convert.ToInt32(lblId.Text)));
                        vNegocio.Actualizar(vEstructuraSalaCine, vFiltros, vAsientos);
                        tbpLista.Parent = tbcInformacion;
                        tbcInformacion.SelectedTab = tbpLista;
                        tspBarraMenu.Visible = true;
                        tbpInformacion.Parent = null;
                        vModo = string.Empty;
                        CargarVista();
                        break;

                    default:
                        vFiltros.Add(new Comunes.Filtros.Filtro("IdSala", "=", Convert.ToInt32(lblId.Text)));
                        vNegocio.Eliminar(vFiltros);
                        vNegocioAsientos.Eliminar(vFiltros);
                        tbpLista.Parent = tbcInformacion;
                        tbcInformacion.SelectedTab = tbpLista;
                        tspBarraMenu.Visible = true;
                        tbpInformacion.Parent = null;
                        vModo = string.Empty;
                        CargarVista();
                        gboDescripcion.Enabled = true;
                        gboSala.Enabled = true;
                        btnAsignarAsiento.Enabled = true;
                        break;
                }

                MessageBox.Show("El proceso a finalizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVista();
                ltvAsientos.Items.Clear();
                lblId.Text = string.Empty;
                txtPrecioEntrada.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try
            {
                tbpLista.Parent = tbcInformacion;
                tbcInformacion.SelectedTab = tbpLista;
                tspBarraMenu.Visible = true;
                tbpInformacion.Parent = null;
                vModo = string.Empty;
                CargarVista();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnRegresarAsiento_Click(object sender, EventArgs e)
        {
            try
            {
                tbpInformacion.Parent = tbcInformacion;
                tbcInformacion.SelectedTab = tbpInformacion;
                tbpAsientos.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion



    }
}
