using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Conversor
    {
        public static string DecimalBinario(int valor)
        {
            string respuesta = ".";

            if (valor > 0)
            {
                while (valor > 0)
                {
                    if (valor % 2 == 0)
                    {
                        respuesta = "0" + respuesta;
                    }
                    else
                    {
                        respuesta = "1" + respuesta;
                    }

                    valor = (int)valor / 2;
                }
            }
            else
            {
                respuesta = "Valor invalido";
            }

            return respuesta;
        }



        public static int BinarioDecimal(string valor)
        {
            int respuesta;
            double valorBinario = 0;

            for(int i = valor.Length - 1; i >= 0; i--)
            {
                if(int.TryParse(valor[valor.Length - i - 1].ToString(), out respuesta))
                {
                    valorBinario = valorBinario + respuesta * Math.Pow(2, i);
                }
                else
                {
                    return 0;
                }

            }
                return (int)valorBinario;

        }


    }
}
