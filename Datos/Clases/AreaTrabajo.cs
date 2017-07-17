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
    public class AreaTrabajo
    {
        #region Declaracion de Seleccionar
        public DataTable Selecccionar(List<Filtro> pFiltros) {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "SELECT IdArea,";
                vSQL += "DescripcionArea";
                vSQL += "FROM dbo.AREA_TRABAJO";
                if (pFiltros != null && pFiltros.Count != 0) {
                    vSQL += vFiltros.CrearWhere(pFiltros);
                }
                vConnexion.Seleccionar(vSQL, "BASEDATOS");
            }
            catch (Exception ex) {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }
        #endregion

        #region Declaración de Insertar
        public void Insertar(Comunes.Estructuras.AreaTrabajo pDatos) {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.AREA_TRABAJO (DescripcionArea) ";
                vSQL += "VALUES('" + pDatos.DescripcionArea + "'";
                vConnexion.Ejecutar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion

        #region Declaracion de Eliminar
        public void Eliminar(List<Filtro> pFiltros)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                if (pFiltros != null && pFiltros.Count != 0)
                {
                    vSQL += "DELETE FROM dbo.AREA_TRABAJO ";
                    vSQL += vFiltros.CrearWhere(pFiltros);
                }
                vConnexion.Ejecutar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
        #endregion


        #region Declaracion de Actualizar
        public void Actualizar(Comunes.Estructuras.AreaTrabajo pDatos, List<Filtro> pFiltro = null)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.AREA_TRABAJO SET DescripcionArea = '" + pDatos.DescripcionArea + "' ";
                if (pFiltro == null)
                {
                    vSQL += "WHERE  IdAreaTrabajo = " + pDatos.IdAreaTrabajo;
                }
                else
                {
                    vSQL += vFiltros.CrearWhere(pFiltro);
                }
                vConnexion.Ejecutar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }

        public void Actualizar(List<Filtro> pFiltros, List<Campos> pCampos)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            string vQuery = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                foreach (Campos vCampo in pCampos) {
                    if (vQuery.Trim() == string.Empty) {
                        vQuery = "SET ";
                    }
                    else
                    {
                        vQuery += ", ";
                    }

                    if (vCampo.TipoDato.ToUpper() == "DEC" || vCampo.TipoDato.ToUpper() == "INT")
                     {
                        vQuery += vCampo.Campo + " = " + vCampo.Valor;
                    }
                    else if(vCampo.TipoDato.ToUpper() == "DATE")
                    {
                        vQuery += vCampo.Campo + " =  '" + String.Format("yyyyMMdd" ,Convert.ToDateTime(vCampo.Valor))+"'";

                    }
                    else
                    {
                        vQuery += vCampo.Campo + " = '" + vCampo.Valor+"'";
                    }
                }
                vSQL += "UPDATE dbo.AREA_TRABAJO " + vQuery;
                vSQL += vFiltros.CrearWhere(pFiltros);
                
                vConnexion.Ejecutar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

        }
        #endregion

    }
}
