using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Filtros
{
    class Filtro
    {
        #region Declaración de Variables
            private string vNombreCampo = string.Empty;
            private string vOperador = string.Empty;
            private object vValor = new object();
            private string vTipoDato = string.Empty;
        #endregion

        #region Declaración de Constructores
     
            public  Filtro(){
            }

            public Filtro(string NombreCampo,string Operador, string Valor)
            {
                this.vNombreCampo = NombreCampo;
                this.vOperador = Operador;
                this.vValor = Valor;

            }

            public Filtro(string NombreCampo, string Operador, int Valor)
            {
                this.vNombreCampo = NombreCampo;
                this.vOperador = Operador;
                this.vValor = Valor;
            }


            public Filtro(string NombreCampo, string Operador, decimal Valor)
            {
                this.vNombreCampo = NombreCampo;
                this.vOperador = Operador;
                this.vValor = Valor;

            }


            public Filtro(string NombreCampo, string Operador, short Valor)
            {
                this.vNombreCampo = NombreCampo;
                this.vOperador = Operador;
                this.vValor = Valor;

            }


            public Filtro(string NombreCampo, string Operador, DateTime Valor)
            {
                this.vNombreCampo = NombreCampo;
                this.vOperador = Operador;
                this.vValor = Valor;

            }


        #endregion

        #region Declaración de Propiedades

        public string NombreCampo
            {
                get
                {
                    return vNombreCampo;
                }
                set
                {
                    vNombreCampo = value;
                }
            }

            public string Operador
            {
                get
                {
                    return vOperador;
                }
                set
                {
                    vOperador = value;
                }
            }

            public string Valor
            {
                get
                {
                    return vValor;
                }
                set
                {
                    vValor = value;
                }
            }

            public string TipoDato
            {
                get
                {
                    return vTipoDato;
                }
                set
                {
                    vTipoDato = value;
                }
            }

        #endregion

        #region Delcaracion de Métodos

            public string CrearWhere(List<Filtro> pParametros) {
                string vResultado = string.Empty;
                

            return vResultado;
            }

        #endregion

    }
}
