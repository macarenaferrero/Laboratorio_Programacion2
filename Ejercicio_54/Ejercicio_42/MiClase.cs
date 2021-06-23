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

        public MiClase()
        {
            try
            {
                Lanzar();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Una excepcion desde miClase.cs", ex);
            }
        }
        public MiClase(int numero)
        {
            this.numero = numero;
            try
            { 
                new MiClase();
            }
            catch (UnaExcepcion exp)
            {
                throw new UnaExcepcion("Error por una excepcion! Mi Clase.cs ", exp);
            }

        }

        public static void Lanzar()
        {
            throw new DivideByZeroException("Queres dividir por cero!");
        }
    }
}
