using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test01_MiClase_Sin_Parametros_Lanze_Exception()
        {
            // Arrange
            MiClase auxTest = new MiClase();

            // Act

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void Test02_MiClase_Con_Parametros_Lanze_Exception()
        {
            // Arrange
            MiClase auxTest = new MiClase(35);

            // Act

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test03_MiClase_Metodo_Lanzar_Exception()
        {
            // Arrange
            MiClase.Lanzar();            

            // Act

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void Test04_OtraClase_Metodo_OtroMetodoInstancia_Mi_Exception()
        {
            // Arrange
            OtraClase otraClase = new OtraClase();

            // Act
            otraClase.OtroMetodoInstancia();
            // Assert
        }
    }
}
