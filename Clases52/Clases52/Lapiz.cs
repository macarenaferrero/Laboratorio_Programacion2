using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;


        public Lapiz(int unidades)
        {
                
        }
        public ConsoleColor Color
        {
            get
            {
                return ConsoleColor.Red;
            }
            set
            {
            }
        }
        public float UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            float auxContador;
            auxContador = texto.Count() * 0.1f;
            UnidadesDeEscritura -= auxContador;

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de elemento {this.GetType()}");
            sb.AppendLine($"Color de escritura {this.Color}");
            sb.AppendLine($"Nivel de tinta {this.UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
