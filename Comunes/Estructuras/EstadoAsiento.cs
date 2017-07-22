using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class EstadoAsiento
    {

        #region Declaracion de atributos

        private int vIdEstadoAsiento;
        private string vDescripcionEstadoAsiento;

        #endregion
        #region Declaracion de Constructor

        public EstadoAsiento()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdEstadoAsiento
        {
            get
            {
                return vIdEstadoAsiento;
            }
            set
            {
                vIdEstadoAsiento = value;
            }
        }

        public string DescripcionEstadoAsiento
        {
            get
            {
                return vDescripcionEstadoAsiento;
            }
            set
            {
                vDescripcionEstadoAsiento = value;
            }
        }


        #endregion



    }
}
