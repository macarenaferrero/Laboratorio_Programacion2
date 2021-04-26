using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    public class PickUp : Vehiculo
#pragma warning restore CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) :base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            PickUp.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Ingreso: {this.ingreso}");
            sb.AppendLine($"Modelo: {this.modelo}");

            return sb.ToString(); ;    
        }

        public override bool Equals(object obj)
        {
            return obj is PickUp;    
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
