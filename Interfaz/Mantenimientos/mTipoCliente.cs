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
    public partial class mTipoCliente : Form
    {
        public mTipoCliente()
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
            Negocio.Clases.TipoCliente vPrx = new Negocio.Clases.TipoCliente();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPrx.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = ltvInformacion.Items.Add(vRow["IdTipoCliente"].ToString());
                    vItem.SubItems.Add(vRow["DescripcionTipoCliente"].ToString());
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

        #endregion


        private void mTipoCliente_Load(object sender, EventArgs e)
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
                    foreach (ListViewItem vItem in vSeleccionados)
                    {
                        lblId.Text = vItem.SubItems[0].Text;
                        txtDescripcion.Text = vItem.SubItems[1].Text;
                    }
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

                    foreach (ListViewItem vItem in vSeleccionados)
                    {
                        lblId.Text = vItem.SubItems[0].Text;
                        txtDescripcion.Text = vItem.SubItems[1].Text;
                    }
                    lblId.Visible = true;
                    lblIdentificador.Visible = true;
                    txtDescripcion.Enabled = false;
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
            Comunes.Estructuras.TipoCliente vEstructura = new Comunes.Estructuras.TipoCliente();
            Negocio.Clases.TipoCliente vNegocio = new Negocio.Clases.TipoCliente();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            try
            {
                if (txtDescripcion.Text.Trim() != string.Empty)
                {

                    vEstructura.DescripcionTipoCliente = txtDescripcion.Text;
                    switch (vModo)
                    {
                        case "A":
                            vEstructura.IdTipoCliente = 0;
                            vNegocio.Insertar(vEstructura);
                            break;
                        case "M":
                            vEstructura.IdTipoCliente = Convert.ToInt32(lblId.Text);
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoCliente", "=", Convert.ToInt32(lblId.Text)));
                            vNegocio.Actualizar(vEstructura, vFiltros);
                            tbpLista.Parent = tbcInformacion;
                            tbcInformacion.SelectedTab = tbpLista;
                            tspBarraMenu.Visible = true;
                            tbpInformacion.Parent = null;
                            vModo = string.Empty;
                            CargarVista();
                            break;

                        default:
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoCliente", "=", Convert.ToInt32(lblId.Text)));
                            vNegocio.Eliminar(vFiltros);
                            tbpLista.Parent = tbcInformacion;
                            tbcInformacion.SelectedTab = tbpLista;
                            tspBarraMenu.Visible = true;
                            tbpInformacion.Parent = null;
                            vModo = string.Empty;
                            CargarVista();
                            txtDescripcion.Enabled = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("El campo descripción no puede contener un valor no valido, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                MessageBox.Show("El proceso a finalizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarVista();
                txtDescripcion.Text = string.Empty;
                lblId.Text = string.Empty;
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
    }
}
