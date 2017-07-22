using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoCliente
    {

        #region Declaracion de atributos

        private int vIdTipoCliente;
        private string vDescripcionTipoCliente;

        #endregion
        #region Declaracion de Constructor

        public TipoCliente()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoCliente
        {
            get
            {
                return vIdTipoCliente;
            }
            set
            {
                vIdTipoCliente = value;
            }
        }

        public string DescripcionTipoCliente
        {
            get
            {
                return vDescripcionTipoCliente;
            }
            set
            {
                vDescripcionTipoCliente = value;
            }
        }


        #endregion



    }
}
