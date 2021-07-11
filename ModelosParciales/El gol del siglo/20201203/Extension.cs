using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201203
{
    public static class Extension
    {
        public static string UltimoCaracter(this PictureBox picture)
        {
            return picture.Name.Substring(picture.Name.Length - 1);
        }
    }
}
