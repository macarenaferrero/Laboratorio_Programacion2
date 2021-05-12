using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraString;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Retorna_0_Cuando_recibe_vacio()
        {
            //Arrange
            Calculadora calcu = new Calculadora();

            //Act
            int respuesta = calcu.Add(string.Empty);

            //Assert
            Assert.AreEqual(0, respuesta);
        }

        [TestMethod]
        public void Retorna_el_mismo_valor_uno_solo()
        {
            //Arrange
            Calculadora calcu = new Calculadora();

            //Act
            int respuesta = calcu.Add("1");

            //Assert
            Assert.AreEqual(1, respuesta);
        }

        [TestMethod]
        public void Retorna_suma_al_recibir_numeros_separador_por_coma()
        {
            //Arrange
            Calculadora calcu = new Calculadora();

            //Act
            int respuesta = calcu.Add("1,2");

            //Assert
            Assert.AreEqual(3, respuesta);
        }
    }
}
