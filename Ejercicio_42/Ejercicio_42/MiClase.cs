using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class MiClase
    {
        private int numero;

        public MiClase(int numero, int numero2)
        {
            int retorno = 0;
            try
            {
                retorno = numero / numero2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error desde miClase.cs! : {ex.Message} producido en  {ex}");

            }
        }
        public MiClase(int numero, int numero2, int resultado) : this(numero, numero2)
        {
            try
            { 
                MiClase objeto = new MiClase(1, 0);
            }
            catch (UnaExcepcion exp)
            {
                Console.WriteLine($"Error al instanciar miClase! : {exp.Message}");
                throw new UnaExcepcion("Error por una excepcion! Mi Clase.cs ", exp);
            }

        }

        public static bool Lanzar()
        {
            throw new DivideByZeroException("Queres dividir por cero!");
        }
    }
}
