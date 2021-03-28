using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casio;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            int valorA;
            int valorB;
            char signo;
            int respuesta;

            do
            {
                Console.WriteLine("Ingrese el valor A");
                int.TryParse(Console.ReadLine(), out valorA);
                Console.WriteLine("Ingrese el valor B");
                int.TryParse(Console.ReadLine(), out valorB);
                Console.WriteLine("Ingrese la operacion a realizar '+','-','*','/'");
                char.TryParse(Console.ReadLine(), out signo);

                respuesta = Calculadora.Calcular(valorA, valorB, signo);
                if (respuesta >0)
                {
                    Console.WriteLine("El resultado es {0}", respuesta);
                }
                else
                {
                    Console.WriteLine("Valores incorrectos");
                }

                Console.WriteLine("Desea continuar? Ingrese 's' o 'n'");
                char.TryParse(Console.ReadLine(), out continuar);
            }
            while (continuar == 's');
        }
    }
}
