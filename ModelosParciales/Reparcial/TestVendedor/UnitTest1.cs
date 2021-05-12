using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Libreria;
using Reparcial;

namespace TestVendedor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaInstanciada()
        {
            //Arrange
            Vendedor vendedor = new Vendedor("Macarena");

            //Act


            //Assert

            Assert.IsNotNull(vendedor.Ventas);


        }

        [TestMethod]
        public void AgregarVentas()
        {
            //Arrange
            Vendedor vendedor = new Vendedor("Agustin");
            Biografia biografia = new Biografia("xxx", 2, 79);

            //Act
            bool respuesta = vendedor + biografia;

            //Assert

            Assert.IsTrue(respuesta);
        }
    }
}
