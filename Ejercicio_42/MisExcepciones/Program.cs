using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_42;

namespace MisExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase objeto2 = new MiClase(1, 0);
            }
            catch (Exception epa)
            {
                Console.WriteLine($"Error producido {epa.Message} en {epa.InnerException}");
            }


            Console.ReadKey();
        }
    }
}
