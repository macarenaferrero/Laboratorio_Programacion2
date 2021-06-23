using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Ejercicio_Clase25
{
    public class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha = DateTime.Now;

            Console.WriteLine(fecha.ObtenerPlacaCronica(Estaciones.Verano));

            Console.ReadKey();
        }
    }
}
