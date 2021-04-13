using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private short edad;
        private string nombre;

        #region Propiedades
        public short Edad
        {
            get { return this.edad; }
            set { Edad = value; }
        }
         public string Nombre
        {
            get { return this.nombre; }
            set { Nombre = value; }
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Mostrara los atributos nombre y edad
        /// </summary>
        /// <returns>Retornara un string con los datos concatenados</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");

            return sb.ToString();
        }

        #endregion



    }
}
