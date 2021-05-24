using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
#pragma warning disable CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    public class Local : Llamada, IGuardar<Local>
#pragma warning restore CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    {
        protected float costo;

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
            return this.costo * base.Duracion;
        }

        public Local(Llamada llamada, float costo)
            :this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        // :base(llamada.NroDestino, llamada.Duracion, llamada.NroOrigen)
        {
        }

        public Local(float duracion, string destino, string origen, float costo) 
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sbAux = new StringBuilder();

            sbAux.AppendLine($"Los datos de la llamada son: {base.Mostrar()}");
            sbAux.AppendLine($"El costo de la llamada es: {this.CostoLlamada}");

            return sbAux.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
    }
}
