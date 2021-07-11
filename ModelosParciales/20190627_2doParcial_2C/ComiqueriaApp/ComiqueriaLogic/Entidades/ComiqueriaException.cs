using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string message, Exception innerException) : base(message, innerException)
        {
            ArchivoTexto.Escribir(this, true);
        }

        public string Ruta
        {
            get
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Exception.txt";
                return ruta;
            }
        }


        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Fecha y hora: {DateTime.Now.ToString()}");
                sb.AppendLine($"{this.Message}");
                Exception excepcion = this.InnerException;
                while (excepcion != null)
                {
                    sb.AppendLine($"{excepcion.Message}");
                    excepcion = excepcion.InnerException;
                }
                return sb.ToString();

            }
        }
    }
}
