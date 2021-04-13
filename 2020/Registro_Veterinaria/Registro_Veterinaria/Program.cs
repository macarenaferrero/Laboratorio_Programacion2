using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota nuevaMascota = new Mascota("perro", "Yuka", DateTime.Now);
            Cliente nuevoCliente = new Cliente("Joel","Ramirez", 42698374,"Canaria 4356");
            Vacuna nuevaVacuna = new Vacuna("Antiparasitario");
            nuevoCliente.AgregarMascota(nuevaMascota);
            nuevaMascota.AgregarVacuna(nuevaVacuna);

            Console.WriteLine(nuevoCliente.MostrarDatos());

            Console.ReadKey();
        }
    }
}
