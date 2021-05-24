using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases52
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                if (value.GetType() == typeof(ConsoleColor))
                {
                    this.colorTinta = value;
                }
            }
        }


        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                if (value > 0)
                {
                    this.tinta = value;
                }
            }
        }


        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            float auxContador;
            auxContador = texto.Count() * 0.3f;
            UnidadesDeEscritura -= auxContador;

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            if (unidades >= 1)
            {
                UnidadesDeEscritura = unidades;
                return true;
            }
            return false;
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
