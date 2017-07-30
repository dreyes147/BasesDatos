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
                ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;

                try
                {
                    if (ltvInformacion.SelectedIndices.Count > 0)
                    {
                        foreach (ListViewItem vItem in vSeleccionados)
                        {
                            lblId.Text = vItem.SubItems[0].Text;
                            cboTipoSala.SelectedValue = vItem.SubItems[2].Text;
                            cboTipoSala.SelectedValue = vItem.SubItems[3].Text;
                            cboTipoProyeccion.SelectedValue = vItem.SubItems[4].Text;
                            txtPrecioEntrada.Text = vItem.SubItems[5].Text;
                            cboTipoSala.SelectedValue = vItem.SubItems[2].Text;
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
            ListViewItem vItem = new ListViewItem();
            try
            {
                vItem.ImageIndex = 0;
                ltvAsientos.Items.Add(vItem);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ltvAsientos_DoubleClick(object sender, EventArgs e)
        {

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


        #endregion


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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
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
            Comunes.Estructuras.TipoUsuario vEstructura = new Comunes.Estructuras.TipoUsuario();
            Negocio.Clases.TipoUsuario vNegocio = new Negocio.Clases.TipoUsuario();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            try
            {
                //if (txtDescripcion.Text.Trim() != string.Empty)
                //{

                //    vEstructura.DescripcionTipoUsuario = txtDescripcion.Text;
                //    switch (vModo)
                //    {
                //        case "A":
                //            vEstructura.IdTipoUsuario = 0;
                //            vNegocio.Insertar(vEstructura);
                //            break;
                //        case "M":
                //            vEstructura.IdTipoUsuario = Convert.ToInt32(lblId.Text);
                //            vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoUsuario", "=", Convert.ToInt32(lblId.Text)));
                //            vNegocio.Actualizar(vEstructura, vFiltros);
                //            tbpLista.Parent = tbcInformacion;
                //            tbcInformacion.SelectedTab = tbpLista;
                //            tspBarraMenu.Visible = true;
                //            tbpInformacion.Parent = null;
                //            vModo = string.Empty;
                //            CargarVista();
                //            break;

                //        default:
                //            vFiltros.Add(new Comunes.Filtros.Filtro("IdTipoUsuario", "=", Convert.ToInt32(lblId.Text)));
                //            vNegocio.Eliminar(vFiltros);
                //            tbpLista.Parent = tbcInformacion;
                //            tbcInformacion.SelectedTab = tbpLista;
                //            tspBarraMenu.Visible = true;
                //            tbpInformacion.Parent = null;
                //            vModo = string.Empty;
                //            CargarVista();
                //            //txtDescripcion.Enabled = true;
                //            break;
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("El campo descripción no puede contener un valor no valido, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}

                //MessageBox.Show("El proceso a finalizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //CargarVista();
                ////txtDescripcion.Text = string.Empty;
                //lblId.Text = string.Empty;
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
                tbpInformacion.Parent =  tbcInformacion;
                tbcInformacion.SelectedTab = tbpInformacion;
                tbpAsientos.Parent = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
