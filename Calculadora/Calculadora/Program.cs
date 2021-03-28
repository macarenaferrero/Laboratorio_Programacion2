using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            char operacion;
            double resultado;

            Console.WriteLine("Bienvenido a la Calculadora");
            Console.WriteLine("Ingrese un numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la operación [+,-,*,/]");
            operacion = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            switch(operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("Los valores se sumaron y el resultado es " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("Los valores se restaron y el resultado es " + resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("Los valores se multiplicaron y el resultado es " + resultado);
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Los valores se dividieron y el resultado es " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
            }
            Console.WriteLine("Gracias por usar nuestro servicio");
            Console.ReadKey();

        }
    }
}
