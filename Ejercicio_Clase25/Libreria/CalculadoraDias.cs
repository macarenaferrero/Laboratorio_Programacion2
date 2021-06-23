using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public static partial class Extension
    {

        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estacion)
        {
            DateTime dateTime = new DateTime();
            int cantDias = 0;

            switch (estacion)
            {
                case Estaciones.Verano:
                    dateTime = new DateTime(fecha.Year, 12, 21);
                    break;
                case Estaciones.Primavera:
                    dateTime = new DateTime(fecha.Year, 9, 21);
                    break;
                case Estaciones.Otonio:
                    dateTime = new DateTime(fecha.Year, 3, 21);
                    break;
                case Estaciones.Invierno:
                    dateTime = new DateTime(fecha.Year, 6, 21);
                    break;
                default:
                    break;
            }
            TimeSpan tp = dateTime - fecha;
            cantDias = tp.Days;

            return $"Faltan {cantDias} dias para {Enum.GetName(typeof(Estaciones), estacion)}";
        }
    }
}
