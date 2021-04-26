using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Receta
    {
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        static Tipo preparacion;

        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        private Receta() 
        {
            ingredientes = new List<Ingrediente>();
        }

        public Receta(int capacidad) :this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        public enum Tipo
        {
            Clasica,
            Especial
        }

        static Tipo TipoDePreparacion 
        { set
            {
                preparacion = value;
            }
        }

        private int CapacidadLibre()
        {
            int espacioDisponible = capacidadDelContenedor;

            foreach (Ingrediente item in ingredientes)
            {
                espacioDisponible -= item.Cantidad;
            }

            return espacioDisponible;
        }

        private int CapacidadLibre(Ingrediente planta)
        {
            return this.CapacidadLibre() - planta.Cantidad;
        }

        public static bool operator +(Receta receta, Ingrediente ingrediente)
        {
            if(!(receta is null) && !(ingrediente is null))
            {
                if(receta.CapacidadLibre() >= ingrediente.Cantidad)
                {
                    receta.ingredientes.Add(ingrediente);
                    return true;
                }
            }
            return false;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receta: {Receta.preparacion}");
            sb.AppendLine($"Capacidad libre: {this.CapacidadLibre()}");
            sb.AppendLine($"Capacidad total: {this.capacidadDelContenedor}");
            sb.AppendLine("Lista de ingredientes");

            foreach (Ingrediente item in ingredientes)
            {
                sb.AppendLine(item.Informacion());
            }
            return sb.ToString();
        }





    }
}
