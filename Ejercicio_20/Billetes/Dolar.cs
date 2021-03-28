using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        public Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
            : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            double respuesta;
            respuesta = this.cantidad;
            return respuesta;
        }

        public static double GetCotizacion()
        {
            double respuesta;
            respuesta = Dolar.cotizRespectoDolar;
            return respuesta;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar auxiliar = new Dolar(d);
            return auxiliar;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos valorA = new Pesos(d.cantidad * Pesos.GetCotizacion());
            return valorA;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro valorA = new Euro(d.cantidad * Euro.GetCotizacion());
            return valorA;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            bool rta = false;

            if (d.cantidad != ((Dolar)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            bool rta = false;

            if (d.cantidad == ((Dolar)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            bool rta = false;

            if (d.cantidad != ((Dolar)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            bool rta = false;

            if (d.cantidad == ((Dolar)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            bool rta = false;

            if (d1.cantidad != d2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool rta = false;

            if (d1.cantidad == d2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar rta = new Dolar(d.cantidad - (((Dolar)e).cantidad));
            return rta;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar rta = new Dolar(d.cantidad + (((Dolar)e).cantidad));
            return rta;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar rta = new Dolar(d.cantidad - (((Dolar)p).cantidad));
            return rta;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar rta = new Dolar(d.cantidad + (((Dolar)p).cantidad));
            return rta;
        }

    }
}
