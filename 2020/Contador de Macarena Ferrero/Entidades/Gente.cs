using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gente : Persona
    {
        #region Constructor

        public Gente(short edad)
        {
            this.Edad = edad;
        }
        #endregion

        #region
        static bool Validar(Gente gente1)
        {
            bool retorno = false;
            if(gente1.Edad > 18)
            {
                retorno = true;
            }

            return retorno;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("GENTE");
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }
        #endregion
    }
}
