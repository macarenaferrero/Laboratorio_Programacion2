using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_61;

namespace Ejercicio_61.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lautaro", "Galarza");
            Persona persona2 = new Persona("Esteban", "Prieto");
            Persona persona3 = new Persona("Macarena", "Ferrero");
            Persona persona4 = new Persona("Agustin", "Pose");
            Persona persona5 = new Persona("Facundo", "Leguizamos");

            //PersonaDAO.Guardar(persona1);
            //PersonaDAO.Guardar(persona2);
            //PersonaDAO.Guardar(persona3);
            //PersonaDAO.Guardar(persona4);
            //PersonaDAO.Guardar(persona5);

            //Persona persona6 = PersonaDAO.LeerPorId(3);
            //Console.WriteLine(persona6.ToString());

            //List<Persona> personas = PersonaDAO.Leer();

            //foreach (Persona item in personas)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Persona personaModificada = new Persona(3, "Loana", "Ferrero");

            PersonaDAO.Modificar(personaModificada);





        }
    }
}
