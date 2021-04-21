using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public sealed class Circulo : Figura
    {
        private double radio;


        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override string Dibujar()
        {
            return "Dibujando Circulo";
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(this.radio * Math.PI, 2) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.radio;
        }
    }
}
        //No es necesario utilizar propiedes por de tipo de problema
        //public double Radio
        //{
        //    get
        //    {
        //        return this.radio;
        //    }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            this.radio = value;

        //        }
        //    }
        //}
