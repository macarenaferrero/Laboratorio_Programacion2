using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11001 convertido a decimal es: {0}", Conversor.BinarioDecimal("11001"));
            Console.WriteLine("111001 convertido a decimal es: {0}", Conversor.BinarioDecimal("111001"));
            Console.WriteLine("1b0c1 convertido a decimal es: {0}", Conversor.BinarioDecimal("1b0c1"));

            Console.WriteLine("12 convertido a binario es {0}", Conversor.DecimalBinario(12));
            Console.WriteLine("127 convertido a binario es {0}", Conversor.DecimalBinario(127));
            Console.WriteLine("224 convertido a binario es {0}", Conversor.DecimalBinario(224));




            Console.ReadKey();
        }
    }
}
