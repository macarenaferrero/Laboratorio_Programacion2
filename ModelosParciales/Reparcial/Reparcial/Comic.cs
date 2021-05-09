﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparcial
{
    public class Comic : Publicacion
    {
        private bool esColor;

        public Comic(string nombre, bool esColor,int stock, float valor)
            :base(nombre, stock, valor)
        {
            this.esColor = esColor;
        }

        protected override bool EsColor
        {
            get
            {
                return this.esColor;
            }
        }

    }
}
