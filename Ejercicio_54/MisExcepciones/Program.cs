using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_42;
using IO;

namespace MisExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 54";
            string auxStackTrace = String.Empty;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + DateTime.Now.ToString();

            try
            {
                OtraClase auxClase = new OtraClase();
                auxClase.OtroMetodoInstancia();
            }
            catch (Exception e)
            {
                try
                {
                    while (e != null)
                    {
                        //Console.WriteLine(e.Message);

                        auxStackTrace += e.StackTrace.ToString() + "\n";

                        e = e.InnerException;

                    }

                    if (ArchivoTexto.Guardar(path, auxStackTrace))
                    {
                        Console.WriteLine("Archivo guardado correctamente");
                    }

                }
                catch (Exception error)
                {

                    Console.WriteLine(error.Message);
                }
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Lista de stacktrace traida desde archivo: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(ArchivoTexto.Leer(path));
                Console.ResetColor();
                Console.ReadKey();
            }
        }
    }
}
