using EjemploClase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjrmploClase
{
    public class PersonaDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static string cadenaConexion;

        static PersonaDAO()
        {
            cadenaConexion = @"Data Source=DESKTOP-GSTVRRS;Initial Catalog=Master;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection();

        }

        public static bool Insertar(Persona persona)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandType = CommandType.Text;
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }
            return retorno;
        }


    }
}
