using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class AreaTrabajo
    {
        private int vIdArea;
        private string vDescripcionArea;

        public AreaTrabajo() {
            vIdArea = 0;
            vDescripcionArea = string.Empty;
        }

        public int IdAreaTrabajo 
        {
            get
            {
                return vIdArea;
            }
            set
            {
                vIdArea = value;
            }
        }

        public string DescripcionArea
        {
            get
            {
                return vDescripcionArea;
            }
            set
            {
                vDescripcionArea = value;
            }
        }
    }
}
