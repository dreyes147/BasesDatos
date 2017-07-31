using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AreaTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mAreaTrabajo vObj = new Interfaz.Mantenimientos.mAreaTrabajo();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void asientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoAsiento vObj = new Interfaz.Mantenimientos.mTipoAsiento();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoCliente vObj = new Interfaz.Mantenimientos.mTipoCliente();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoPago vObj = new Interfaz.Mantenimientos.mTipoPago();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoPersona vObj = new Interfaz.Mantenimientos.mTipoPersona();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void promocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoPromocion vObj = new Interfaz.Mantenimientos.mTipoPromocion();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void proyeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoProyeccion vObj = new Interfaz.Mantenimientos.mTipoProyeccion();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void salaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoSala vObj = new Interfaz.Mantenimientos.mTipoSala();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mTipoUsuario vObj = new Interfaz.Mantenimientos.mTipoUsuario();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void asientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mEstadoAsiento vObj = new Interfaz.Mantenimientos.mEstadoAsiento();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mEstadoPersona vObj = new Interfaz.Mantenimientos.mEstadoPersona();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void reservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mEstadoReservacion vObj = new Interfaz.Mantenimientos.mEstadoReservacion();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mEstadoSala vObj = new Interfaz.Mantenimientos.mEstadoSala();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mGenero vObj = new Interfaz.Mantenimientos.mGenero();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mIdioma vObj = new Interfaz.Mantenimientos.mIdioma();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void subtituloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mSubtitulo vObj = new Interfaz.Mantenimientos.mSubtitulo();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mPeliculas vObj = new Interfaz.Mantenimientos.mPeliculas();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void salaCineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mSalaCine vObj = new Interfaz.Mantenimientos.mSalaCine();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void carteleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mCartelera vObj = new Interfaz.Mantenimientos.mCartelera();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void promocionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Interfaz.Mantenimientos.mPromocion vObj = new Interfaz.Mantenimientos.mPromocion();
            try
            {
                vObj.StartPosition = FormStartPosition.CenterParent;
                vObj.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
