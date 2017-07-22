using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class EstadoReservacion
    {

        #region Declaracion de atributos

        private int vIdEstadoReservacion;
        private string vDescripcionEstadoReservacion;

        #endregion
        #region Declaracion de Constructor

        public EstadoReservacion()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdEstadoReservacion
        {
            get
            {
                return vIdEstadoReservacion;
            }
            set
            {
                vIdEstadoReservacion = value;
            }
        }

        public string DescripcionEstadoReservacion
        {
            get
            {
                return vDescripcionEstadoReservacion;
            }
            set
            {
                vDescripcionEstadoReservacion = value;
            }
        }


        #endregion



    }
}
