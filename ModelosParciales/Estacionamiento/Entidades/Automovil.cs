using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) :base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHora) : this(patente, color)
        {
            Automovil.valorHora = valorHora;
        }

        public override bool Equals(object obj)
        {
            return obj is Automovil;    
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            sb.AppendLine($"Color: {this.color}");

            return sb.ToString();
        }

        public override string ImprimirTicket()
        {
            int tiempo = DateTime.Now.Hour - this.ingreso.Hour;
            int costoEstadia = valorHora * tiempo;
            StringBuilder sd = new StringBuilder();
            sd.AppendLine($"____Ticket____");
            sd.AppendLine($"{this.ConsultarDatos()}");
            sd.AppendLine($"Costo de estadia: {costoEstadia}");

            return sd.ToString();
        }
    }
}
