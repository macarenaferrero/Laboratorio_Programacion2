using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto productoUno;

            productoUno = new Producto("Macarena", "Kpa", 909);

            string marca = productoUno.GetMarca();
            Console.WriteLine(marca);
            Console.WriteLine(Producto.MostrarProducto(productoUno));

            Console.ReadKey();
        }

    }
}
