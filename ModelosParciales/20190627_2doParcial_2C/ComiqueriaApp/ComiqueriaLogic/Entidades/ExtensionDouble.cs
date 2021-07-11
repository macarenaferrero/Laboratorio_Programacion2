using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class ExtensionDouble
    {
        public static string FormatearPrecio(this Double formateo)
        {
            return $"${Math.Round(formateo, 2)}";
        }
    }
}
