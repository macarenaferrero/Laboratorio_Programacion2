using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Cerveza, Agua
        }

        #region Atributos

        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        #endregion

        #region Propiedades
        public int CapacidadLitros
        {
            get
            {
                return capacidadML / 1000;
            }
        }

        public int Contenido { get; set; }

        public float PorcentajeContenido
        {
            get
            {
                return (contenidoML/capacidadML)/100;
            }
        }

        #endregion

        #region Metodos

        public Botella(string marca, int capacidadML, int contenidoML)
        {
            if(capacidadML < contenidoML)
            {
                contenidoML = capacidadML;
            }
        }

        public abstract int ServirMedida();

        public virtual string GenerarInforme()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Marca botella: " + this.marca);
            retorno.AppendLine("Capacidad botella: " + this.CapacidadLitros);
            retorno.AppendLine("Contenido botella: " + this.Contenido);

            return retorno.ToString();
        }

        public override string ToString()
        {
            return GenerarInforme();
        }

        #endregion


    }
}
