using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoAsiento
    {

        #region Declaracion de atributos

        private int vIdTipoAsiento;
        private string vDescripcionTipoAsiento;

        #endregion
        #region Declaracion de Constructor

        public TipoAsiento()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoAsiento
        {
            get
            {
                return vIdTipoAsiento;
            }
            set
            {
                vIdTipoAsiento = value;
            }
        }

        public string DescripcionTipoAsiento
        {
            get
            {
                return vDescripcionTipoAsiento;
            }
            set
            {
                vDescripcionTipoAsiento = value;
            }
        }


        #endregion



    }
}
