﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data;

namespace Negocio.Clases
{
    public class Idioma
    {
        #region Declaracion de Constructor
        Datos.Clases.Idioma vDatos = new Datos.Clases.Idioma();
        #endregion

        #region Declaracion de Constructor
        public Idioma()
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
        public void Insertar(Comunes.Estructuras.Idioma pDatos)
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
        #endregion

        #region Declaracion de Metodo Actualizar
        public void Actualizar(Comunes.Estructuras.Idioma pDatos, List<Filtro> pFiltro)
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
