﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Estructuras;
using Comunes.Filtros;
using System.Data;

namespace Datos.Clases
{
    public class CarteleraDetalle
    {
        #region Declaracion de Constructor

        public CarteleraDetalle()
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
                vSQL += "IdCartelera ";
                vSQL += ",IdPelicula ";
                vSQL += ",IdDetallle ";
                vSQL += ",FechaPelicula ";
                vSQL += ",HoraPelicula ";
                vSQL += ",FechaEstreno ";
                vSQL += ",FechaFinalizacion ";
                vSQL += "FROM dbo.CARTELERA_DETALLE";
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
        #endregion

        #region Declaración de Insertar
        public void Insertar(Comunes.Estructuras.CarteleraDetalle pDatos)
        {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.CARTELERA_DETALLE (IdCartelera, IdPelicula, FechaPelicula, HoraPelicula, FechaEstreno, FechaFinalizacion) ";
                vSQL += "VALUES(" + pDatos.IdCartelera.ToString() + ", " + pDatos.IdPelicula.ToString() + ", '" + string.Format("{0:yyyyMMdd}", pDatos.FechaPelicula.ToString()) + "', " + "'" + pDatos.HoraPelicula + "', '" + string.Format("{0:yyyyMMdd}", pDatos.FechaEstreno.ToString()) + "', '" + string.Format("{0:yyyyMMdd}", pDatos.FechaFinalizacion.ToString()) + "" + "')";
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
                    vSQL += "DELETE FROM dbo.CARTELERA_DETALLE";
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
        public void Actualizar(Comunes.Estructuras.CarteleraDetalle pDatos, List<Filtro> pFiltro)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.CARTELERA_DETALLE SET " + "IdCartelera = " + pDatos.IdCartelera.ToString() + ", " + "IdPelicula = " + pDatos.IdPelicula.ToString() + ", " + "FechaPelicula = " + string.Format("{0:yyyyMMdd}", pDatos.FechaPelicula.ToString()) + ", " + "HoraPelicula = " + "'" + pDatos.HoraPelicula + "', " + "FechaEstreno = " + string.Format("{0:yyyyMMdd}", pDatos.FechaEstreno.ToString()) + ", " + "FechaFinalizacion = " + string.Format("{0:yyyyMMdd}", pDatos.FechaFinalizacion.ToString()) + "";
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
                        vQuery += vCampo.Campo + " =  '" + String.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(vCampo.Valor)) + "'";
                    }
                    else
                    {
                        vQuery += vCampo.Campo + " = '" + vCampo.Valor + "'";
                    }
                }
                vSQL += "UPDATE dbo.CARTELERA_DETALLE" + vQuery;
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
