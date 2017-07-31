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
    public partial class mCliente : Form
    {
        public mCliente()
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
            Negocio.Clases.Promocion vPrx = new Negocio.Clases.Promocion();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPrx.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = ltvInformacion.Items.Add(vRow["IdPromocion"].ToString());
                    vItem.SubItems.Add(vRow["IdPelicula"].ToString());
                    vItem.SubItems.Add(vRow["IdTipoPromocion"].ToString());
                    vItem.SubItems.Add(String.Format("{0:yyyy/MM/dd}", vRow["FechaInicio"]));
                    vItem.SubItems.Add(String.Format("{0:yyyy/MM/dd}", vRow["FechaFinal"]));
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
            Negocio.Clases.Pelicula vSubtitulos = new Negocio.Clases.Pelicula();
            Negocio.Clases.TipoPromocion vIdiomas = new Negocio.Clases.TipoPromocion();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();
            try
            {
                //cboPelicula.DataSource = vIdiomas.Selecccionar(vFiltro);
                //cboPelicula.DisplayMember = "NombrePelicula";
                //cboPelicula.ValueMember = "IdPelicula";

                //cboTipoPromocion.DataSource = vSubtitulos.Selecccionar(vFiltro);
                //cboTipoPromocion.DisplayMember = "DescripcionTipoPromocion";
                //cboTipoPromocion.ValueMember = "IdTipoPromocion";
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
                //if (dtpFechaFinal.Value < dtpFechaInicio.Value)
                //{
                //    MessageBox.Show("La fecha final no puede ser menor a la fecha inicial, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    vResultado = true;
                //}
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
            ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
            DataTable dtDatos = new DataTable();
            try
            {
                foreach (ListViewItem vItem in vSeleccionados)
                {
                    //lblId.Text = vItem.SubItems[0].Text;
                    //cboPelicula.SelectedValue = vItem.SubItems[1].Text;
                    //cboTipoPromocion.SelectedValue = vItem.SubItems[2].Text;
                    //dtpFechaInicio.Value = Convert.ToDateTime(vItem.SubItems[3].Text);
                    //dtpFechaFinal.Value = Convert.ToDateTime(vItem.SubItems[4].Text);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion
    }
}
