using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public List<Llamada> Llamadas
        {
            get
            {
                    return this.listaDeLlamadas;
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
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

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float resultado = 0;

            foreach(Llamada auxLlamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(auxLlamada is Local)
                        {
                            resultado += ((Local)auxLlamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if(auxLlamada is Provincial)
                        {
                            resultado += ((Provincial)auxLlamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if(auxLlamada is Local)
                        {
                            resultado += ((Local)auxLlamada).CostoLlamada;
                        }
                        else if(auxLlamada is Provincial)
                        {
                            resultado += ((Provincial)auxLlamada).CostoLlamada;
                        }
                        break;
                }

            }
                return resultado;   

        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Ganancias:");
            retorno.AppendLine("Totales: " + this.GananciasPorTotal);
            retorno.AppendLine("Provincial: " + this.GananciasPorProvincial);
            retorno.AppendLine("Local: " + this.GananciasPorLocal);

            retorno.AppendLine("____________________________");
            retorno.AppendLine("Detalle de llamadas");

            foreach(Llamada auxLlamada in this.listaDeLlamadas)
            {
                if(auxLlamada is Local)
                {
                    retorno.AppendLine(((Local)auxLlamada).Mostrar());
                }
                else if(auxLlamada is Provincial)
                {
                    retorno.AppendLine(((Provincial)auxLlamada).Mostrar());
                }
            }
            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
