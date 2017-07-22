using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Cliente
    {

        #region Declaracion de atributos

        private int vIdPersona;
        private int vIdTipoPersona;
        private int vIdTipoCliente;

        #endregion
        #region Declaracion de Constructor

        public Cliente()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public int IdTipoCliente
        {
            get
            {
                return vIdTipoCliente;
            }
            set
            {
                vIdTipoCliente = value;
            }
        }


        #endregion



    }
}
