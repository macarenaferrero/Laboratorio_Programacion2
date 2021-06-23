using EjemploClase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjrmploClase
{
    public class Archivo
    {

        public static bool Guardar(Persona persona)
        {
            bool retorno = false;
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Personas.txt";
                string texto = string.Format($"Cajero cobro a {persona.CodigoPersona} ${persona.MontoTotal}");

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                   
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return retorno;
        }
    }
}
