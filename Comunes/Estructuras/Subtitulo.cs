using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Subtitulo
    {

        #region Declaracion de atributos

        private int vIdSubtitulo;
        private string vDescripcionSubtitulo;

        #endregion
        #region Declaracion de Constructor

        public Subtitulo()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdSubtitulo
        {
            get
            {
                return vIdSubtitulo;
            }
            set
            {
                vIdSubtitulo = value;
            }
        }

        public string DescripcionSubtitulo
        {
            get
            {
                return vDescripcionSubtitulo;
            }
            set
            {
                vDescripcionSubtitulo = value;
            }
        }


        #endregion



    }
}
