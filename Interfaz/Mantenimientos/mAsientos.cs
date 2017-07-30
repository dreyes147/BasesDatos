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
    public partial class mAsientos : Form
    {
        public mAsientos()
        {
            InitializeComponent();
        }

        #region Declaracion de Variables
        private Comunes.Estructuras.AsientoSalaCine vEstructura = new Comunes.Estructuras.AsientoSalaCine();
        #endregion

        #region Declaracion de Propiedades
        public Comunes.Estructuras.AsientoSalaCine Estructura
        {
            get
            {
                return vEstructura;
            }
            set
            {
                vEstructura = value;
            }
        }
        #endregion

        #region Declaracion de Metodos
        private void CaragrCombos()
        {
            Negocio.Clases.TipoAsiento vProxyTipoAsiento = new Negocio.Clases.TipoAsiento();
            Negocio.Clases.EstadoAsiento vProxyEstadoAsiento = new Negocio.Clases.EstadoAsiento();
            
            List<Comunes.Filtros.Filtro> vFiltro = new List<Comunes.Filtros.Filtro>();
            try
            {
                cboEstadoAsiento.DataSource = vProxyEstadoAsiento.Selecccionar(vFiltro);
                cboEstadoAsiento.DisplayMember = "DescripcionEstadoAsiento";
                cboEstadoAsiento.ValueMember = "IdEstadoAsiento";

                cboTipoAsiento.DataSource = vProxyTipoAsiento.Selecccionar(vFiltro);
                cboTipoAsiento.DisplayMember = "DescripcionTipoAsiento";
                cboTipoAsiento.ValueMember = "IdTipoAsiento";
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        #endregion

        #region Declaracion de Eventos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                vEstructura.IdEstadoAsiento = Convert.ToInt32(cboEstadoAsiento.SelectedValue.ToString());
                vEstructura.IdTipoAsiento = Convert.ToInt32(cboTipoAsiento.SelectedValue.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            try { 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mAsientos_Load(object sender, EventArgs e)
        {
            try
            {
                CaragrCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        #endregion


    }
}
