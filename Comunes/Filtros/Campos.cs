using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Filtros
{
    public class Campos
    {
        private string vCampos;
        private string vValor;
        private string vTipoDato;

        public Campos() {
            vCampos = string.Empty;
            vValor = string.Empty;
            vTipoDato = string.Empty;
        }


        public string Campo
        {
            get
            {
                return vCampos;
            }
            set
            {
                vCampos = value;
            }
        }

        public string Valor
        {
            get
            {
                return vValor;
            }
            set
            {
                vValor = value;
            }
        }

        public string TipoDato
        {
            get
            {
                return vTipoDato;
            }
            set
            {
                vTipoDato = value;
            }
        }

    }
}
