using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.cantidadCombustible = 0;
        }

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public static bool operator ==(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            if (!(a1 is null) && !(a2 is null))
            {
                if (a1.numero == a2.numero && a1.escuderia == a2.escuderia)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera a1, VehiculoDeCarrera a2)
        {
            return !(a1 == a2);
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero de vehiculo {this.numero}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            if(this.EnCompetencia)
            {
                sb.AppendLine("En competencia");
            }
            else
            {
                sb.AppendLine("No esta en competencia");
            }
            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");

            return sb.ToString();
        }

    }
}
