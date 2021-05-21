using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected ESistemaOperativo sistemaOp;
        protected int tamanioMb;

        /// <summary>
        /// Constructor base de Aplicacion
        /// </summary>
        /// <param name="nombre">Nombre de la app a asignar</param>
        /// <param name="sistemaOp">Sistema operativo de la app a asignar</param>
        /// <param name="tamanioMb">Tamanio de la app a asignar</param>
        protected Aplicacion(string nombre, ESistemaOperativo sistemaOp, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOp = sistemaOp;
            this.tamanioMb = tamanioMb;
        }

        /// <summary>
        /// Propiedad que devuelve el sistema operativo
        /// </summary>
        public ESistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOp;
            }
        }

        /// <summary>
        /// Propiedad abstracta que implementaran las clases hijas que devuelve el tamanio
        /// </summary>
        protected abstract int Tamanio { get; }

        /// <summary>
        /// Metodo que devuelve la informacion de la aplicacion
        /// </summary>
        /// <returns>Retorna string con info de la app</returns>
        public virtual string InfoApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Nombre: {this.nombre}");
            sb.AppendLine($"Sistema op: {this.SistemaOperativo}");
            sb.AppendLine($"Tamanio: {this.Tamanio}");

            return sb.ToString();
        }

        //public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        //{
        //    int auxTamanio = 0;
        //    Aplicacion auxAplicacion;
        //    if (!(listaApp is null))
        //    {
        //        foreach (Aplicacion item in listaApp)
        //        {
        //            if (item.Tamanio > auxTamanio)
        //            {

        //                auxTamanio = item.Tamanio;
        //                auxAplicacion = item;
        //            }
        //        }
        //    }
        //    return (Aplicacion)auxAplicacion;
        //}

        /// <summary>
        /// Sobrecarga del igual igual, indica true si la app ya esta en la lista, false si no lo esta
        /// </summary>
        /// <param name="listaApp">Lista a buscar</param>
        /// <param name="app">App a comparar</param>
        /// <returns>Retorna true si esta, false si no esta</returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (!(listaApp is null) && !(app is null))
            {
                foreach (Aplicacion item in listaApp)
                {
                    if (item.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        /// <summary>
        /// Sobrecarga del diferente, rehutiliza el igual igual
        /// </summary>
        /// </summary>
        /// <param name="listaApp">Lista a buscar</param>
        /// <param name="app">App a comparar</param>
        /// <returns>Retorna false si esta, true si no esta</returns>
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// Sobrecarga del +, anade a la lista la app que recibe por parametro
        /// </summary>
        /// <param name="listaApp">Lista a buscar</param>
        /// <param name="app">App a comparar</param>
        /// <returns>Retorna true si pudo anadirlo, false si no</returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {

            if (!(listaApp is null) && !(app is null))
            {
                if (!(listaApp == app))
                {
                    listaApp.Add(app);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del string
        /// </summary>
        /// <returns>Devulve el nombre de la app</returns>
        public override string ToString()
        {
            return this.nombre;
        }


    }
}
