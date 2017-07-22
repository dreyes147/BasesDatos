using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class TipoProyeccion
    {

        #region Declaracion de atributos

        private int vIdTipoProyeccion;
        private string vDescripcionTipoProyeccion;

        #endregion
        #region Declaracion de Constructor

        public TipoProyeccion()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdTipoProyeccion
        {
            get
            {
                return vIdTipoProyeccion;
            }
            set
            {
                vIdTipoProyeccion = value;
            }
        }

        public string DescripcionTipoProyeccion
        {
            get
            {
                return vDescripcionTipoProyeccion;
            }
            set
            {
                vDescripcionTipoProyeccion = value;
            }
        }


        #endregion



    }
}
