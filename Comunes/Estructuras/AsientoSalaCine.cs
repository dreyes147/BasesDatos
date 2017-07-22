using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class AsientoSalaCine
    {

        #region Declaracion de atributos

        private int vIdNumeroAsiento;
        private int vIdSala;
        private int vIdTipoSala;
        private int vIdTipoAsiento;
        private int vIdEstadoAsiento;

        #endregion
        #region Declaracion de Constructor

        public AsientoSalaCine()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public int IdTipoAsiento
        {
            get
            {
                return vIdTipoAsiento;
            }
            set
            {
                vIdTipoAsiento = value;
            }
        }

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

        #endregion

    }
}
