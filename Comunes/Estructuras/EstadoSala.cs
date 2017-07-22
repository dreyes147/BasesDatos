using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class EstadoSala
    {

        #region Declaracion de atributos

        private int vIdEstadoSala;
        private string vDescripcionEstado;

        #endregion
        #region Declaracion de Constructor

        public EstadoSala()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public int IdEstadoSala
        {
            get
            {
                return vIdEstadoSala;
            }
            set
            {
                vIdEstadoSala = value;
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
