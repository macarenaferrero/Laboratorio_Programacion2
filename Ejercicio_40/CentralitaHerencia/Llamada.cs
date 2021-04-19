using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public abstract class Llamada
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }

        #region Propiedades

        public abstract float CostoLlamada { get; }

        public float Duracion
        { get
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

        #endregion

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder stbAux = new StringBuilder();

            stbAux.AppendLine($"Duracion :{this.duracion}");
            stbAux.AppendLine($"Nro Destino: {this.nroDestino}");
            stbAux.AppendLine($"Nro Origen: {this.nroOrigen}");

            return stbAux.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;
            if(llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 0;
            }

            if(llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else
            {
                retorno = -1;
            }
            return retorno;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
