using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;

        public Ingrediente(string descripcion, int cantidad)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }
        public int Cantidad
        {
            get
            {
               return this.cantidad; 
            }
        }

        public abstract string Proceso { get;}

        public abstract string UnidadDeMedida { get; }

        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("{0} en una cantidad {1} {2}", this.descripcion, this.Cantidad, this.UnidadDeMedida));
            sb.AppendLine($"Procesar {this.Proceso}");

            return sb.ToString();
        }

    }
}
