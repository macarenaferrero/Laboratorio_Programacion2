using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComiqueriaLogic;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test01_Actualizar_Lista_Productos()
        {
            //Arrange
            Comiqueria comiqueria = new Comiqueria();

            //Act

            //Assert
            Assert.IsNotNull(comiqueria.Productos);
        }
    }
}
