using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaRemasterizada
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }



        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            // Con AppendFormat() y \n
            stringBuilder.AppendFormat("Duracion: {0}\n", this.duracion);

            // Con AppendLine() y Template Strings
            stringBuilder.AppendLine($"Nro Destino: {this.nroDestino}");
            stringBuilder.AppendLine($"Nro Origen: {this.nroOrigen}");

            return stringBuilder.ToString();
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            int retorno = 0;

            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;

            if(l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen && Llamada.Equals(l1, l2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
