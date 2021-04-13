using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

#pragma warning disable CS0660
#pragma warning disable CS0661

    public class Empleado : Persona
    {
        private int dni;
        private string nombre;
        private int edad;

        #region Propiedades
        public int Dni
        {
            get { return this.dni; }
            set { Dni = value; }
        }

        #endregion

        #region Constructores

        public Empleado(string nombre, short edad)
        {
           this.nombre = nombre;
           this.edad = edad;
        }

        public Empleado(string nombre, short edad, int dni)
            : this(nombre, edad)
        {
            this.dni = dni;
        }
        #endregion

        #region Metodos
        public static bool operator ==(Empleado empleado1, Empleado empleado2)
        {
            bool retorno = false;

           if(empleado1.nombre == empleado2.nombre && empleado1.edad == empleado2.edad)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Empleado empleado1, Empleado empleado2)
        {
            return !(empleado1 == empleado2);
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("EMPLEADO");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }

        static bool Validar(Empleado empleado1)
        {
            bool retorno = false;

            if(empleado1.dni > 21 && (empleado1.nombre.Length) >= 2)
            {
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }
}
