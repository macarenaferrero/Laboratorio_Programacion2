﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pera : Ingrediente
    {
        private string tipo;

        public Pera(string descripcion, int cantidad, string tipo) : base(descripcion, cantidad)
        {
            this.tipo = tipo;
        }

        public override string Proceso
        {
            get
            {
                return "cubitar";
            }
        }

        public override string UnidadDeMedida
        {
            get 
            {
                return "Unidades";
            }
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Informacion());
            sb.AppendLine(String.Format("Tipo: {0}", this.tipo));

            return sb.ToString();
        }

    }
}
