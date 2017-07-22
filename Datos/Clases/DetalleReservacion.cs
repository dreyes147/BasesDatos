using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data;

namespace Datos.Clases
{
    public class DetalleReservacion
    {
        #region Declaracion de Constructor

        public DetalleReservacion()
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
                vSQL += "IdReservacion ";
                vSQL += ",IdPersona ";
                vSQL += ",IdTipoPersona ";
                vSQL += ",IdDetalle ";
                vSQL += ",IdCartelera ";
                vSQL += ",IdDetallle ";
                vSQL += ",IdNumeroAsiento ";
                vSQL += ",IdSala ";
                vSQL += ",IdTipoSala ";
                vSQL += ",IdPromocion ";
                vSQL += "FROM dbo.DETALLE_RESERVACION";
                if (pFiltros != null && pFiltros.Count != 0)
                {
                    vSQL += vFiltros.CrearWhere(pFiltros);
                }
                vConnexion.Seleccionar(vSQL, "BASEDATOS");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtResultado;
        }
        #endregion

        #region Declaración de Insertar
        public void Insertar(Comunes.Estructuras.DetalleReservacion pDatos)
        {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.DETALLE_RESERVACION (IdReservacion, IdPersona, IdTipoPersona, IdDetalle, IdCartelera, IdDetallle, IdNumeroAsiento, IdSala, IdTipoSala, IdPromocion) ";
                vSQL += "VALUES(" + pDatos.IdReservacion.ToString() + ", " + pDatos.IdPersona.ToString() + ", " + pDatos.IdTipoPersona.ToString() + ", " + pDatos.IdDetalle.ToString() + ", " + pDatos.IdCartelera.ToString() + ", " + pDatos.IdDetallle.ToString() + ", " + pDatos.IdNumeroAsiento.ToString() + ", " + pDatos.IdSala.ToString() + ", " + pDatos.IdTipoSala.ToString() + ", " + pDatos.IdPromocion.ToString() + "" + ")";
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
                    vSQL += "DELETE FROM dbo.DETALLE_RESERVACION";
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
        public void Actualizar(Comunes.Estructuras.DetalleReservacion pDatos, List<Filtro> pFiltro)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.DETALLE_RESERVACION SET " + "IdReservacion = " + pDatos.IdReservacion.ToString() + ", " + "IdPersona = " + pDatos.IdPersona.ToString() + ", " + "IdTipoPersona = " + pDatos.IdTipoPersona.ToString() + ", " + "IdDetalle = " + pDatos.IdDetalle.ToString() + ", " + "IdCartelera = " + pDatos.IdCartelera.ToString() + ", " + "IdDetallle = " + pDatos.IdDetallle.ToString() + ", " + "IdNumeroAsiento = " + pDatos.IdNumeroAsiento.ToString() + ", " + "IdSala = " + pDatos.IdSala.ToString() + ", " + "IdTipoSala = " + pDatos.IdTipoSala.ToString() + ", " + "IdPromocion = " + pDatos.IdPromocion.ToString() + "";
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
                vSQL += "UPDATE dbo.DETALLE_RESERVACION" + vQuery;
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
