using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }
        protected Franja franjaHoraria;


        public float CostoLlamada
        {
            get 
            { 
                return this.CalcularCosto(); 
            }
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :this(miFranja, new Llamada(duracion, destino, origen))
        {
        }

        private float CalcularCosto()
        {
            return ((float)(this.franjaHoraria) / 100) * base.Duracion;
        }

        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Llamada Provincial");
            retorno.Append(base.Mostrar());
            retorno.AppendLine("Franja Horario: " + this.franjaHoraria);
            retorno.AppendLine("Costo llamada: " + this.CostoLlamada);

            return retorno.ToString();
        }
        


    }
}
