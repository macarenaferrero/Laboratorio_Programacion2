using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Cantina
    {
        private List<Botella> botella;
        private int espaciosTotales;
        private static Cantina singleton;
               
        public List<Botella> Botellas
        {
            get
            {
                return this.botella;
            }
        }

        private Cantina(int espacios)
        {
            this.botella = new List<Botella>(espacios);
            this.espaciosTotales = espacios;
        }

        public static Cantina GetCantina(int espacios)
        {
            if (Cantina.singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espaciosTotales = espacios;
            }
            return Cantina.singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {            
            if (c.espaciosTotales >= c.Botellas.Count())
            {
                c.Botellas.Add(b);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
