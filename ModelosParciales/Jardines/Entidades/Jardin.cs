using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;

        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        static Jardin()
        {
            Jardin.suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal) :this()
        {
            this.espacioTotal = espacioTotal;
        }

        static Tipo TipoSuelo
        {
            set
            {
                Jardin.suelo = value;
            }
        }

        private int EspacioOcupado()
        {
            int espacioDePlantas = 0;

            if (!(plantas is null))
            {
                foreach (Planta item in plantas)
                {
                    espacioDePlantas += item.Tamanio;
                }
            }
            return espacioDePlantas;
        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if (!(jardin is null) && !(planta is null))
            {
                if (jardin.espacioTotal >= jardin.EspacioOcupado(planta))
                {
                    jardin.plantas.Add(planta);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del jardin: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine("LISTAS DE PLANTAS");

            if (!(plantas is null))
            {
                foreach (Planta item in plantas)
                {
                    sb.AppendLine(item.ResumenDeDatos());
                }
            }
            return sb.ToString();
        }

    }

}
