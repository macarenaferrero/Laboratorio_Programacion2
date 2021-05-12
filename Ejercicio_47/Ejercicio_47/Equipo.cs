using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public static bool operator ==(Equipo a, Equipo b)
        {
            if (!(a is null) && !(b is null))
            {
                if (a.fechaCreacion == b.fechaCreacion && a.nombre == b.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a == b);
        }


        public string Ficha(Equipo a)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} fundado el {this.fechaCreacion}");

            return sb.ToString();
        }

    }

}
}
