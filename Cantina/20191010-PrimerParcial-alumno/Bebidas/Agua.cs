using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Agua :Botella
    {
        const int MEDIDA = 400;

        public override int ServirMedida()
        {;
            if (MEDIDA <= this.contenidoML)
            {
                this.contenidoML = this.contenidoML - MEDIDA;
            }
            else
            {
                this.contenidoML = this.contenidoML - this.contenidoML;
            }
            return this.contenidoML;
        }

        public int ServirMedida(int medida)
        {
           if(medida <= this.contenidoML)
            {
                this.contenidoML = this.contenidoML - medida;
            }
            else
            {
                this.contenidoML = this.contenidoML - this.contenidoML;
            }
            return this.contenidoML;
        }

        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
        }

        public override string GenerarInforme()
        {
            StringBuilder sd = new StringBuilder();
            sd.AppendLine($"{base.GenerarInforme()}");

            //Contenido?
            sd.AppendLine("_________________________________________________________");

            return sd.ToString();
        }



    }
}
