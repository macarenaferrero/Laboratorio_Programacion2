using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        //Defino el indexador
        public string this[int i]
        {
            get
            {
                if (i < this.paginas.Count())
                {
                    return this.paginas[i];
                }
                else
                {
                    return string.Empty;
                }

            }
            set
            {
                if (i < this.paginas.Count())
                {
                    this.paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }

    }
}
