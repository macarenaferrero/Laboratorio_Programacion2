using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraString
{
    public class Calculadora
    {
        public int Add(string numeros)
        {
            if (numeros != string.Empty)
            {
                return 0;
            }
            else
            {
                string[] respuesta = numeros.Split(',');
                int sumatoria = 0;
                for (int i = 0; i < respuesta.Length; i++)
                {
                    sumatoria += int.Parse(respuesta[i])
                }
                return sumatoria;
            }

            return int.Parse(numeros);

        }
    }
}
