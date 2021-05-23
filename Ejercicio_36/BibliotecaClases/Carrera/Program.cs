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
            //VehiculoDeCarrera agus = new VehiculoDeCarrera(12345, "elMasRapido");
            //VehiculoDeCarrera maca = new VehiculoDeCarrera(6789, "laMasPancha");
            //VehiculoDeCarrera olgui = new VehiculoDeCarrera(234, "laVieji");
            //Competencia laMasLarga = new Competencia(12, 2, );

            //if (laMasLarga + agus)
            //{
            //    Console.WriteLine($"El siguiente competidor fue agregado ");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine(agus.MostrarDatos());
            //}

            //if (laMasLarga + maca)
            //{
            //    Console.WriteLine($"El siguiente competidor fue agregado ");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine(maca.MostrarDatos());
            //}

            //Console.WriteLine(olgui.MostrarDatos());

            //Console.ReadKey();

            Console.Title = "Excercise N° 36";
            #region Instances

            Competencia granTurismo = new Competencia(5, 20, Competencia.TipoCompetencia.F1);
            Competencia motoDakar = new Competencia(8, 10, Competencia.TipoCompetencia.MotoCross);

            AutoF1 f1 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f2 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f3 = new AutoF1(7, "McLaren", 510);

            MotoCross m1 = new MotoCross(1, "Honda", 160);
            MotoCross m2 = new MotoCross(1, "Honda", 160);
            MotoCross m3 = new MotoCross(69, "Yamaha", 159);

            string status;

            #endregion

            #region CompareCars

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Nuevo auto insertado en la competencia -----------");
            //Nuevo auto en la competencia
            if (granTurismo + f1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Nuevo auto insertado en la competencia -----------");
            //Nuevo auto en la competencia
            if (granTurismo + f3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f3.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Miso auto insertado en la competencia -----------");
            //Mismo auto en la competencia
            if (granTurismo + f2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f2.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Moto insertado en la competencia f1 -----------");

            if (granTurismo + m1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            #endregion

            # region ComparerMotorcycles

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Nueva moto insertada en la competencia MotoCross -----------");
            if (motoDakar + m1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Nueva moto insertada en la competencia MotoCross -----------");
            if (motoDakar + m3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m3.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Misma moto insertada en la competencia MotoCross -----------");
            if (motoDakar + m2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Moto agregada";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m2.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Insertar auto en la competencia MotoCross -----------");
            if (motoDakar + f1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                status = "Auto agregado";

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                status = "Auto no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            #endregion

            #region ShowCompetencesData

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Informacion competencias -----------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Turismo Carretera:");
            Console.WriteLine(granTurismo.MostrarDatos());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Dakar MotoCross:");
            Console.WriteLine(motoDakar.MostrarDatos());

            #endregion

            Console.ReadKey();
        }
    }
}
