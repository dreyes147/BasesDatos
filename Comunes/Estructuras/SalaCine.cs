using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class SalaCine
    {

        #region Declaracion de atributos

        private int vIdSala;
        private int vCantidadAsientos;
        private int vIdEstadoSala;
        private int vIdTipoSala;
        private int vIdTipoProyeccion;
        private decimal vPrecioEntrada;

        #endregion
        #region Declaracion de Constructor

        public SalaCine()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdSala
        {
            get
            {
                return vIdSala;
            }
            set
            {
                vIdSala = value;
            }
        }

        public int CantidadAsientos
        {
            get
            {
                return vCantidadAsientos;
            }
            set
            {
                vCantidadAsientos = value;
            }
        }

        public int IdEstadoSala
        {
            get
            {
                return vIdEstadoSala;
            }
            set
            {
                vIdEstadoSala = value;
            }
        }

        public int IdTipoSala
        {
            get
            {
                return vIdTipoSala;
            }
            set
            {
                vIdTipoSala = value;
            }
        }

        public int IdTipoProyeccion
        {
            get
            {
                return vIdTipoProyeccion;
            }
            set
            {
                vIdTipoProyeccion = value;
            }
        }

        public decimal PrecioEntrada
        {
            get
            {
                return vPrecioEntrada;
            }
            set
            {
                vPrecioEntrada = value;
            }
        }


        #endregion



    }
}
