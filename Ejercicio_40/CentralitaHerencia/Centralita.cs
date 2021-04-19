using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Centralita
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
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

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;

            foreach (Llamada auxLlamada in this.listaDeLlamadas)
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

        private string Mostrar()
        {
            StringBuilder sbAux = new StringBuilder();

            sbAux.AppendLine($"La empresa es: {this.razonSocial}");
            sbAux.AppendLine($"La ganancia total es: {this.GananciasPorTotal}");
            sbAux.AppendLine($"La ganancia Local es: {this.GananciasPorLocal}");
            sbAux.AppendLine($"La ganancia Provincial es: {this.GananciasPorProvincial}");
            sbAux.AppendLine($"Detalle de llamadas");

            foreach (Llamada auxLlamada in this.listaDeLlamadas)
            {
                sbAux.AppendLine(auxLlamada.ToString());
            }
            return sbAux.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            if (!(c is null) && !(llamada is null))
            {
                foreach (Llamada item in c.listaDeLlamadas)
                {
                    if (item == llamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != null && nuevaLlamada != null)
            {
                if (c != nuevaLlamada)
                {
                    if ((nuevaLlamada is Local) || (nuevaLlamada is Provincial))
                    {
                        c.AgregarLlamada(nuevaLlamada);
                        return c;
                    }
                }
            }
            return c;
        }

    }
}
