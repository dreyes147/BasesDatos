using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class UsuarioSistema
    {


        #region Declaracion de atributos

        private int vIdPersona;
        private int vIdTipoPersona;
        private int vIdTipoUsuario;
        private string vContrasena;

        #endregion
        #region Declaracion de Constructor

        public UsuarioSistema()
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

        public int IdTipoUsuario
        {
            get
            {
                return vIdTipoUsuario;
            }
            set
            {
                vIdTipoUsuario = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return vContrasena;
            }
            set
            {
                vContrasena = value;
            }
        }


        #endregion



    }
}
