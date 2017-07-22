using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
     public class TipoPersona
    {

        #region Declaracion de atributos

        private int vIdTipoPersona;
        private string vDescripcionTipoAsiento;

        #endregion
        #region Declaracion de Constructor

        public TipoPersona()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoPersona
        {
            get
            {
                return vIdTipoPersona;
            }
            set
            {
                vIdTipoPersona = value;
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
