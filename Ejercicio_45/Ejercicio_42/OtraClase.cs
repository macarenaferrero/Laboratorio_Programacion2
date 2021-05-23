using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    public class OtraClase
    {
        public void OtroMetodoInstancia()
        {
            try
            {
                MiClase objeto = new MiClase(1);
            }
            catch (UnaExcepcion exp)
            {
                throw new MiExcepcion("Error de UnaExcepcion! en otra clase.cs ", exp);
            }
        }
    }
}
