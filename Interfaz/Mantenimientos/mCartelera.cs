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
    public partial class mCartelera : Form
    {
        public mCartelera()
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
                CargarCombos();
                tbpInformacion.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CargarVista()
        {
            DataTable vResultados = new DataTable();
            Negocio.Clases.Idioma vPrx = new Negocio.Clases.Idioma();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPrx.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = ltvInformacion.Items.Add(vRow["IdIdioma"].ToString());
                    vItem.SubItems.Add(vRow["DescripcionIdioma"].ToString());
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
                tspBarraMenu.Visible = false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void CargarCombos() {
            Negocio.Clases.SalaCine vNegocioSala = new Negocio.Clases.SalaCine();
            Negocio.Clases.Pelicula vNegocioPelicula = new Negocio.Clases.Pelicula();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            try
            {
                cboPelicula.DataSource = vNegocioPelicula.Selecccionar(vFiltros);
                cboPelicula.DisplayMember = "NombrePelicula";
                cboPelicula.ValueMember = "IdPelicula";

                cboSala.DataSource = vNegocioSala.Selecccionar(vFiltros);
                cboSala.DisplayMember = "IdSala";
                cboSala.ValueMember = "IdSala"; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        private void Leer() {
            ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
            Negocio.Clases.CarteleraDetalle vProxy = new Negocio.Clases.CarteleraDetalle();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();
           
            DataTable dtDatos = new DataTable();
            try
            {
                foreach (ListViewItem vItem in vSeleccionados)
                {
                    lblId.Text = vItem.SubItems[0].Text;
                    cboSala.Text = vItem.SubItems[1].Text;
                }

                vFiltro.Add(new Comunes.Filtros.Filtro("IdCartelera", "=", Convert.ToInt32(lblId.Text)));
                dtDatos = vProxy.Selecccionar(vFiltro);
                foreach (DataRow vRow in dtDatos.Rows) {
                    ListViewItem vItem = new ListViewItem();
                    vItem = ltvInformacion.Items.Add(vRow["IdPelicula"].ToString());
                    vItem.SubItems.Add(string.Format("{0:yyyy/MM/dd}", vRow["FechaPelicula"].ToString()));
                    vItem.SubItems.Add(string.Format("{0:HH:mm}", vRow["HoraPelicula"].ToString()));
                    vItem.SubItems.Add(string.Format("{0:yyyy/MM/dd}", vRow["FechaEstreno"].ToString()));
                    vItem.SubItems.Add(string.Format("{0:yyyy/MM/dd}", vRow["FechaFinalizacion"].ToString()));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos

        private void mCartelera_Load(object sender, EventArgs e)
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
            ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
            try
            {
                if (ltvInformacion.SelectedIndices.Count > 0)
                {
                    OcultarTab();
                    vModo = "M";
                    Leer();
                    lblId.Visible = true;
                    lblIdentificador.Visible = true;
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
            ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
            try
            {
                if (ltvInformacion.SelectedIndices.Count > 0)
                {
                    OcultarTab();
                    vModo = "E";
                    Leer();
                    gboDescripcion.Enabled = false;
                    gboDetalle.Enabled = false;
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
            Comunes.Estructuras.Cartelera vEstructuraCartelera = new Comunes.Estructuras.Cartelera();
            Comunes.Estructuras.CarteleraDetalle vEstructuraDetalle = new Comunes.Estructuras.CarteleraDetalle();
            Negocio.Clases.Cartelera vNegocio = new Negocio.Clases.Cartelera();
            Negocio.Clases.CarteleraDetalle vNegocioDetalle = new Negocio.Clases.CarteleraDetalle();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            List<Comunes.Estructuras.CarteleraDetalle> vDetalles = new List<Comunes.Estructuras.CarteleraDetalle>();
            try
            {
                if (ltvDetalle.Items.Count != 0)
                {
                    vEstructuraCartelera.IdSala = Convert.ToInt32(cboSala.SelectedValue.ToString());
                    foreach (ListViewItem vItem in ltvDetalle.Items)
                    {
                        vEstructuraDetalle = new Comunes.Estructuras.CarteleraDetalle()
                        {
                            IdPelicula = Convert.ToInt32(vItem.SubItems[0].Text),
                            FechaPelicula = Convert.ToDateTime(vItem.SubItems[1].Text),
                            HoraPelicula = vItem.SubItems[2].Text,
                            FechaEstreno = Convert.ToDateTime(vItem.SubItems[3].Text),
                            FechaFinalizacion = Convert.ToDateTime(vItem.SubItems[4].Text)
                        };
                        vDetalles.Add(vEstructuraDetalle);
                    }

                    switch (vModo)
                    {
                        case "A":
                            vEstructuraCartelera.IdCartelera = 0;
                            vNegocio.Insertar(vEstructuraCartelera, vDetalles);
                            break;
                        case "M":
                            vEstructuraCartelera.IdCartelera = Convert.ToInt32(lblId.Text);
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdCartelera", "=", Convert.ToInt32(lblId.Text)));
                            vNegocio.Actualizar(vEstructuraCartelera, vFiltros, vDetalles);
                            tbpLista.Parent = tbcInformacion;
                            tbcInformacion.SelectedTab = tbpLista;
                            tspBarraMenu.Visible = true;
                            tbpInformacion.Parent = null;
                            vModo = string.Empty;
                            CargarVista();
                            break;

                        default:
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdCartelera", "=", Convert.ToInt32(lblId.Text)));
                            vNegocio.Eliminar(vFiltros);
                            vNegocioDetalle.Eliminar(vFiltros);
                            tbpLista.Parent = tbcInformacion;
                            tbcInformacion.SelectedTab = tbpLista;
                            tspBarraMenu.Visible = true;
                            tbpInformacion.Parent = null;
                            vModo = string.Empty;
                            CargarVista();
                            gboDescripcion.Enabled = true;
                            break;
                    }

                    MessageBox.Show("El proceso a finalizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVista();
                    ltvDetalle.Items.Clear();
                    lblId.Text = string.Empty;
                    cboPelicula.SelectedIndex = 1;
                    cboSala.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Al menos debe agregar un detalle, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

              
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

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem vItem = new ListViewItem();
                vItem = ltvInformacion.Items.Add(cboPelicula.SelectedValue.ToString());
                vItem.SubItems.Add(string.Format("{0:yyyy/MM/dd}", dtpFecha.Value));
                vItem.SubItems.Add(string.Format("{0:HH:mm}", dtpHoraPelicula.Value));
                vItem.SubItems.Add(string.Format("{0:yyyy/MM/dd}", dtpFechaFinalizacion.Value));
                vItem.SubItems.Add(string.Format("{0:yyyy/MM/dd}", dtpFechaFinalizacion.Value));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            List<int> vItems = new List<int>();
            try
            {
                foreach (ListViewItem vItem in ltvDetalle.CheckedItems)
                {
                    vItems.Add(vItem.Index);
                }
                vItems.Sort();
                for (int i = vItems.Count - 1; i >= 0; i--)
                {
                    ltvDetalle.Items.RemoveAt(vItems[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion
    }
}
