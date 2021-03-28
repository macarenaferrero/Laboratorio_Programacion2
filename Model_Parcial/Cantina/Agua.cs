using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(string marca, int contenidoML, int capacidadML)
            : base(marca, capacidadML, contenidoML)
        {
        }

        public override int ServirMedida(int medida)
        {
            int descuento = medida;

            if(medida <= base.Contenido)
            {
                descuento = 0;
            }
            else if(medida > base.Contenido)
            {
                descuento = medida - base.Contenido;
            }

            return descuento;
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }

        public override string GenerarInforme()
        {
            return base.GenerarInforme();
        }
        
    }
}
