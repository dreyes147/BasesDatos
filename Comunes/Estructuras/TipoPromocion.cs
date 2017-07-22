using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoPromocion
    {

        #region Declaracion de atributos

        private int vIdTipoPromocion;
        private string vValorPromocion;
        private string vDescripcionTipoPromocion;

        #endregion
        #region Declaracion de Constructor

        public TipoPromocion()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoPromocion
        {
            get
            {
                return vIdTipoPromocion;
            }
            set
            {
                vIdTipoPromocion = value;
            }
        }

        public string ValorPromocion
        {
            get
            {
                return vValorPromocion;
            }
            set
            {
                vValorPromocion = value;
            }
        }

        public string DescripcionTipoPromocion
        {
            get
            {
                return vDescripcionTipoPromocion;
            }
            set
            {
                vDescripcionTipoPromocion = value;
            }
        }


        #endregion



    }
}
