using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(66);

            Pesos p2 = 10;
            Pesos p3 = new Pesos(10);

            Euro euroAux = e + d;
            Console.WriteLine("Euro + Dólar (€20,8xx): {0}", euroAux.GetCantidad());
            euroAux = e + p;
            Console.WriteLine("Euro + Pesos (€81,28xx): {0}", euroAux.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar dolarAux = d + e;
            Console.WriteLine("Dólar + Euro (U$S20,08xx): {0}", dolarAux.GetCantidad());
            dolarAux = d + p;
            Console.WriteLine("Dólar + Pesos (U$S11,00xx): {0}", dolarAux.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos pesoAux = p + e;
            Console.WriteLine("Pesos + Euro ($778,8xx): {0}", pesoAux.GetCantidad());
            pesoAux = p + d;
            Console.WriteLine("Pesos + Dólar ($726,00xx): {0}", pesoAux.GetCantidad());

            Console.ReadKey();


        }
    }
}
