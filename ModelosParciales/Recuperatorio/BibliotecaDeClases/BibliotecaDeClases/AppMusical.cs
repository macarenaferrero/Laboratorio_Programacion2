using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        /// <summary>
        /// Constructor que recibe los 3 parametros a asignar, reutiliza el constructor base
        /// </summary>
        /// <param name="nombre">Nombre de la app a asignar</param>
        /// <param name="sistOp">Sistema operativo de la app a asignar</param>
        /// <param name="tamanioInicial">Tamanio de la app a asignar</param>
        public AppMusical(string nombre, ESistemaOperativo sistOp, int tamanioInicial) : base(nombre, sistOp, tamanioInicial)
        {
        }

        /// <summary>
        /// Constructor que recibe los 3 parametros a asignar mas la lista de canciones, reutiliza el constructor anterior
        /// </summary>
        /// <param name="nombre">Nombre de la app a asignar</param>
        /// <param name="sistOp">Sistema operativo de la app a asignar</param>
        /// <param name="tamanioInicial">Tamanio de la app a asignar</param>
        /// <param name="lista">Lista de canciones a asignar</param>
        public AppMusical(string nombre, ESistemaOperativo sistOp, int tamanioInicial, List<string> lista) : this(nombre, sistOp, tamanioInicial)
        {
            this.listaCanciones = lista;
        }

        /// <summary>
        /// Propiedad que devuelve el tamanio de la app sumado las canciones de la lista
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                if (listaCanciones is null)
                {
                    return this.tamanioMb;
                }
                else
                {
                    int retorno = this.tamanioMb + (int)(listaCanciones.Count * 2);
                    return retorno;
                }
            }
        }

        /// <summary>
        /// Metodo que devuelve la info de la app
        /// </summary>
        /// <returns>Retorna string con datos</returns>
        public override string InfoApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.InfoApp());
            sb.AppendLine("Lista canciones");

            if (!(listaCanciones is null))
            {
                foreach (String item in this.listaCanciones)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }


    }
}
