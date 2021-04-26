using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo
        {
            Vidrio,
            Plastico
        }

        public Botella(string marca, int capacidadML, int contendioML)
        {
            if (this.capacidadML < this.contenidoML)
            {
                this.contenidoML = this.capacidadML;
            }
            else
            {
                this.contenidoML = contendioML;
            }
            this.marca = marca;
            this.capacidadML = capacidadML;
        }

        public float CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return this.contenidoML * 100 / this.capacidadML;
            }
        }

        public abstract int ServirMedida();

        public virtual string GenerarInforme()
        {
            StringBuilder sd = new StringBuilder();
            sd.AppendLine($"La botella es de marca: {this.marca}");
            sd.AppendLine($"Contiene {this.contenidoML} en mililitros");
            sd.AppendLine($"Tiene una capacidad de: {this.capacidadML} en mililitros");
            sd.AppendLine("_________________________________________________________");

            return sd.ToString();
        }

        public override string ToString()
        {
            return GenerarInforme().ToString();
        }
    }
}
