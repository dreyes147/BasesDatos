using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Declaración de Variables

        #endregion

        #region Declaracion de Métodos

        #endregion

        #region Declaración de Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
            {
                Close();
            }

        private void Login_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion


    }
}
