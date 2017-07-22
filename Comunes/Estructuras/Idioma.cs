using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Idioma
    {

        #region Declaracion de atributos

        private int vIdIdioma;
        private string vDescripcionIdioma;

        #endregion
        #region Declaracion de Constructor

        public Idioma()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdIdioma
        {
            get
            {
                return vIdIdioma;
            }
            set
            {
                vIdIdioma = value;
            }
        }

        public string DescripcionIdioma
        {
            get
            {
                return vDescripcionIdioma;
            }
            set
            {
                vDescripcionIdioma = value;
            }
        }

        #endregion
    }
}
