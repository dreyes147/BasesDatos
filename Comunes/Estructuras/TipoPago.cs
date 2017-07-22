using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoPago
    {

        #region Declaracion de atributos

        private int vIdTipoPago;
        private string vDescripcionTipoPago;

        #endregion
        #region Declaracion de Constructor

        public TipoPago()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoPago
        {
            get
            {
                return vIdTipoPago;
            }
            set
            {
                vIdTipoPago = value;
            }
        }

        public string DescripcionTipoPago
        {
            get
            {
                return vDescripcionTipoPago;
            }
            set
            {
                vDescripcionTipoPago = value;
            }
        }


        #endregion



    }
}
