﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IDatos
    {
        void Guardar(string texto);
        string Leer(string texto);
    }
}
