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
    public partial class mPeliculas : Form
    {
        public mPeliculas()
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
            Negocio.Clases.Pelicula vPrx = new Negocio.Clases.Pelicula();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPrx.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = ltvInformacion.Items.Add(vRow["IdPelicula"].ToString());
                    vItem.SubItems.Add(vRow["NombrePelicula"].ToString());
                    vItem.SubItems.Add(vRow["TituloPelicula"].ToString());
                    vItem.SubItems.Add(vRow["IdSubtitulo"].ToString());
                    vItem.SubItems.Add(vRow["IdIdioma"].ToString());
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
            Negocio.Clases.Subtitulo vSubtitulos = new Negocio.Clases.Subtitulo();
            Negocio.Clases.Idioma vIdiomas = new Negocio.Clases.Idioma();
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();
            try
            {
                cboIdioma.DataSource = vIdiomas.Selecccionar(vFiltro);
                cboIdioma.DisplayMember = "DescripcionIdioma";
                cboIdioma.ValueMember = "IdIdioma";

                cboSubtitulos.DataSource = vSubtitulos.Selecccionar(vFiltro);
                cboSubtitulos.DisplayMember = "DescripcionSubtitulo";
                cboSubtitulos.ValueMember = "IdSubtitulo";
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
                if (txtNombrePelicula.Text.Trim() == String.Empty) {
                    MessageBox.Show("El campo nombre película no puede contener un valor no valido, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    vResultado = true;
                }

                if (txtTituloPelicula.Text.Trim() == String.Empty)
                {
                    MessageBox.Show("El campo titulo película no puede contener un valor no valido, por favor verifique", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ListView.SelectedListViewItemCollection vSeleccionados = this.ltvInformacion.SelectedItems;
            DataTable dtDatos = new DataTable();
            try
            {
                foreach (ListViewItem vItem in vSeleccionados)
                {
                    lblId.Text = vItem.SubItems[0].Text;
                    txtNombrePelicula.Text = vItem.SubItems[1].Text;
                    txtTituloPelicula.Text = vItem.SubItems[2].Text;
                    cboSubtitulos.SelectedValue = vItem.SubItems[3].Text;
                    cboIdioma.SelectedValue = vItem.SubItems[4].Text;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos

        private void mPeliculas_Load(object sender, EventArgs e)
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
            Comunes.Estructuras.Pelicula vEstructuraPeliculas = new Comunes.Estructuras.Pelicula();
            Negocio.Clases.Pelicula vNegocio = new Negocio.Clases.Pelicula();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            try
            {
                if (Validar() == false)
                {

                    vEstructuraPeliculas = new Comunes.Estructuras.Pelicula()
                    {
                        IdIdioma = Convert.ToInt32(cboIdioma.SelectedValue.ToString()),
                        IdSubtitulo = Convert.ToInt32(cboSubtitulos.SelectedValue.ToString()),
                        NombrePelicula = txtNombrePelicula.Text,
                        TituloPelicula = txtTituloPelicula.Text
                    };

                    switch (vModo)
                    {
                        case "A":
                            vEstructuraPeliculas.IdPelicula = 0;
                            vNegocio.Insertar(vEstructuraPeliculas);
                            break;
                        case "M":
                            vEstructuraPeliculas.IdPelicula = Convert.ToInt32(lblId.Text);
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdPelicula", "=", Convert.ToInt32(lblId.Text)));
                            vNegocio.Actualizar(vEstructuraPeliculas, vFiltros);
                            tbpLista.Parent = tbcInformacion;
                            tbcInformacion.SelectedTab = tbpLista;
                            tspBarraMenu.Visible = true;
                            tbpInformacion.Parent = null;
                            vModo = string.Empty;
                            CargarVista();
                            break;

                        default:
                            vFiltros.Add(new Comunes.Filtros.Filtro("IdPelicula", "=", Convert.ToInt32(lblId.Text)));
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
                    lblId.Text = string.Empty;
                    cboSubtitulos.SelectedIndex = 0;
                    cboIdioma.SelectedIndex = 0;
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
    }

    #endregion


}
