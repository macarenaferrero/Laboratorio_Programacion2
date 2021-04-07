using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10, 0.809f);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10, 20.1655f);

            Pesos p2 = 10;
            Pesos p3 = new Pesos(10);

            Euro euroAux = e + d;
            Console.WriteLine("Euro + Dólar (€18,09xx): {0}", euroAux.GetCantidad());
            euroAux = e + p;
            Console.WriteLine("Euro + Pesos (€10,40xx): {0}", euroAux.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar dolarAux = d + e;
            Console.WriteLine("Dólar + Euro (U$S22,36xx): {0}", dolarAux.GetCantidad());
            dolarAux = d + p;
            Console.WriteLine("Dólar + Pesos (U$S10,49xx): {0}", dolarAux.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos pesoAux = p + e;
            Console.WriteLine("Pesos + Euro ($259,26xx): {0}", pesoAux.GetCantidad());
            pesoAux = p + d;
            Console.WriteLine("Pesos + Dólar ($211,65xx): {0}", pesoAux.GetCantidad());

            Console.ReadKey();




        }
    }
}
