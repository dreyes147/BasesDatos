using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using Comunes.Estructuras;
using System.Data;

namespace Datos.Clases
{
    public class AsientoSalaCine
    {
        #region Declaracion de Constructor

        public AsientoSalaCine()
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
                vSQL += "IdNumeroAsiento ";
                vSQL += ",IdSala ";
                vSQL += ",IdTipoAsiento ";
                vSQL += ",IdEstadoAsiento ";
                vSQL += "FROM dbo.ASIENTO_SALA_CINE";
                if (pFiltros != null && pFiltros.Count != 0)
                {
                    vSQL += vFiltros.CrearWhere(pFiltros);
                }
                dtResultado =  dtResultado = vConnexion.Seleccionar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }


        public List<Comunes.Estructuras.AsientoSalaCine> SelecccionarLista(List<Filtro> pFiltros)
        {
            List<Comunes.Estructuras.AsientoSalaCine> vResultado = new List<Comunes.Estructuras.AsientoSalaCine>();
            DataTable dtDatos = new DataTable();
            try
            {
                dtDatos = Selecccionar(pFiltros);
                foreach (DataRow vRow in dtDatos.Rows) {

                    Comunes.Estructuras.AsientoSalaCine vEstructura = new Comunes.Estructuras.AsientoSalaCine()
                    {
                        IdEstadoAsiento = Convert.ToInt32(vRow["IdEstadoAsiento"]),
                        IdSala = Convert.ToInt32(vRow["IdSala"]),
                        IdTipoAsiento= Convert.ToInt32(vRow["IdTipoAsiento"]),
                        IdNumeroAsiento = Convert.ToInt32(vRow["IdNumeroAsiento"]),
                    };
                    vResultado.Add(vEstructura);
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
        public void Insertar(Comunes.Estructuras.AsientoSalaCine pDatos)
        {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.ASIENTO_SALA_CINE (IdNumeroAsiento, IdSala, IdTipoAsiento, IdEstadoAsiento) ";
                vSQL += "VALUES(" + pDatos.IdNumeroAsiento.ToString() + ", " + pDatos.IdSala.ToString() + ", " + pDatos.IdTipoAsiento.ToString() + ", " + pDatos.IdEstadoAsiento.ToString() + "" + ")";
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
                    vSQL += "DELETE FROM dbo.ASIENTO_SALA_CINE";
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
        public void Actualizar(Comunes.Estructuras.AsientoSalaCine pDatos, List<Filtro> pFiltro)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.ASIENTO_SALA_CINE SET " + "IdNumeroAsiento = " + pDatos.IdNumeroAsiento.ToString() + ", " + "IdSala = " + pDatos.IdSala.ToString() + ", " + "IdTipoAsiento = " + pDatos.IdTipoAsiento.ToString() + ", " + "IdEstadoAsiento = " + pDatos.IdEstadoAsiento.ToString() + "";
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
                vSQL += "UPDATE dbo.ASIENTO_SALA_CINE" + vQuery;
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
