using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public abstract class Sobreescrito
    {
        #region atributos

        protected string miAtributo;


        #endregion
        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad { get; }
        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi metodo sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
