using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Carrera
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 agus = new AutoF1(12345, "elMasRapido");
            AutoF1 maca = new AutoF1(6789, "laMasPancha");
            AutoF1 olgui = new AutoF1(234, "laVieji");
            Competencia laMasLarga = new Competencia(12, 2);

            if (laMasLarga + agus)
            {
                Console.WriteLine($"El siguiente competidor fue agregado ");
                Console.WriteLine("-----------------------");
                Console.WriteLine(agus.MostrarDatos());
            }

            if (laMasLarga + maca)
            {
                Console.WriteLine($"El siguiente competidor fue agregado ");
                Console.WriteLine("-----------------------");
                Console.WriteLine(maca.MostrarDatos());
            }

            Console.WriteLine(olgui.MostrarDatos());

            Console.ReadKey();
        }
    }
}
