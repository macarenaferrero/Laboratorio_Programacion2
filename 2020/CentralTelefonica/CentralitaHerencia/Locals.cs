using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;


        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, origen, destino)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder respuesta = new StringBuilder();

            respuesta.AppendLine("Llamada Local");
            respuesta.Append(base.Mostrar());
            respuesta.AppendLine("Costo: " + this.CostoLlamada);

            return respuesta.ToString();
        }
    }
}
