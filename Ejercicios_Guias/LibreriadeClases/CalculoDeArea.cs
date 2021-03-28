using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriadeClases
{
    public class CalculoDeArea
    {

        /// <summary>
        /// Calcula el area de un cuadrado
        /// </summary>
        /// <param name="lado">Recibe el lado del cuadrado</param>
        /// <returns>Retorna el valor del area o 0 si el lado es incorrecto</returns>
        public static double CalcularCuadrado(double lado)
        {
            double resultado = 0;

            if(lado > 0)
            {
                resultado = lado * lado;
            }
            return resultado;
        }

        /// <summary>
        /// Calcula el area de un triangulo
        /// </summary>
        /// <param name="baseTriangulo">Recibe la base del triangulo a calcular</param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            double resultado = 0;

            if (baseTriangulo > 0 && altura > 0)
            {
                resultado = baseTriangulo * altura / 2;
            }
            return resultado;
        }

        public static double CalcularCirculo(double radio)
        {
            double resultado = 0;

            if(radio > 0)
            {
                resultado = 3.14 * radio * radio;
            }
            return resultado;
        }
    }
}
