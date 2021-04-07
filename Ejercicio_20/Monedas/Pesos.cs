using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static void SetCotizacion(double valor)
        {
            Pesos.cotizRespectoDolar = valor;
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
            respuesta = Pesos.cotizRespectoDolar;
            return respuesta;
        }

        public static implicit operator Pesos(double p)
        {
            Pesos auxiliar = new Pesos(p);
            return auxiliar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar valorA = new Dolar(p.cantidad / Pesos.GetCotizacion());
            return valorA;
        }


        public static explicit operator Euro(Pesos p)
        {
            Dolar aux = (Dolar)p;
            Euro valorA = (Euro)aux;
            //Euro valorA = new Euro(p.cantidad / Pesos.GetCotizacion());
            return valorA;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            bool rta = false;

            if (p.cantidad != ((Pesos)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            bool rta = false;

            if (p.cantidad == ((Pesos)e).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            bool rta = false;

            if (p.cantidad != ((Pesos)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            bool rta = false;

            if (p.cantidad == ((Pesos)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            bool rta = false;

            if (p1.cantidad != p2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            bool rta = false;

            if (p1.cantidad == p2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos rta = new Pesos(p.cantidad - (((Pesos)e).cantidad));
            return rta;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos rta = new Pesos(p.cantidad + (((Pesos)e).cantidad));
            return rta;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos rta = new Pesos(p.cantidad - (((Pesos)d).cantidad));
            return rta;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos rta = new Pesos(p.cantidad + (((Pesos)d).cantidad));
            return rta;
        }
    }
}
