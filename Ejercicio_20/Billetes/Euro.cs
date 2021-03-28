using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
#pragma warning disable CS0660
#pragma warning disable CS0661
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1 / 1.3642f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
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
            respuesta = Euro.cotizRespectoDolar;
            return respuesta;
        }

        public static implicit operator Euro(double e)
        {
            Euro auxiliar = new Euro(e);
            return auxiliar;
        }

        public static explicit operator Pesos(Euro e)
        {
            //Pesos valorA = new Pesos(e.cantidad / Euro.GetCotizacion());
            //return valorA;
            return (Pesos)((Dolar)e);
        }

        public static explicit operator Dolar(Euro e)
        {
            Dolar valorA = new Dolar(e.cantidad / Euro.GetCotizacion());
            return valorA;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            bool rta = false;

            if (e.cantidad != ((Euro)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            bool rta = false;

            if (e.cantidad == ((Euro)p).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            bool rta = false;

            if (e.cantidad != ((Euro)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            bool rta = false;

            if (e.cantidad == ((Euro)d).cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            bool rta = false;

            if (e1.cantidad != e2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            bool rta = false;

            if (e1.cantidad == e2.cantidad)
            {
                rta = true;
            }
            return rta;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro rta = new Euro(e.cantidad - (((Euro)p).cantidad));
            return rta;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro rta = new Euro(e.cantidad + (((Euro)p).cantidad));
            return rta;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro rta = new Euro(e.cantidad - (((Euro)d).cantidad));
            return rta;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro rta = new Euro(e.cantidad + (((Euro)d).cantidad));
            return rta;
        }
    }
}
