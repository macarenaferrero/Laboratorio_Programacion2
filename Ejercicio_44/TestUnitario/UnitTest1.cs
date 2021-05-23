using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test01_Validar_Lista_Instanciada()
        {
            //Arrange (Para instanciar lo que hay que probar)
            Centralita auxTest = new Centralita("FacuPower");

            //Act (Llamar metodo a probar y que arroje valor)

            //Assert (Validacion)
            Assert.IsNotNull(auxTest.Llamadas);
            //Assert.AreNotEqual(null, auxTest.Llamadas);
            
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Test02_Lanzar_Exception_Al_Realizar_Llamada_Existente_Local()
        {
            //Arrange
            Centralita auxTest = new Centralita("FacuPower");
            Local llamada1 = new Local(0.5f, "123", "456", 3);
            Local llamada2 = new Local(0.5f, "123", "456", 3);

            //Act
            auxTest += llamada1;
            auxTest += llamada2;

            //Assert
        }


        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void Test03_Lanzar_Exception_Al_Realizar_Llamada_Existente_Provincial()
        {
            //Arrange
            Centralita auxTest = new Centralita("FacuPower");
            Provincial llamada1 = new Provincial ("123", Provincial.Franja.Franja_1 ,0.5f, "456");
            Provincial llamada2 = new Provincial("123", Provincial.Franja.Franja_2, 0.6f, "456");

            //Act
            auxTest += llamada1;
            auxTest += llamada2;

            //Assert
        }

        [TestMethod]
        public void Test04_Validar_Igual_Solo_Entre_Llamadas_Del_Mismo_Tipo()
        {
            //Arrange
            Provincial llamada1 = new Provincial("123", Provincial.Franja.Franja_1, 0.5f, "456");
            Provincial llamada2 = new Provincial("123", Provincial.Franja.Franja_2, 0.6f, "456");
            Local llamada3 = new Local(0.5f, "456", "123", 3);
            Local llamada4 = new Local(0.5f, "456", "123", 3);
            //Act

            //Asert
            Assert.AreEqual(llamada1, llamada2);
            Assert.AreEqual(llamada3, llamada4);
            Assert.AreNotEqual(llamada1, llamada4);
            Assert.AreNotEqual(llamada2, llamada3);
            Assert.AreNotEqual(llamada2, llamada4);
            Assert.AreNotEqual(llamada2, llamada3);
        }

    }
}
