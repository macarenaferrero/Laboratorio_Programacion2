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
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                if (value >= 2)
                {
                    this.cantidadCompetidores = value;
                }
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas; ;
            }
            set
            {
                if (value >= 1)
                {
                    this.cantidadVueltas = value;
                }
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i < this.competidores.Count)
                {
                    return this.competidores[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (i < this.competidores.Count)
                {
                    this.competidores[i] = value;
                }
                else
                {
                    competidores.Add(value);
                }
            }

        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                if (value >= 0)
                {
                    this.tipo = value;
                }
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cant. Competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cant. Vueltas: {this.cantidadVueltas}");
            foreach (VehiculoDeCarrera item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (!(c is null) && !(a is null))
            {
                if (c == a)
                {
                    c.competidores.RemoveAt(c.competidores.IndexOf(a));
                    a.EnCompetencia = false;
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random auxCombustible = new Random();

            if (!(c is null) && !(a is null))
            {
                if (c.competidores.Count < c.cantidadCompetidores && c != a)
                {
                    if ((c.Tipo == Competencia.TipoCompetencia.F1 && a is AutoF1) || (c.Tipo == Competencia.TipoCompetencia.MotoCross && a is MotoCross))
                    {
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        a.CantidadCombustible = (short)auxCombustible.Next(15, 100);
                        c.competidores.Add(a);
                        return true;
                    }

                }
            }
            return false;
        }


        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if (!(c.competidores is null) && !(a is null))
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (c.Tipo == Competencia.TipoCompetencia.F1 && a is AutoF1)
                    {
                        if ((AutoF1)item == (AutoF1)a)
                        {
                            return true;
                        }
                    }
                    else if(c.Tipo == Competencia.TipoCompetencia.MotoCross && a is MotoCross)
                    {
                        if ((MotoCross)item == (MotoCross)a)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }



    }
}
