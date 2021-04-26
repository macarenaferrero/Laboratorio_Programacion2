using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto() 
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.ruedas = 2;
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) :this(patente, cilindrada)
        {
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) :this(patente, cilindrada, ruedas)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Cantidad de ruedas: {this.ruedas}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Moto;    
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
