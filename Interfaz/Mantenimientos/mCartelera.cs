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
               // tbpInformacion.Parent = null;
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
        #endregion
    }
}
