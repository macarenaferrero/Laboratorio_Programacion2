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
            Console.Title = "Excercise N° 49";
            #region Instances

            Competencia<VehiculoDeCarrera> granTurismo = new Competencia<VehiculoDeCarrera>(5, 20, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            //  Competencia<MotoCross> motoDakar = new Competencia<MotoCross>(8, 10, Competencia<MotoCross>.TipoCompetencia.MotoCross);

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

            try
            {
                if (granTurismo + f1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    status = "Auto agregado";
                    Console.WriteLine($"{status} a la competencia");
                    Console.WriteLine("Vehiculo:");
                    Console.WriteLine(f1.MostrarDatos());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }



            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Nuevo auto insertado en la competencia -----------");
            //Nuevo auto en la competencia

            try
            {
                if (granTurismo + f3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    status = "Auto agregado";
                    Console.WriteLine($"{status} a la competencia");
                    Console.WriteLine("Vehiculo:");
                    Console.WriteLine(f3.MostrarDatos());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Mismo auto insertado en la competencia -----------");
            //Mismo auto en la competencia

            try
            {
                if (granTurismo + f2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    status = "Auto agregado";
                    Console.WriteLine($"{status} a la competencia");
                    Console.WriteLine("Vehiculo:");
                    Console.WriteLine(f2.MostrarDatos());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Moto insertada en la competencia f1 -----------");

            try
            {
                if (granTurismo + m1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    status = "Moto agregada";
                    Console.WriteLine($"{status} a la competencia");
                    Console.WriteLine("Vehiculo:");
                    Console.WriteLine(m1.MostrarDatos());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            #endregion



            #region ShowCompetencesData

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------- Informacion competencias -----------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Turismo Carretera:");
            Console.WriteLine(granTurismo.MostrarDatos());

            #endregion

            Console.ReadKey();
        }
    }
}
