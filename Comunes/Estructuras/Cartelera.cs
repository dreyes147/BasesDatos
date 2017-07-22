using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Cartelera
    {

        #region Declaracion de atributos

        private int vIdCartelera;
        private int vIdSala;
        private int vIdTipoSala;

        #endregion
        #region Declaracion de Constructor

        public Cartelera()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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


        #endregion



    }
}
