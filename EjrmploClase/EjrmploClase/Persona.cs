using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploClase
{
    public class Persona
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformaEstado;

        //Creo el delegado al misma nivel de la clase 
        //Lo uso solo en fomrulrio
        //Le pertenece a la clase                                                 
        public static event DelegadoCajero InformaCajero;

        public enum EEstado
        {
            Ingresado,
            Cobrado,
            Atentido
        }

        public Persona()
        {
                
        }

        public List<Factura> facturas;
        private string codigoPersona;
        private EEstado estado;
        private float montoTotal;

        public Persona(string codigoPersona)
        {
            facturas = new List<Factura>();
            this.codigoPersona = codigoPersona;
            this.estado = EEstado.Ingresado;
        }

        public List<Factura> Facturas
        {
            get
            {
                return this.facturas;
            }
            set
            {
                facturas = value;
            }
        }
        public string CodigoPersona
        {
            get
            {
                return this.codigoPersona;
            }
            set
            {
                this.codigoPersona = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public float MontoTotal
        {
            get
            {
                return this.montoTotal;
            }
            set
            {
                montoTotal = value;
            }
        }


        public override string ToString()
        {
            return $"Codigo:{codigoPersona}";
        }

        public static Persona HardcodearPersonas()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            Persona persona = new Persona(random.Next().ToString());
            for (int i = 0; i < random.Next(1,10); i++)
            {
                Factura factura = new Factura(random.Next(1000, 10000) / 100, random.Next());
                persona.facturas.Add(factura);
            }

            Thread.Sleep(100);
            return persona;
        }


        public void MockCicloCajero()
        {
            while(this.estado != EEstado.Atentido)
            {
                switch (this.estado)
                {
                    case EEstado.Ingresado:
                        Thread.Sleep(2000);
                        this.estado = EEstado.Cobrado;
                        this.InformaEstado(this, EventArgs.Empty);
                        break;
                    case EEstado.Cobrado:
                        Thread.Sleep(2000);
                        this.estado = EEstado.Atentido;
                        this.InformaEstado(this, EventArgs.Empty);
                        break;
                    default:
                        break;
                }
            }
            try
            {
                InformaCajero.Invoke(this);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}