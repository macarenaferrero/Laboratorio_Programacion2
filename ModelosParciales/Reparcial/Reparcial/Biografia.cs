using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparcial
{
    public class Biografia : Publicacion
    {
        public Biografia(string nombre)
            :this(nombre, 1, 0)
        {
        }

        public Biografia(string nombre, int stock)
            :this(nombre, stock, 0)
        {
        }

        public Biografia(string nombre, int stock, float valor)
            :base(nombre, stock, valor)
        {
        }

        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
               return base.HayStock;
            }

        }


        public static explicit operator Biografia(string nombre)
        {
            Biografia bioAux = new Biografia(nombre);
            return bioAux;
        }
    }
}
