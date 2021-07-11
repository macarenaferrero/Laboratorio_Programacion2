using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DAO : IDatos
    {
        public void Guardar(string texto)
        {
            SqlConnection connection = new SqlConnection(@"Server = DESKTOP-GSTVRRS ; Database = 20201203-sp ; Trusted_Connection = true ; ");

            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;

                connection.Open();
                command.CommandText = "INSERT INTO log (entrada, alumno) VALUES (@entrada, @alumno)";
                command.Parameters.AddWithValue("@entrada", texto);
                command.Parameters.AddWithValue("@alumno", "Esteban");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public string Leer(string texto)
        {
            throw new NotImplementedException();
        }
    }
}
