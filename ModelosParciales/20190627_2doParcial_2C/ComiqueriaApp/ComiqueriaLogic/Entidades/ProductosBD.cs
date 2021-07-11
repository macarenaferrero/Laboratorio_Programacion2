using AccesoComiqueria;
using ComiqueriaLogic.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComiqueriaLogic
{
    public class ProductosBD : DatabaseConnection
    {
        public delegate void ProductoDBDelegate(AccionesDB accion);
        public static event ProductoDBDelegate ProductoBDCambiado;

        public static void Insert(string descripcion, double precio, int stock)
        {
            ProductosBD.Comando.CommandText = "INSERT INTO dbo.Productos (descripcion, precio, stock) VALUES (@descripcion, @precio, @stock);";
            ProductosBD.Comando.Parameters.Clear();
            ProductosBD.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosBD.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosBD.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosBD.Ejecutar();
            ProductoBDCambiado.Invoke(AccionesDB.Insert);
        }

        public static void Update(int codigo, double nuevoPrecio)
        {
            ProductosBD.Comando.CommandText = "UPDATE dbo.Productos SET precio = @nuevoPrecio WHERE codigo = @codigo";
            ProductosBD.Comando.Parameters.Clear();
            ProductosBD.Comando.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
            ProductosBD.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosBD.Ejecutar();
            ProductoBDCambiado.Invoke(AccionesDB.Insert);
        }

        public static void Delete(int codigo)
        {
            ProductosBD.Comando.CommandText = "DELETE FROM dbo.Productos WHERE codigo = @codigo";
            ProductosBD.Comando.Parameters.Clear();
            ProductosBD.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosBD.Ejecutar();
            ProductoBDCambiado.Invoke(AccionesDB.Insert);
        }

        public static List<Producto> SelectAll()
        {
            List<Producto> productosList = new List<Producto>();

            try
            {
                ProductosBD.Comando.CommandText = "SELECT * FROM dbo.Productos";

                ProductosBD.Conexion.Open();
                SqlDataReader sqlReader = ProductosBD.Comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int codigo = Convert.ToInt32(sqlReader["codigo"]);
                    string descripcion = sqlReader["descripcion"].ToString();
                    double precio = Convert.ToDouble(sqlReader["precio"]);
                    int stock = Convert.ToInt32(sqlReader["stock"]);
                    Producto producto = new Producto(codigo, descripcion, stock, precio);
                    productosList.Add(producto);
                }
            }
            catch (Exception ex)
            {
                throw new ComiqueriaException("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (ProductosBD.Conexion.State == System.Data.ConnectionState.Open)
                {
                    ProductosBD.Conexion.Close();
                }
            }
            return productosList;
        }
    }
}
