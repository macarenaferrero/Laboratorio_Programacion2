using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;
using System.Data.SqlClient;
using ComiqueriaLogic.Entidades;

namespace AccesoComiqueria
{
    public abstract class DatabaseConnection
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        protected static AccionesDB ultimaAccion;

        static DatabaseConnection()
        {
            DatabaseConnection.conexion = new SqlConnection(@"Server=DESKTOP-GSTVRRS;Database=Comiqueria;Trusted_Connection=True;");
            DatabaseConnection.comando = new SqlCommand();
            DatabaseConnection.comando.Connection = DatabaseConnection.conexion;
        }

        protected static SqlConnection Conexion
        {
            get
            {
                return DatabaseConnection.conexion;
            }
        }

        protected static SqlCommand Comando
        {
            get
            {
                return DatabaseConnection.comando;
            }
        }

        protected static void Ejecutar()
        {
            try
            {
                DatabaseConnection.Conexion.Open();
                DatabaseConnection.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ComiqueriaException("Ocurrió un error en la base de datos.", ex);
            }
            finally
            {
                if (DatabaseConnection.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DatabaseConnection.Conexion.Close();
                }
            }
        }
    }
}