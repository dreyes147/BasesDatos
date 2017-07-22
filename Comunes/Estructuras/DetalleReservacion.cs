using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class DetalleReservacion
    {

        #region Declaracion de atributos

        private int vIdReservacion;
        private int vIdPersona;
        private int vIdTipoPersona;
        private int vIdDetalle;
        private int vIdCartelera;
        private int vIdDetallle;
        private int vIdNumeroAsiento;
        private int vIdSala;
        private int vIdTipoSala;
        private int vIdPromocion;

        #endregion
        #region Declaracion de Constructor

        public DetalleReservacion()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdReservacion
        {
            get
            {
                return vIdReservacion;
            }
            set
            {
                vIdReservacion = value;
            }
        }

        public int IdPersona
        {
            get
            {
                return vIdPersona;
            }
            set
            {
                vIdPersona = value;
            }
        }

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

        public int IdDetalle
        {
            get
            {
                return vIdDetalle;
            }
            set
            {
                vIdDetalle = value;
            }
        }

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

        public int IdNumeroAsiento
        {
            get
            {
                return vIdNumeroAsiento;
            }
            set
            {
                vIdNumeroAsiento = value;
            }
        }

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


        #endregion



    }
}
