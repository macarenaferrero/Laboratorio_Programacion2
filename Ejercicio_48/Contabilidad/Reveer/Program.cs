using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contabilidad;

namespace Reveer
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creamos tipo generico
            Contabilidad <Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Recibo cualEs = new Recibo();
            Factura aquiEstoy = new Factura(1);
            Recibo cualEs2 = new Recibo(1);
            Factura aquiEstoy2 = new Factura(2);

            

            contabilidad += aquiEstoy;
            contabilidad += aquiEstoy2;
            contabilidad += cualEs;
            contabilidad += cualEs2;

            Console.WriteLine(contabilidad.ToString());
            Console.ReadKey();
        }
    }
}
