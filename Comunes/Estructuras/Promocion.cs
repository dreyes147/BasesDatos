using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Promocion
    {

        #region Declaracion de atributos

        private int vIdPromocion;
        private int vIdPelicula;
        private int vIdTipoPromocion;
        private DateTime vFechaInicio;
        private DateTime vFechaFinal;

        #endregion
        #region Declaracion de Constructor

        public Promocion()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdPromocion
        {
            get
            {
                return vIdPromocion;
            }
            set
            {
                vIdPromocion = value;
            }
        }

        public int IdPelicula
        {
            get
            {
                return vIdPelicula;
            }
            set
            {
                vIdPelicula = value;
            }
        }

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

        public DateTime FechaInicio
        {
            get
            {
                return vFechaInicio;
            }
            set
            {
                vFechaInicio = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return vFechaFinal;
            }
            set
            {
                vFechaFinal = value;
            }
        }


        #endregion



    }
}
