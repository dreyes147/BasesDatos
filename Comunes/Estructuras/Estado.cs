using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class Estado
    {

        #region Declaracion de atributos

        private int vIdEstado;
        private string vDescripcionEstado;

        #endregion
        #region Declaracion de Constructor

        public Estado()
        {
        }
        #endregion

        #region Declaracion de Propiedades

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

        public string DescripcionEstado
        {
            get
            {
                return vDescripcionEstado;
            }
            set
            {
                vDescripcionEstado = value;
            }
        }


        #endregion



    }
}
