using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClases;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test01_Validar_Lista_Se_Instancia_Al_Crear_Objeto()
        {
            //Arrange
            Competencia motoRace = new Competencia(2, 2, Competencia.TipoCompetencia.F1);
            //Act

            //Assert
            Assert.IsNotNull(motoRace.Competidores);
        }


        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Test02_Lanzar_Excepcion_Al_Cargar_Auto_En_Competencia_MotoCross()
        {
            //Arrange
            AutoF1 laMasRapida = new AutoF1(123, "laMaca");
            Competencia motoRace = new Competencia(1, 2, Competencia.TipoCompetencia.MotoCross);
            //Act
            bool agregarCompetencia = motoRace + laMasRapida;
            //Assert
        }

        [TestMethod]
        public void Test03_Comprobar_Vehiculo_En_Competencia()
        {
            //Arrange
            AutoF1 laMasRapida = new AutoF1(123, "laMaca");
            AutoF1 laMasMasRapida = new AutoF1(123, "laMaca");

            Competencia raceAuto = new Competencia(1, 2, Competencia.TipoCompetencia.F1);
            //Act
            bool agregarCompetencia = raceAuto + laMasRapida;
            bool vehiculosIguales = laMasMasRapida == laMasRapida;
            bool agregarOtroACompetencia = raceAuto + laMasMasRapida;
            //Assert
            Assert.IsTrue(agregarCompetencia);
            Assert.IsTrue(vehiculosIguales);
            Assert.IsFalse(agregarOtroACompetencia);
        }

        [TestMethod]
        public void Test04_Verificar_Que_Al_Quitar_Carrera_No_Esta_En_Lista()
        {
            // Arrange
            AutoF1 laMasMasRapida = new AutoF1(123, "laMaca");

            Competencia raceAuto = new Competencia(1, 2, Competencia.TipoCompetencia.F1);
            //Act
            bool agregar = raceAuto + laMasMasRapida;
            bool sacar = raceAuto - laMasMasRapida;

            //Assert
            Assert.IsTrue(agregar);
            Assert.IsTrue(sacar);
            Assert.IsFalse(raceAuto == laMasMasRapida);

        }
    }
}
