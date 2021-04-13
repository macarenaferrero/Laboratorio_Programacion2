using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;

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
            :this(llamada.NroDestino, llamada.Duracion, llamada.NroOrigen, costo)
        { 
        }

        public Local(string origen, float duracion, string destino, float costo) :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override string Mostrar()
        {
            StringBuilder sbAux = new StringBuilder();

            sbAux.AppendLine($"Los datos de la llamada son: {base.Mostrar()}");
            sbAux.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");

            return sbAux.ToString();
        }
    }
}
