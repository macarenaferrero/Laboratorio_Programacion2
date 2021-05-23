using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo) : this(mensaje, nombreClase, nombreMetodo, null )
        {            
        }

        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }

        public string NombreClase 
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine("Error! Revisa el detalle");
            sb.AppendLine($"Detalle: {this.InnerException}");

            return sb.ToString();
        }
    }
}
