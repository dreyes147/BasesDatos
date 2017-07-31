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
    public partial class ListaPersona : Form
    {
        public ListaPersona()
        {
            InitializeComponent();
        }

        #region Declaracion de Variables

        private ListViewItem vItem = new ListViewItem();

        #endregion

        #region Declaracion de Propiedades
                public ListViewItem Item
                {
                    get
                    {
                        return vItem;
                    }
                    set
                    {
                        vItem = value;
                    }
                }
        #endregion

        #region Declaracion de Metodos
        private void Inicializar()
        {
            try
            {
                LlenarLista();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        private void LlenarLista()
        {
            Negocio.Clases.PersonaExtranjera vPersonaExt = new Negocio.Clases.PersonaExtranjera();
            Negocio.Clases.PersonaNacional vPersonaNac = new Negocio.Clases.PersonaNacional();
            DataTable vResultados = new DataTable();
            List<Comunes.Filtros.Filtro> vFiltros = new List<Comunes.Filtros.Filtro>();
            ListViewItem vItem = new ListViewItem();
            try
            {
                vResultados = vPersonaNac.Selecccionar(vFiltros);
                ltvInformacion.Items.Clear();
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = new ListViewItem();
                    vItem = ltvInformacion.Items.Add(vRow["IdPersona"].ToString());
                    vItem.SubItems.Add(vRow["IdTipoPersona"].ToString());
                    vItem.SubItems.Add(vRow["Nombre"].ToString());
                    vItem.SubItems.Add(vRow["PrimerApellido"].ToString());
                    vItem.SubItems.Add(vRow["SegundoApellido"].ToString());
                    vItem.SubItems.Add(vRow["FechaNacimiento"].ToString());
                }

                vResultados = new DataTable();
                vResultados = vPersonaExt.Selecccionar(vFiltros);
                foreach (DataRow vRow in vResultados.Rows)
                {
                    vItem = new ListViewItem();
                    vItem = ltvInformacion.Items.Add(vRow["IdPersona"].ToString());
                    vItem.SubItems.Add(vRow["IdTipoPersona"].ToString());
                    vItem.SubItems.Add(vRow["Nombre"].ToString());
                    vItem.SubItems.Add(vRow["PrimerApellido"].ToString());
                    vItem.SubItems.Add(vRow["SegundoApellido"].ToString());
                    vItem.SubItems.Add(vRow["FechaNacimiento"].ToString());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos
        private void ListaPersona_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        private void ltvInformacion_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ltvInformacion.SelectedItems.Count != 0)
                {
                    vItem = ltvInformacion.SelectedItems[0];
                    this.Close();
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
