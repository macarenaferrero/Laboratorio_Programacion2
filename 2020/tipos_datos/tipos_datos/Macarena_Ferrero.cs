using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_datos
{
    class Macarena_Ferrero
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su edad es " + edad);
            Console.ReadKey();
        }
    }
}
