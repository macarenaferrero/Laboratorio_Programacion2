using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int telefono;
        private string direccion;
        private Mascota[] mascota;

        public Cliente(string nombre, string apellido, int telefono, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
           // this.mascota = new Mascota[15];

        }

        public void AgregarMascota(Mascota mascota)
        {
            if (this.mascota is null)
            {
                this.mascota = new Mascota[1];
            }
            else
            {
                int newSize = this.mascota.Length + 1;
                Array.Resize(ref this.mascota, newSize);
            }

            for (int i = 0; i < this.mascota.Length; i++)
            {
                if (this.mascota[i] is null)
                {
                    this.mascota[i] = mascota;
                    break;
                }
            }
        }

        public string MostrarDatos()
        {
            string retorno = $"Nombre: {this.nombre}, Apellido: {this.apellido}, Telefono: {this.telefono}, Direccion {this.direccion}\n";

            if (this.mascota != null)
            {
                retorno += "Mascotas: \n";
                foreach (Mascota mascota in this.mascota)
                {
                    if (mascota != null)
                    {
                        retorno += mascota.MostrarDatos();
                    }
                }
            }

            return retorno;
        }
    }
}
