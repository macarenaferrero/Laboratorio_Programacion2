using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casio
{
    public class Calculadora
    {
        public static int Calcular(int valorA, int valorB, char signo)
        {
            int resultado = 0;
            switch (signo)
            {
                case '+':
                    {
                        resultado = valorA + valorB;
                        break;
                    }
                case '-':
                    {
                        resultado = valorA - valorB;
                        break;
                    }
                case '*':
                    {
                        resultado = valorA * valorB;
                        break;
                    }
                case '/':
                    {
                        if(Validar(valorB))
                        {
                            resultado = valorA / valorB;
                        }
                        break;
                    }
            }

            return resultado;
        }


        private static bool Validar(int valor)
        {
            bool respuesta = false;
            if(valor != 0)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
