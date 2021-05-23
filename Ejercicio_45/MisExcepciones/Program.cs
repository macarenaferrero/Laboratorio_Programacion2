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
                OtraClase objeto2 = new OtraClase();
                objeto2.OtroMetodoInstancia();
            }
            catch (MiExcepcion epa)
            {
                Console.WriteLine($"Error producido: {epa.Message}");
                //Console.WriteLine($"Detalle: \n {epa.InnerException}");
                //Console.WriteLine($"{epa.InnerException.Message}");
                //Console.WriteLine("");
                //Console.WriteLine($"{epa.Message} \n {epa.Source}");
                Exception e = epa.InnerException;

                //while (!(object.ReferenceEquals(e, null)))
                //{
                //    Console.WriteLine(e.Message);
                //    e = e.InnerException;
                //}

                while (!(e is null))
                {
                    Console.WriteLine(e.Message);
                    e = e.InnerException;
                }
            }

            Console.ReadKey();
        }
    }
}
