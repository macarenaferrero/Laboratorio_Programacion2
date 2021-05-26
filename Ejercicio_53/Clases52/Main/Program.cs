using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases52;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Cartuchera1 cartuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();
            bool sumar = cartuchera1 + miLapiz;
            sumar = cartuchera1 + miBoligrafo;
            sumar = cartuchera2 + miBoligrafo;
            sumar = cartuchera2 + miLapiz;
            bool cargar = cartuchera1.ProbarElementos();
            bool cargar2 = cartuchera2.ProbarElementos();
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);
            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);

            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            Console.WriteLine(cargar);
            Console.WriteLine(cargar2);


            Console.ReadKey();
        }
    }
}
