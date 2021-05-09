using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparcial
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock)
            : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }

        public virtual bool HayStock
        {
            get
            {
                if (this.Stock > 0 && this.Importe > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre {this.nombre.ToUpper()}\n");
            sb.AppendLine($"Stock: {this.Stock}");
            if (this.EsColor)
            {
                sb.AppendFormat("Color: SI \n");
            }
            else
            {
                sb.AppendFormat("Color: NO \n");
            }
            sb.AppendLine($"Valor: {this.Importe}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
