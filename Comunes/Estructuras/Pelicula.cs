using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Pelicula
    {

        #region Declaracion de atributos

        private int vIdPelicula;
        private string vNombrePelicula;
        private string vTituloPelicula;
        private int vIdSubtitulo;
        private int vIdIdioma;

        #endregion
        #region Declaracion de Constructor

        public Pelicula()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdPelicula
        {
            get
            {
                return vIdPelicula;
            }
            set
            {
                vIdPelicula = value;
            }
        }

        public string NombrePelicula
        {
            get
            {
                return vNombrePelicula;
            }
            set
            {
                vNombrePelicula = value;
            }
        }

        public string TituloPelicula
        {
            get
            {
                return vTituloPelicula;
            }
            set
            {
                vTituloPelicula = value;
            }
        }

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


        #endregion



    }
}
