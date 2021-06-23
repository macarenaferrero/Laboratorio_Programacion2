using System;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        public static bool Guardar(string rutaArchivo, string dataAGuardar)
        {
            bool retorno = false;
            try
            {
                if (!String.IsNullOrEmpty(rutaArchivo) && !String.IsNullOrEmpty(dataAGuardar))
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        writer.Write("El archivo se guardo");
                        retorno = true;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            return retorno;
        }



        public static string Leer(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    return reader.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }

}
