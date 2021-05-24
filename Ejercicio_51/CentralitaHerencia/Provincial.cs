using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
#pragma warning disable CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    public class Provincial : Llamada, IGuardar<Provincial>
#pragma warning restore CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1 = 99,  
            Franja_2 = 125,
            Franja_3 = 66,
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return "Ruta De Archivo";
            }
            set
            {

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

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            :base(duracion, origen, destino)
        {
            this.franjaHoraria = miFranja;
        }

        protected override string Mostrar()
        {
            StringBuilder sbAux = new StringBuilder();

            sbAux.AppendLine($"Los datos de la llamada son: {base.Mostrar()}");
            sbAux.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");
            sbAux.AppendLine($"La franja horaria de la llamada es: {this.franjaHoraria}");

            return sbAux.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Provincial Leer()
        {
            throw new NotImplementedException();
        }
    }
}
