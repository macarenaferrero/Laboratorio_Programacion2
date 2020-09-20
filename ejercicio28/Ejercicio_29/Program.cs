using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Ejercicio_29;

namespace Ejercicio_29
{
    class Program
    {

        static void Main(string[] args)
        {
            Jugador jugador = new Jugador(37179061, "Maca Ferrero", 7, 10);

            Console.WriteLine(jugador.MostrarDatos());

            Console.ReadKey();
        }
    }
}
