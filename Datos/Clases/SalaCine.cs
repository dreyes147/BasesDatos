using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data;

namespace Datos.Clases
{
    public class SalaCine
    {
        #region Declaracion de Constructor

        public SalaCine()
        {
        }
        #endregion

        #region Declaracion deL Seleccionar

        public DataTable Selecccionar(List<Filtro> pFiltros)
        {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "SELECT ";
                vSQL += "IdSala ";
                vSQL += ",CantidadAsientos ";
                vSQL += ",IdEstadoSala ";
                vSQL += ",IdTipoSala ";
                vSQL += ",IdTipoProyeccion ";
                vSQL += ",PrecioEntrada ";
                vSQL += "FROM dbo.SALA_CINE";
                if (pFiltros != null && pFiltros.Count != 0)
                {
                    vSQL += vFiltros.CrearWhere(pFiltros);
                }
                 dtResultado = vConnexion.Seleccionar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }

        public int SelecccionarId()
        {
            DataTable dtResultado = new DataTable("Datos");
            string vSQL = string.Empty;
            int vResultado = 0;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "SELECT ";
                vSQL += "MAX(IdSala) ";
                vSQL += "FROM dbo.SALA_CINE";
               
                dtResultado = vConnexion.Seleccionar(vSQL, "BASEDATOS");
                if (dtResultado.Rows.Count != 0) {
                    vResultado = Convert.ToInt32(dtResultado.Rows[0][0].ToString());    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return vResultado;
        }
        #endregion

        #region Declaración de Insertar
        public void Insertar(Comunes.Estructuras.SalaCine pDatos)
        {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.SALA_CINE ( CantidadAsientos, IdEstadoSala, IdTipoSala, IdTipoProyeccion, PrecioEntrada) ";
                vSQL += "VALUES(" + pDatos.CantidadAsientos.ToString() + ", " + pDatos.IdEstadoSala.ToString() + ", " + pDatos.IdTipoSala.ToString() + ", " + pDatos.IdTipoProyeccion.ToString() + ", " + pDatos.PrecioEntrada.ToString() + "" + ")";
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
                    vSQL += "DELETE FROM dbo.SALA_CINE";
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
        public void Actualizar(Comunes.Estructuras.SalaCine pDatos, List<Filtro> pFiltro)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.SALA_CINE SET " + "CantidadAsientos = " + pDatos.CantidadAsientos.ToString() + ", " + "IdEstadoSala = " + pDatos.IdEstadoSala.ToString() + ", " + "IdTipoSala = " + pDatos.IdTipoSala.ToString() + ", " + "IdTipoProyeccion = " + pDatos.IdTipoProyeccion.ToString() + ", " + "PrecioEntrada = " + pDatos.PrecioEntrada.ToString() + "";
                if (pFiltro != null)
                {
                    vSQL += vFiltros.CrearWhere(pFiltro);
                    vConnexion.Ejecutar(vSQL, "BASEDATOS");
                }
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
                foreach (Campos vCampo in pCampos)
                {
                    if (vQuery.Trim() == string.Empty)
                    {
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
                    else if (vCampo.TipoDato.ToUpper() == "DATE")
                    {
                        vQuery += vCampo.Campo + " =  '" + String.Format("yyyyMMdd", Convert.ToDateTime(vCampo.Valor)) + "'";
                    }
                    else
                    {
                        vQuery += vCampo.Campo + " = '" + vCampo.Valor + "'";
                    }
                }
                vSQL += "UPDATE dbo.SALA_CINE" + vQuery;
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
