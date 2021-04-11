using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libroPedido = new Libro();
            libroPedido[0] = "Jiji";
            Console.WriteLine(libroPedido[0] + " Y aca que hace:" + libroPedido[3]);

            Console.ReadKey();
        }
    }
}
