using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vacuna
    {
        string nombreVacuna;

        public Vacuna(string nombreVacuna)
        {
            this.nombreVacuna = nombreVacuna;
        }

        public string ObtenerVacuna(string nombreVacuna)
        {
            return nombreVacuna;
        }

        
    }
}
