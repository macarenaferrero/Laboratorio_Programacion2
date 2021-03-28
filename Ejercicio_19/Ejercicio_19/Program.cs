using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            long resultado;
            string texto;
            long resultado2;
            bool rta;

            Sumador valorA = new Sumador(2);
            resultado = valorA.Sumar(2,3);
            texto = valorA.Sumar("Casi", " me duermo");

            Sumador valorB = new Sumador();
            resultado2 = valorA + valorB;
            rta = valorA | valorB;

            Console.WriteLine("La suma es {0}",resultado);
            Console.WriteLine("Informo: {0}",texto);
            Console.WriteLine("La suma de ambos sumadores es: {0}", resultado2);
            Console.WriteLine("Ambos sumadores son iguales?: {0}", rta);

            Console.ReadKey();
        }
    }
}
