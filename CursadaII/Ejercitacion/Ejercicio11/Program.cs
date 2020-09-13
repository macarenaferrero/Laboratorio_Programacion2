using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int respuestaInt;
            int contador = 0;
            int acumulador = 0;
            int min = int.MinValue;
            int max = int.MaxValue;
            float promedio;
            do
            {
                Console.WriteLine("Ingrese un numero");
                respuesta = Console.ReadLine();
                int.TryParse(respuesta, out respuestaInt);

                if (Validacion.Validar(respuestaInt,-100,100))
                {
                    acumulador = acumulador + respuestaInt;
                    contador++;
                    if(contador == 1 || respuestaInt < min)
                    {
                        min = respuestaInt;
                    }
                    if(contador == 1 || respuestaInt > max)
                    {
                        max = respuestaInt;
                    }
                }else
                {
                    Console.WriteLine("Valor incorrecto. Reingrese un numero");
                }
            } while (contador < 10);

            promedio = (float)acumulador / contador;

            Console.WriteLine("El valor max ingresado es: {0}", max);
            Console.WriteLine("El valor min ingresado es: {0}", min);
            Console.WriteLine("El promedio ingresado es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
