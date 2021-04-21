using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double baseCuadrado) : base(baseCuadrado, baseCuadrado)
        {
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }
    }
}
