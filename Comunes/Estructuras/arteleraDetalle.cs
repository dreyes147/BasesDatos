using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class CarteleraDetalle
    {

        #region Declaracion de atributos

        private int vIdCartelera;
        private int vIdPelicula;
        private int vIdDetallle;
        private DateTime vFechaPelicula;
        private string vHoraPelicula;
        private DateTime vFechaEstreno;
        private DateTime vFechaFinalizacion;

        #endregion
        #region Declaracion de Constructor

        public CarteleraDetalle()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdCartelera
        {
            get
            {
                return vIdCartelera;
            }
            set
            {
                vIdCartelera = value;
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

        public int IdDetallle
        {
            get
            {
                return vIdDetallle;
            }
            set
            {
                vIdDetallle = value;
            }
        }

        public DateTime FechaPelicula
        {
            get
            {
                return vFechaPelicula;
            }
            set
            {
                vFechaPelicula = value;
            }
        }

        public string HoraPelicula
        {
            get
            {
                return vHoraPelicula;
            }
            set
            {
                vHoraPelicula = value;
            }
        }

        public DateTime FechaEstreno
        {
            get
            {
                return vFechaEstreno;
            }
            set
            {
                vFechaEstreno = value;
            }
        }

        public DateTime FechaFinalizacion
        {
            get
            {
                return vFechaFinalizacion;
            }
            set
            {
                vFechaFinalizacion = value;
            }
        }


        #endregion



    }
}
