using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunes.Estructuras
{
    public class PersonaNacional
    {

        #region Declaracion de atributos

        private string vNombre;
        private string vPrimerApellido;
        private string vSegundoApellido;
        private DateTime vFechaNacimiento;
        private int vIdPersona;
        private int vIdTipoPersona;

        #endregion
        #region Declaracion de Constructor

        public PersonaNacional()
        {
        }
        #endregion

        #region Declaracion de Propiedades

        public string Nombre
        {
            get
            {
                return vNombre;
            }
            set
            {
                vNombre = value;
            }
        }

        public string PrimerApellido
        {
            get
            {
                return vPrimerApellido;
            }
            set
            {
                vPrimerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return vSegundoApellido;
            }
            set
            {
                vSegundoApellido = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return vFechaNacimiento;
            }
            set
            {
                vFechaNacimiento = value;
            }
        }

        public int IdPersona
        {
            get
            {
                return vIdPersona;
            }
            set
            {
                vIdPersona = value;
            }
        }

        public int IdTipoPersona
        {
            get
            {
                return vIdTipoPersona;
            }
            set
            {
                vIdTipoPersona = value;
            }
        }


        #endregion



    }
}
