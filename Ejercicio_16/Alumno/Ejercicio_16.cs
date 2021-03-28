using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumnos;

namespace Alumnos
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            Random random = new Random();
            if(nota1 >= 4 && nota2 >= 4)
            {
                this.notaFinal = random.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {

        }
    }
}
