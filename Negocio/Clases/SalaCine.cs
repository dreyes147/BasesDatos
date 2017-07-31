using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data;

namespace Negocio.Clases
{
    public class SalaCine
    {
        #region Declaracion de Constructor
        Datos.Clases.SalaCine vDatos = new Datos.Clases.SalaCine();
        #endregion

        #region Declaracion de Constructor
        public SalaCine()
        {
        }
        #endregion

        #region Delcaracion de Metodo Seleccionar
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
        #endregion

        #region Declaracion de Metodo Insertar
        public void Insertar(Comunes.Estructuras.SalaCine pDatos)
        {
            try
            {
                if (pDatos != null)
                {
                    vDatos.Insertar(pDatos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Insertar(Comunes.Estructuras.SalaCine pSala, List<Comunes.Estructuras.AsientoSalaCine> pAsientos)
        {
            Datos.Clases.AsientoSalaCine vDatosAsientos = new Datos.Clases.AsientoSalaCine();
            int vReusltado = 0;
            try
            {
                if (pSala != null && pAsientos != null)
                {
                    vDatos.Insertar(pSala);
                    vReusltado = vDatos.SelecccionarId();
                    foreach (Comunes.Estructuras.AsientoSalaCine vItem in pAsientos) {
                        vItem.IdSala = vReusltado;
                        vDatosAsientos.Insertar(vItem);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Metodo Eliminar
        public void Eliminar(List<Filtro> pFiltros)
        {
            try
            {
                if (pFiltros != null)
                {
                    vDatos.Eliminar(pFiltros);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Metodo Actualizar
        public void Actualizar(Comunes.Estructuras.SalaCine pDatos, List<Filtro> pFiltro)
        {
            try
            {
                if (pFiltro != null && pDatos != null)
                {
                    vDatos.Actualizar(pDatos, pFiltro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        public void Actualizar(Comunes.Estructuras.SalaCine pSala, List<Filtro> pFiltro, List<Comunes.Estructuras.AsientoSalaCine> pAsientos)
        {
            Datos.Clases.AsientoSalaCine vDatosAsientos = new Datos.Clases.AsientoSalaCine();
            try
            {
                if (pSala != null && pAsientos != null)
                {
                    vDatos.Actualizar(pSala, pFiltro);
                    vDatosAsientos.Eliminar(pFiltro);
                    foreach (Comunes.Estructuras.AsientoSalaCine vItem in pAsientos)
                    {
                        vItem.IdSala = pSala.IdSala;
                        vDatosAsientos.Insertar(vItem);
                    }
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
                if (pFiltros != null && pCampos != null)
                {
                    vDatos.Actualizar(pFiltros, pCampos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

    }
}
