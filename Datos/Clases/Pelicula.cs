﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data;


namespace Datos.Clases
{
    public class Pelicula
    {
        #region Declaracion de Constructor

        public Pelicula()
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
                vSQL += "IdPelicula ";
                vSQL += ",NombrePelicula ";
                vSQL += ",TituloPelicula ";
                vSQL += ",IdSubtitulo ";
                vSQL += ",IdIdioma ";
                vSQL += "FROM dbo.PELICULAS";
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
        #endregion

        #region Declaración de Insertar
        public void Insertar(Comunes.Estructuras.Pelicula pDatos)
        {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.PELICULAS (NombrePelicula, TituloPelicula, IdSubtitulo, IdIdioma) ";
                vSQL += "VALUES(" + "'" + pDatos.NombrePelicula + "', " + "'" + pDatos.TituloPelicula + "', " + pDatos.IdSubtitulo.ToString() + ", " + pDatos.IdIdioma.ToString() + "" + ")";
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
                    vSQL += "DELETE FROM dbo.PELICULAS";
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
        public void Actualizar(Comunes.Estructuras.Pelicula pDatos, List<Filtro> pFiltro)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.PELICULAS SET " + ", " + "NombrePelicula = " + "'" + pDatos.NombrePelicula + "', " + "TituloPelicula = " + "'" + pDatos.TituloPelicula + "', " + "IdSubtitulo = " + pDatos.IdSubtitulo.ToString() + ", " + "IdIdioma = " + pDatos.IdIdioma.ToString() + "";
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
                vSQL += "UPDATE dbo.PELICULAS" + vQuery;
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
