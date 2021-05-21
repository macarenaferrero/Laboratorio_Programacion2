using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class AppJuegos :Aplicacion
    {

        /// <summary>
        /// Constructor de AppJuegos
        /// </summary>
        /// <param name="nombre">Nombre del juego a asignar</param>
        /// <param name="sistOp">Sistema operativo a asignar</param>
        /// <param name="tamanio">Tamanio del juego a asignar</param>
        public AppJuegos(string nombre, ESistemaOperativo sistOp, int tamanio) : base(nombre, sistOp, tamanio)
        {
        }

        /// <summary>
        /// Sobrecarga de la propiedad Tamanio, devuelve el tamanio del juego
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb;
            }
        }
    }
}
