using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comunes.Filtros;
using System.Data;

namespace Datos.Clases
{
    public class UsuarioSistema
    {
        #region Declaracion de Constructor

        public UsuarioSistema()
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
                vSQL += "IdPersona ";
                vSQL += ",IdTipoPersona ";
                vSQL += ",IdTipoUsuario ";
                vSQL += "FROM dbo.USUARIO_SISTEMA";
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
        public void Insertar(Comunes.Estructuras.UsuarioSistema pDatos)
        {
            string vSQL = string.Empty;
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "INSERT INTO dbo.USUARIO_SISTEMA (IdPersona, IdTipoPersona, IdTipoUsuario) ";
                vSQL += "VALUES(" + pDatos.IdPersona.ToString() + ", " + pDatos.IdTipoPersona.ToString() + ", " + pDatos.IdTipoUsuario.ToString() + "" + ")";
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
                    vSQL += "DELETE FROM dbo.USUARIO_SISTEMA";
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
        public void Actualizar(Comunes.Estructuras.UsuarioSistema pDatos, List<Filtro> pFiltro)
        {
            string vSQL = string.Empty;
            Filtro vFiltros = new Filtro();
            Conexion.Conexion vConnexion = new Conexion.Conexion();
            try
            {
                vSQL += "UPDATE dbo.USUARIO_SISTEMA SET " + "IdPersona = " + pDatos.IdPersona.ToString() + ", " + "IdTipoPersona = " + pDatos.IdTipoPersona.ToString() + ", " + "IdTipoUsuario = " + pDatos.IdTipoUsuario.ToString() + "";
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
                vSQL += "UPDATE dbo.USUARIO_SISTEMA" + vQuery;
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
