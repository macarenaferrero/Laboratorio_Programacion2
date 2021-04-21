using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formas;

namespace Calculadora_de_formas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> listaFiguras = new List<Figura>();
            Circulo circuloAux = new Circulo(4);
            Cuadrado cuadradoAux = new Cuadrado(56);
            Rectangulo rectanguloAux = new Rectangulo(3, 2);

            listaFiguras.Add(circuloAux);
            listaFiguras.Add(cuadradoAux);
            listaFiguras.Add(rectanguloAux);
                       
            foreach (Figura figura in listaFiguras)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"========= Figura {listaFiguras.IndexOf(figura) + 1} ==========");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(figura.GetType());
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine($"Área: {Math.Round(figura.CalcularSuperficie(), 2)}");
                Console.WriteLine($"Perímetro: {Math.Round(figura.CalcularPerimetro(), 2)}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=============================");
                            }

            Console.ReadKey();
        }
    }
}
