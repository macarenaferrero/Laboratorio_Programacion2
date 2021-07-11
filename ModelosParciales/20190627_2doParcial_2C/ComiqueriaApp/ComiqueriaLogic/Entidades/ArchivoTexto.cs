using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class ArchivoTexto
    {
        public static void Escribir(IArchivoTexto objeto, bool append)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(objeto.Ruta, append, Encoding.UTF8);
                sw.Write(objeto.Texto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(sw != null)
                {
                    sw.Close();
                }
            }
        }

        public static string Leer(string ruta)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(ruta);
                return sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
