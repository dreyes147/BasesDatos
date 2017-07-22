using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using Datos.Clases;

namespace Negocio.Clases
{
    public class AreaTrabajo
    {
       Datos.Clases.AreaTrabajo vDatos = new Datos.Clases.AreaTrabajo();

        public AreaTrabajo()
        {

        }

        public DataTable Selecccionar(List<Filtro> pFiltros)
        {
            DataTable dtResultado = new DataTable("Datos");
            try
            {
                dtResultado = vDatos.Selecccionar(pFiltros);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        public void Insertar(Comunes.Estructuras.AreaTrabajo pDatos)
        {
            try
            {
                if (pDatos != null) {
                    vDatos.Insertar(pDatos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        public void Actualizar(Comunes.Estructuras.AreaTrabajo pDatos, List<Filtro> pFiltro)
        {
            try
            {
                if (pFiltro != null && pDatos!= null)
                {
                    vDatos.Actualizar(pDatos, pFiltro);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public void Actualizar(List<Filtro> pFiltros, List<Campos> pCampos)
        {
            try
            {   
                if(pFiltros!=null && pCampos != null)
                {
                    vDatos.Actualizar(pFiltros, pCampos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

    }
}
