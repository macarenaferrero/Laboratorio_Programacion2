using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases52
{
    public class Cartuchera2
    {
        public List<Boligrafo> listaBoligrafos;
        public List<Lapiz> listaLapices;

        public Cartuchera2()
        {
            listaBoligrafos = new List<Boligrafo>();
            listaLapices = new List<Lapiz>();
        }

        public static bool operator +(Cartuchera2 cartuchera, IAcciones elemento)
        {
            if (cartuchera != null && elemento != null)
            {
                if (elemento is Boligrafo)
                {
                    cartuchera.listaBoligrafos.Add((Boligrafo)elemento);
                    return true;
                }
                else if (elemento is Lapiz)
                {
                    cartuchera.listaLapices.Add((Lapiz)elemento);
                    return true;
                }
            }
            return false;
        }

        public bool ProbarElementos()
        {
            bool retornoLapiz = false;
            bool retornoBoligrafo = false;

            foreach (Boligrafo item in listaBoligrafos)
            {


                if (listaBoligrafos != null)
                {

                    if (item.UnidadesDeEscritura < 0)
                    {
                        retornoBoligrafo = false;
                    }
                    else
                    {
                        item.Escribir("M");
                        item.Recargar(1);
                        retornoBoligrafo = true;
                    }
                }
            }
            foreach (Lapiz item in listaLapices)
            {
                if (listaLapices != null)
                {
                    if (item.UnidadesDeEscritura < 0)
                    {
                        retornoLapiz = false;
                    }
                    else
                    {
                        item.Escribir("M");
                        item.Recargar(1);
                        retornoLapiz = true;
                    }
                }
            }
            return retornoBoligrafo && retornoLapiz;
        }

    }
}
