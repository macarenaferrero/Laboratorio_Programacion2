using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Competencia<T>
        where T : VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private Competencia()
        {
            competidores = new List<T>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
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

        public static bool operator -(Competencia<T> c, VehiculoDeCarrera a)
        {
            if (!(c is null) && !(a is null))
            {
                if (c == a)
                {
                    c.competidores.Remove((T)a);
                    a.EnCompetencia = false;
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Competencia<T> c, VehiculoDeCarrera a)
        {
            Random auxCombustible = new Random();
            if (!(c is null) && !(a is null))
            {
                try
                {
                    if (c.competidores.Count < c.cantidadCompetidores && c != a)
                    {
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.cantidadVueltas;
                        a.CantidadCombustible = (short)auxCombustible.Next(15, 100);
                        c.competidores.Add((T)a);
                        return true;
                    }
                }
                catch (CompetenciaNoDisponibleException ex)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia.cs", "Operador +", ex);
                }
            }
            return false;
        }


        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera a)
        {
            if (!(c.competidores is null) && !(a is null))
            {

                if (c.Tipo == Competencia<T>.TipoCompetencia.F1 && !(a is AutoF1) || (c.Tipo == Competencia<T>.TipoCompetencia.MotoCross && !(a is MotoCross)))
                {
                    throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia.cs", "Metodo ==");

                }
                else
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (item == a)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }


        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }



    }
}
