using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador()
            : this(0)
        {
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas = cantidadSumas + 1;
            long resultado;
            resultado = a + b;

            return resultado;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas = cantidadSumas + 1;
            string resultado;
            resultado = a + b;
            return resultado;
        }

        public static explicit operator int(Sumador s)
        {
            int retorno;
            retorno = s.cantidadSumas;

            return retorno;
        }

        public static long operator +(Sumador s1,Sumador s2)
        {
            long respuesta = s1.cantidadSumas + s2.cantidadSumas;
            return respuesta;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool respuesta;
            respuesta = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                respuesta = true;
            }
            return respuesta;
        }


    }
}
