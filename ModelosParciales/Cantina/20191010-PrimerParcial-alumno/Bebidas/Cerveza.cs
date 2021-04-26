using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Cerveza : Botella
    {
        const int MEDIDA = 330;
        protected Tipo tipo;

        public Cerveza(string marca, int capacidadML, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : this(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        public override string GenerarInforme()
        {
            StringBuilder sd = new StringBuilder();
            sd.AppendLine($"{base.GenerarInforme()}");
            sd.AppendLine($"La Cerveza es del tipo: {this.tipo}");
            

            //Contenido?
            sd.AppendLine("_________________________________________________________");

            return sd.ToString();
        }

        public override int ServirMedida()
        {
            double auxMedida = MEDIDA * 0.8;
            if (MEDIDA <= this.contenidoML)
            {
                this.contenidoML = this.contenidoML - (int)auxMedida;
            }
            else
            {
                this.contenidoML = this.contenidoML - this.contenidoML;
            }
            return this.contenidoML;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}
