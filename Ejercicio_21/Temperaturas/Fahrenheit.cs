using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private double medida;
        private static double convRespFahrenheit;

        static Fahrenheit()
        {
            Fahrenheit.convRespFahrenheit = 1;
        }

        public Fahrenheit(double medida)
        {
            this.medida = medida;
        }
    }
}
