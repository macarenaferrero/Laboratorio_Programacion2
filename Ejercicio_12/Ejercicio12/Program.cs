using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int valorValidado;
            int sumatoria =0;
            char rta;

            do
            {
                Console.WriteLine("Ingrese los valores que desea sumar");
                valor = Console.ReadLine();
                if (int.TryParse(valor, out valorValidado))
                {
                    sumatoria = sumatoria + valorValidado;
                }
                Console.WriteLine("Desea continuar?");
                valor = Console.ReadLine();
                if (char.TryParse(valor, out rta))
                {
                    ValidarRespuesta.ValidaS_N(rta);
                }

            } while (ValidarRespuesta.ValidaS_N(rta) == true);

            Console.WriteLine("La sumatoria es {0}",sumatoria);
            Console.ReadKey();
        }
    }
}
