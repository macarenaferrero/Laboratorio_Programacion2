using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    public class Rectangulo : Figura
    {
        protected double baseRectangulo;
        protected double alturaRectangulo;

        public Rectangulo(double baseRectangulo, double alturaRectangulo)
        {
            this.alturaRectangulo = alturaRectangulo;
            this.baseRectangulo = baseRectangulo;
        }
        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return this.baseRectangulo * this.alturaRectangulo;
        }

        public override double CalcularPerimetro()
        {
            return this.alturaRectangulo * 2 + this.baseRectangulo * 2;
        }
    }
}
        //No es necesario utilizar propiedes por de tipo de problema
        //public double BaseRectangulo
        //{
        //    get
        //    {
        //        return this.baseRectangulo;
        //    }
        //    set
        //    {
        //        if (baseRectangulo > 0)
        //        {
        //            this.baseRectangulo = value;
        //        }
        //    }
        //}

        //public double AlturaRectangulo
        //{
        //    get
        //    {
        //        return this.alturaRectangulo;
        //    }
        //    set
        //    {
        //        if (baseRectangulo > 0)
        //        {
        //            this.alturaRectangulo = value;
        //        }
        //    }
        //}
