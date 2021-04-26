using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class QuesoAzul : Ingrediente
    {
        private Procedencia procedencia;

        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }

        public QuesoAzul(string descripcion, int cantidad) : base(descripcion, cantidad)
        { 
        }

        public QuesoAzul(string descripcion, int cantidad,  Procedencia procedencia) :this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Procedente: {this.procedencia}");

            return sb.ToString();
        }

        public override string Proceso
        {
            get
            {
                return "Desgranar";
            }
        }

        public override string UnidadDeMedida
        {
            get
            {
                return "Gramos";
            }
        }

    }
}
