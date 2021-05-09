using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparcial
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public static string InformeDeVentas(Vendedor v)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE");
            float importe = 0;

            foreach (Publicacion item in v.ventas)
            {
                sb.AppendLine("Publicacion:");
                sb.AppendLine($"{item.Informacion()}");
                sb.AppendLine("--------------------------");
                importe += item.Importe;
            }
            sb.AppendLine($"Ganancia total: {importe}");
            return sb.ToString();
        }

        public static bool operator +(Vendedor v, Publicacion p)
        {
            if(!(v is null) && !(p is null))
            {
                if(p.Stock > 0)
                {
                    v.ventas.Add(p);
                    p.Stock--;
                    return true;
                }
            }
            return false;
        }
    }
}
