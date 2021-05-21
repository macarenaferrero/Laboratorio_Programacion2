using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Can. Competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Can. Vueltas: {this.cantidadVueltas}");

            return sb.ToString();
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (!(c is null) && !(a is null))
            {
                if (c == a)
                {
                    c.competidores.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random auxCombustible = new Random();

            if (!(c is null) && !(a is null))
            {
                if (c != a)
                {
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.VueltasRestantes = c.cantidadVueltas;
                    a.CantidadCombustible = (short)auxCombustible.Next(1, 100);
                    return true;
                }
            }
            return false;
        }


        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (!(c is null) && !(a is null))
            {
                foreach (AutoF1 item in c.competidores)
                {
                    if(item == a)
                    {
                        return true;
                    }
                }

            }
            return false;
        }


        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }



    }
}
