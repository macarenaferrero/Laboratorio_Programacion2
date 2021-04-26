using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.tamanio = tamanio;
            this.nombre = nombre;
        }
        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores { get; }
        public abstract bool TieneFruto { get; }


        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} tiene un tamaño de {this.tamanio}");
            if (this.TieneFlores)
            {
                sb.AppendLine($"Tiene flores: SI");
            }
            else
            {
                sb.AppendLine($"Tiene flores: NO");
            }

            if (this.TieneFruto)
            {
                sb.AppendLine($"Tiene fruto: SI");
            }
            else
            {
                sb.AppendLine($"Tiene fruto: NO");
            }

            return sb.ToString();
        }


    }
}
