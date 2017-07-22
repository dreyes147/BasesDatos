using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Reservacion
    {

        #region Declaracion de atributos

        private int vIdReservacion;
        private int vIdPersona;
        private int vIdTipoPersona;
        private decimal vSaldo;
        private int vIdTipoPago;
        private int vIdEstadoReservacion;
        private DateTime vFechaReservacion;
        private decimal vTotal;

        #endregion
        #region Declaracion de Constructor

        public Reservacion()
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

        public decimal Saldo
        {
            get
            {
                return vSaldo;
            }
            set
            {
                vSaldo = value;
            }
        }

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

        public DateTime FechaReservacion
        {
            get
            {
                return vFechaReservacion;
            }
            set
            {
                vFechaReservacion = value;
            }
        }

        public decimal Total
        {
            get
            {
                return vTotal;
            }
            set
            {
                vTotal = value;
            }
        }


        #endregion



    }
}
