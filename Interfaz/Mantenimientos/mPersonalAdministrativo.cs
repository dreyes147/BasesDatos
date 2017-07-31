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
    public partial class mPersonalAdministrativo : Form
    {
        public mPersonalAdministrativo()
        {
            InitializeComponent();
        }

        #region Declaracion de Variables

        private string vModo = string.Empty;
        private int vTipoPersona;

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
            Negocio.Clases.PersonalAdministrativo vPrx = new Negocio.Clases.PersonalAdministrativo();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPrx.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = ltvInformacion.Items.Add(vRow["IdPersona"].ToString());
                    vItem.SubItems.Add(vRow["IdTipoPersona"].ToString());
                    vItem.SubItems.Add(vRow["IdArea"].ToString());
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

        private void CargarCombos()
        {
            Negocio.Clases.AreaTrabajo vArea = new Negocio.Clases.AreaTrabajo();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();
            try
            {
                cboArea.DataSource = vArea.Selecccionar(vFiltro);
                cboArea.DisplayMember = "DescripcionArea";
                cboArea.ValueMember = "IdArea";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private Boolean Validar()
        {
            Boolean vResultado = false;
            try
            {
                if (txtIdPersona.Text == String.Empty)
                {
                    MessageBox.Show("Favor seleccione una Persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = true;
                }
            }
            catch (Exception ex)
            {
                vResultado = true;
                throw new Exception(ex.Message, ex);
            }
            return vResultado;
        }

        private void Leer()
        {
            Negocio.Clases.PersonaExtranjera vPersonaExt = new Negocio.Clases.PersonaExtranjera();
            Negocio.Clases.PersonaNacional vPersonaNac = new Negocio.Clases.PersonaNacional();
            ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
            DataTable vResultados = new DataTable();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            try
            {
                foreach (ListViewItem vItem in vSeleccionados)
                {
                    txtIdPersona.Text = vItem.SubItems[0].Text;
                    vTipoPersona = Convert.ToInt32(vItem.SubItems[1].Text);
                    cboArea.SelectedValue = vItem.SubItems[3].Text;
                }


                vFiltros.Add(new Comunes.Filtros.Filtro("IdPersona", "=", Convert.ToInt32(txtIdPersona.Text)));
                vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoPersona", "=", Convert.ToInt32(vTipoPersona)));

                vResultados = vPersonaNac.Selecccionar(vFiltros);
                if (vResultados.Rows.Count != 0)
                {
                    txtNombre.Text = vResultados.Rows[0]["Nombre"].ToString() + " " + vResultados.Rows[0]["PrimerApellido"].ToString() + " " + vResultados.Rows[0]["SegundoApellido"].ToString();
                }
                else
                {
                    vResultados = new DataTable();
                    vResultados = vPersonaExt.Selecccionar(vFiltros);
                    txtNombre.Text = vResultados.Rows[0]["Nombre"].ToString() + " " + vResultados.Rows[0]["PrimerApellido"].ToString() + " " + vResultados.Rows[0]["SegundoApellido"].ToString();
                }   
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos

        private void mPersonalAdministrativo_Load(object sender, EventArgs e)
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
            Comunes.Estructuras.PersonalAdministrativo vEstructura = new Comunes.Estructuras.PersonalAdministrativo();
            Negocio.Clases.PersonalAdministrativo vNegocio = new Negocio.Clases.PersonalAdministrativo();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            try
            {
                if (Validar() == false)
                {

                    vEstructura = new Comunes.Estructuras.PersonalAdministrativo()
                    {
                        IdPersona = Convert.ToInt32(txtIdPersona.Text),
                        IdArea = Convert.ToInt32(cboArea.SelectedValue.ToString()),
                        IdTipoPersona = vTipoPersona
                    };

                    switch (vModo)
                    {
                        case "A":
                            vNegocio.Insertar(vEstructura);
                            break;
                        case "M":
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdPersona", "=", Convert.ToInt32(txtIdPersona.Text)));
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoPersona", "=", Convert.ToInt32(vTipoPersona)));
                            vNegocio.Actualizar(vEstructura, vFiltros);
                            tbpLista.Parent = tbcInformacion;
                            tbcInformacion.SelectedTab = tbpLista;
                            tspBarraMenu.Visible = true;
                            tbpInformacion.Parent = null;
                            vModo = string.Empty;
                            CargarVista();
                            break;

                        default:
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdPersona", "=", Convert.ToInt32(txtIdPersona.Text)));
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoPersona", "=", Convert.ToInt32(vTipoPersona)));
                            vNegocio.Eliminar(vFiltros);
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
                    txtNombre.Text = string.Empty;
                    txtIdPersona.Text = string.Empty;
                    cboArea.SelectedIndex = 0;
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

        private void lnkPersona_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Interfaz.Mantenimientos.ListaPersona vLista = new Interfaz.Mantenimientos.ListaPersona();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vLista.StartPosition = FormStartPosition.CenterScreen;
                vLista.ShowDialog();
                vItem = vLista.Item;

                txtIdPersona.Text = vItem.SubItems[0].Text;
                txtNombre.Text = vItem.SubItems[2].Text +" " + vItem.SubItems[3].Text +" "+ vItem.SubItems[4].Text;
                vTipoPersona = Convert.ToInt32(vItem.SubItems[1].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        #endregion
    }
}
