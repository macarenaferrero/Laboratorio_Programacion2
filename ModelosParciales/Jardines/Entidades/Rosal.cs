using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        private Color florColor;

        public enum Color
        {
            Roja,
            Blanca,
            Amarilla,
            Rosa,
            Azul
        }

        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {
        }

        public Rosal(string nombre, int tamanio, Color flor) : this(nombre, tamanio)
        {
            this.florColor = flor;
        }
        public override bool TieneFlores
        {
            get
            {
                return false;
            }
        }
        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color: {this.florColor}");

            return sb.ToString();
        }

    }
}
