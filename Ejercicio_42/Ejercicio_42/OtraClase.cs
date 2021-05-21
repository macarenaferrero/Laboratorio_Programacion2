using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public OtraClase()
        {
            try
            {
                MiClase objeto = new MiClase(1, 0);
            }
            catch (MiExcepcion exp)
            {
                Console.WriteLine($"Error al instanciar en OtraClase.cs! : {exp.Message}");
                throw new MiExcepcion("Error de miExp! ", exp);
            }
        }
    }
}
