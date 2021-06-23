using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_61
{
    public class PersonaDAO
    {

        private static string cadenaConexion = @"Data Source=DESKTOP-GSTVRRS;Initial Catalog=Master;Integrated Security=True";

        public static void Guardar(Persona persona)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    //Abrir conexion
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;

                    //Armar consulta parametrizada
                    comando.CommandText = "INSERT INTO Personas (Nombre, Apellido) VALUES (@nombre, @apellido)";
                    comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                    comando.Parameters.AddWithValue("@apellido", persona.Apellido);

                    //Ejecutarla
                    comando.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public static Persona LeerPorId(int id)
        {
            Persona persona = null;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    //Abrir conexion
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;

                    //Armar consulta parametrizada
                    comando.CommandText = $"SELECT * FROM Personas WHERE ID = {id}";

                    SqlDataReader dataReader = comando.ExecuteReader();

                    //Mientras haya para leer instancia personas
                    if (dataReader.Read())
                    {
                        persona = new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString());
                    }
                    dataReader.Close();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return persona;
        }


        public static List<Persona> Leer()
        {
            List<Persona> persona = new List<Persona>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    //Abrir conexion
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;

                    //Armar consulta parametrizada
                    comando.CommandText = $"SELECT * FROM Personas";
                    SqlDataReader dataReader = comando.ExecuteReader();

                    //Mientras haya para leer instancia personas
                    while (dataReader.Read())
                    {
                        persona.Add(new Persona(Convert.ToInt32(dataReader["ID"]), dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString()));
                    }
                    dataReader.Close();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return persona;

        }


        public static void Eliminar(Persona persona)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    //Abrir conexion
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;

                    //Armar consulta parametrizada
                    comando.CommandText = $"DELETE Persona WHERE ID ={persona.Id}";//DELETE FROM PERSONA

                    //Solo corre la consulta
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public static void Modificar(Persona persona)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
                {
                    //Abrir conexion
                    sqlConnection.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = sqlConnection;
                    comando.CommandType = CommandType.Text;

                    //Armar consulta parametrizada
                    comando.CommandText = $"UPDATE Personas SET Nombre = @nombre, Apellido = @apellido WHERE ID = {persona.Id}";
                    comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                    comando.Parameters.AddWithValue("@apellido", persona.Apellido);

                    //Ejecutarla
                    comando.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
