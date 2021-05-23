using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada numero: {this.cilindrada}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1.cilindrada == a2.cilindrada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
