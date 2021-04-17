using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Retomando
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int valorValidado;
            int max = int.MinValue;
            int min = int.MaxValue;
            float promedio;
            int acumulador = 0;

            Console.WriteLine("Ingrese 10 numeros enteros del -100 al 100");
            for(int i=0; i<10 ;i++)
            {
                valor = Console.ReadLine();
                if (int.TryParse(valor, out valorValidado))
                {
                    if(Validacion.Validar(valorValidado, -100, 100))
                    {
                        acumulador = acumulador + valorValidado;
                        if(valorValidado > max)
                        {
                            max = valorValidado;
                        }
                        if(valorValidado<min)
                        {
                            min = valorValidado;
                        }

                    }else
                    {
                        Console.WriteLine("Valor incorrecto");
                        i--;
                    }
                }

            }
            promedio = acumulador / 10;
            Console.WriteLine("El valor minimo es {0}, el valor maximo es {1} y el promedio es {2}", min, max, promedio);
            Console.ReadKey();
        }
    }
}
