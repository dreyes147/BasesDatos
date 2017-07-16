using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;

namespace Datos.Clases
{
    class AreaTrabajo
    {
        #region Declaracion de Select
        public DataTable Selecccionar() {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
           
            try
            {
                vSQL += "Select IdArea,";
                vSQL += "DescripcionArea";
                vSQL += "From AREA_TRABAJO";
            }
            catch (Exception ex) {
                throw new Exception(ex.Message,ex) ;
            }
            return dtResultado;
        }
        #endregion
    }
}
