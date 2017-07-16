using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data.SqlClient;

namespace Datos.Clases
{
    class AreaTrabajo
    {
        #region Declaracion de Select
        public DataTable Selecccionar(List<Filtro> pFiltros) {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "Select IdArea,";
                vSQL += "DescripcionArea";
                vSQL += "From AREA_TRABAJO";
                if (pFiltros != null && pFiltros.Count != 0) {
                    vSQL += vFiltros.CrearWhere(pFiltros);
                }
                vConnexion.Seleccionar(vSQL, "BASEDATOS");
            }
            catch (Exception ex) {
                throw new Exception(ex.Message,ex) ;
            }
            return dtResultado;
        }
        #endregion
    }
}
