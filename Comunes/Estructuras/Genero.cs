using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Genero
    {

        #region Declaracion de atributos

        private int vIdGenero;
        private string vDescripcionGenero;

        #endregion
        #region Declaracion de Constructor

        public Genero()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public string DescripcionGenero
        {
            get
            {
                return vDescripcionGenero;
            }
            set
            {
                vDescripcionGenero = value;
            }
        }


        #endregion



    }
}
