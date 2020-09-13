using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

#pragma warning disable CS0660  
#pragma warning disable CS0661

    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            string retorno;
            retorno = this.marca;

            return retorno;
        }

        public float GetPrecio()
        {
            float precio;
            precio = this.precio;

            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Marca: {p.marca}");
            retorno.AppendLine($"Codigo de barras: {p.codigoDeBarra}");
            retorno.AppendLine($"Precio: {p.precio}");

            return retorno.ToString();
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator == (Producto[] listaProd, Producto p2)
        {
            bool retorno = false;

            for (int i = 0; i < listaProd.Length; i++)
            {
                if (listaProd[i] != null && listaProd[i].GetMarca() == p2.GetMarca() && listaProd[i].codigoDeBarra == p2.codigoDeBarra)

                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator != (Producto[] listaProd, Producto p2)
        {
           return !(listaProd == p2);
        }

        public static bool operator == (Producto p, string marca)
        {

        }
    }
}
