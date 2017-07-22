using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoUsuario
    {

        #region Declaracion de atributos

        private int vIdTipoUsuario;
        private string vDescripcionTipoUsuario;

        #endregion
        #region Declaracion de Constructor

        public TipoUsuario()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoUsuario
        {
            get
            {
                return vIdTipoUsuario;
            }
            set
            {
                vIdTipoUsuario = value;
            }
        }

        public string DescripcionTipoUsuario
        {
            get
            {
                return vDescripcionTipoUsuario;
            }
            set
            {
                vDescripcionTipoUsuario = value;
            }
        }


        #endregion



    }
}
