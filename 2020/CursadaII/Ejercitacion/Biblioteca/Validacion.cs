using System;

namespace Biblioteca
{
    public class Validacion
    {
        /// <summary>
        /// Valida si valor está en el rango
        /// </summary>
        /// <param name="valor"> Parametro a evaluar</param>
        /// <param name="min">Valor minimo</param>
        /// <param name="max">Valor maximo</param>
        /// <returns>true si está entre los valores, sino false</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno;

            retorno = true;

            if(valor < min || valor > max)
            {

                retorno = false;
            }
            return retorno;
        }
    }
}
