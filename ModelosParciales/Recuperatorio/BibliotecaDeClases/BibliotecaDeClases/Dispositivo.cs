using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static ESistemaOperativo sistemaOp;

        /// <summary>
        /// Constructor estatico que no recibe parametros, instancia la clase e inicializa el sistema op en ANDROID
        /// </summary>
        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOp = ESistemaOperativo.ANDROID;
        }

        /// <summary>
        /// Metodo que devuelve un string con la informacion del Dispositivo
        /// </summary>
        /// <returns></returns>
        public static string InformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            if (!(appsInstaladas is null))
            {
                foreach (Aplicacion item in appsInstaladas)
                {
                        sb.AppendLine($"Sistema operativo: {sistemaOp.ToString()}");
                        sb.AppendLine($"{item.InfoApp()}");                    
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Metodo que devuelve true si pudo instalar la app o false si no pudo
        /// </summary>
        /// <param name="app">Tipo Aplicacion a instalar</param>
        /// <returns></returns>
        public static bool InstalarApp(Aplicacion app)
        {
            bool retorno = false;
            if (!(app is null) && appsInstaladas != app && app.SistemaOperativo == sistemaOp)
            {
                retorno = appsInstaladas + app;
            }
            return retorno;
        }


    }
}
