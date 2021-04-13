using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1 = 99,  
            Franja_2 = 125,
            Franja_3 = 66,
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return ((float)(this.franjaHoraria) / 100) * base.Duracion;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(duracion, origen, destino)
        {
            this.franjaHoraria = miFranja;
        }

        public override string Mostrar()
        {
            StringBuilder sbAux = new StringBuilder();

            sbAux.AppendLine($"Los datos de la llamada son: {base.Mostrar()}");
            sbAux.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
            sbAux.AppendLine($"La franja horaria de la llamada es: {this.franjaHoraria}");

            return sbAux.ToString();
        }

    }
}
