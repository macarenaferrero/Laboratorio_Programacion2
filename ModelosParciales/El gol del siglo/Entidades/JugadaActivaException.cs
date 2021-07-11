using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JugadaActivaException : Exception
    {
        public string mensaje;
        public JugadaActivaException() : base("El gol ya esta ocurriendo. Disfrutelo")
        {
        }
    }
}
