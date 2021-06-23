namespace EjemploClase
{
    public class Factura
    {
        private float precio;
        private int numero;

        public Factura()
        {

        }
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public Factura(float precio, int numero)
        {
            this.precio = precio;
            this.numero = numero;
        }
    }
}