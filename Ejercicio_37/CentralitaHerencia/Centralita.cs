using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get 
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) :this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;

            foreach(Llamada auxLlamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (auxLlamada is Local)
                        {
                            retorno += ((Local)auxLlamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (auxLlamada is Provincial)
                        {
                            retorno += ((Provincial)auxLlamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (auxLlamada is Local)
                        {
                            retorno += ((Local)auxLlamada).CostoLlamada;
                        }
                        else if (auxLlamada is Provincial)
                        {
                            retorno += ((Provincial)auxLlamada).CostoLlamada;
                        }
                        break;
                }
            }

            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder sbAux = new StringBuilder();

            sbAux.AppendLine($"La empresa es: {this.razonSocial}");
            sbAux.AppendLine($"La ganancia total es: {this.GananciasPorTotal}");
            sbAux.AppendLine($"La ganancia Local es: {this.GananciasPorLocal}");
            sbAux.AppendLine($"La ganancia Provincial es: {this.GananciasPorProvincia}");
            sbAux.AppendLine($"Detalle de llamadas");

            foreach (Llamada auxLlamada in this.listaDeLlamadas)
            {
                sbAux.AppendLine(auxLlamada.Mostrar());
            }

            return sbAux.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
