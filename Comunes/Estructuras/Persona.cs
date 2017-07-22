using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Persona
    {

        #region Declaracion de atributos

        private int vIdPersona;
        private int vIdGenero;
        private int vIdTipoPersona;
        private int vIdEstado;

        #endregion
        #region Declaracion de Constructor

        public Persona()
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

        public int IdGenero
        {
            get
            {
                return vIdGenero;
            }
            set
            {
                vIdGenero = value;
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

        public int IdEstado
        {
            get
            {
                return vIdEstado;
            }
            set
            {
                vIdEstado = value;
            }
        }

        #endregion
    }
}
