using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponble)
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponble;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {e.nombre}");
            sb.AppendLine($"Espacio Disponible: {e.espacioDisponible}");
            sb.AppendLine($"Lista de Vehiculos");

            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
                sb.AppendLine("___________________");
            }

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(!(estacionamiento is null) && !(vehiculo is null))
            {
                foreach (Vehiculo item in estacionamiento.vehiculos)
                {
                    if(item == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo)
            {
                if(estacionamiento.vehiculos.Count < estacionamiento.espacioDisponible)
                {
                    estacionamiento.vehiculos.Add(vehiculo);
                }
            }

            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string respuesta;

            if (estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                respuesta = vehiculo.ImprimirTicket();
            }
            else
            {
                respuesta = "El vehículo no es parte del estacionamiento";
            }
            return respuesta;
        }


    }
}
