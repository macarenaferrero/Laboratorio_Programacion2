using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arreglo_n = new string[5];
            string[] arreglo_a = new string[5];
            string[] arreglo_e = new string[5];
            string[] arreglo_s = new string[5];

            for(int i =0; i<arreglo_n.Length;i++)
            {
                Console.WriteLine("Ingrese " + (i+1)+ "° nombre ");
                arreglo_n[i] = Console.ReadLine();
                Console.WriteLine("El nombre es " + arreglo_n[i]);
            }


          /*  for (int i = 0; i < arreglo_a.Length; i++)
            {
                Console.WriteLine("Ingrese el apellido");
                arreglo_a[i] = Console.ReadLine();
            }
          */

            Console.ReadKey();

        }
    }
}
