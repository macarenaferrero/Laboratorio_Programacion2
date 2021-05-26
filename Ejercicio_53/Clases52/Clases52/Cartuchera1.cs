using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases52
{
    public class Cartuchera1
    {
        public List<IAcciones> listado;

        public Cartuchera1()
        {
            listado = new List<IAcciones>();
        }

        public static bool operator +(Cartuchera1 cartuchera, IAcciones elemento)
        {
            if(cartuchera != null && elemento != null)
            {
                cartuchera.listado.Add(elemento);
                return true;
            }
            return false;
        }

        public bool ProbarElementos()
        {
            foreach (IAcciones item in this.listado)
            {
                if (listado != null)
                {
                    if (item.UnidadesDeEscritura < 0)
                    {
                        return false;
                    }
                    else
                    {
                        item.Escribir("M");
                        item.Recargar(1);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
