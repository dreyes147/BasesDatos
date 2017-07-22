using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoSala
    {

        #region Declaracion de atributos

        private int vIdTipoSala;
        private string vDescripcionTipoSala;

        #endregion
        #region Declaracion de Constructor

        public TipoSala()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public string DescripcionTipoSala
        {
            get
            {
                return vDescripcionTipoSala;
            }
            set
            {
                vDescripcionTipoSala = value;
            }
        }


        #endregion



    }
}
