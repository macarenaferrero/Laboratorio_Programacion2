using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        protected string patente;

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (!(String.IsNullOrWhiteSpace(value)) && value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            
            return sb.ToString();
        }

        public override string ToString()
        {
            string aux1;
            aux1 = string.Format("Patente {0}", this.patente);

            return aux1;
        }


        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {

           if(!(v1 is null) && !(v2 is null))
            {
                if(v1.Equals(v2) && v2.Equals(v1) && v1.Patente == v2.Patente)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }



    }
}
