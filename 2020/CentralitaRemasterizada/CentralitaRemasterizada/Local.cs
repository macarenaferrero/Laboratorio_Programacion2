using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaRemasterizada
{
    public class Local : Llamada
    {
        protected float costo;

        public float Costo
        {
            get
            {
                return this.costo;
            }
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        //Terminar











    }
}
