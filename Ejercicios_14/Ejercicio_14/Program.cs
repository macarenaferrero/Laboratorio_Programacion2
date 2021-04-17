using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriadeClases;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int figura;
            double lado;
            double respuesta;
            double altura;
            double radio;

            Console.WriteLine("Bienvenidx a la calculadora de areas. Seleccione la figura a calcular 1-Cuadrado 2-Triangulo 3-Circulo");
            int.TryParse(Console.ReadLine(), out figura);
            switch(figura)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado");
                    double.TryParse(Console.ReadLine(), out lado);
                    if(lado>0)
                    {
                        respuesta = CalculoDeArea.CalcularCuadrado(lado);
                        Console.WriteLine("El area del cuadrado es de {0}", respuesta);
                    }
                    else
                    {
                        Console.WriteLine("Valor incorrecto");
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del triangulo");
                    double.TryParse(Console.ReadLine(), out lado);

                    Console.WriteLine("Ingrese la altura del triangulo");
                    double.TryParse(Console.ReadLine(), out altura);

                    if (lado > 0 && altura > 0)
                    {
                        respuesta = CalculoDeArea.CalcularTriangulo(lado, altura);
                        Console.WriteLine("El area del triangulo es de {0}", respuesta);
                    }
                    else
                    {
                        Console.WriteLine("Valor incorrecto");
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese el radio del circulo");
                    double.TryParse(Console.ReadLine(), out radio);
                    if (radio > 0)
                    {
                        respuesta = CalculoDeArea.CalcularCirculo(radio);
                        Console.WriteLine("El area del circulo es de {0}", respuesta);
                    }
                    else
                    {
                        Console.WriteLine("Valor incorrecto");
                    }
                    break;
            }
            Console.ReadKey();

        }
    }
}
