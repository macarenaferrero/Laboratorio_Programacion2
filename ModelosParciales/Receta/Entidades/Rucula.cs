using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rucula : Ingrediente
    {

        public Rucula(string descripcion, int cantidad) :base(descripcion,cantidad)
        {
        }

        public override string Proceso
        {
            get
            {
                return "Cortar";
            }
        }

        public override string UnidadDeMedida
        {
            get 
            {
                return "hojas";
            }
        }
    }
}
