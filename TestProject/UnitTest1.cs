using Moq;
using PruebaTDD;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SuperTesteableMethod_CuandoSeDivideEntreCero_LanzaExcepcion()
        {
            // Arrange
            var mockNotSoAwesomeClass = new Mock<INotSoAwesomeClass>();
            mockNotSoAwesomeClass.Setup(x => x.GiveMeANumber()).Returns(0);

            var superAwesomeClass = new SuperAwesomeClass(mockNotSoAwesomeClass.Object, 10);

            // Act
            Action accion = () => superAwesomeClass.SuperTesteableMethod();

            // Assert
            Assert.ThrowsException<ArithmeticException>(accion);
        }

        [TestMethod]
        public void SuperTesteableMethod_CuandoElNumeroEsNegativo_DevuelveMyNumber()
        {
            // Arrange
            var mockNotSoAwesomeClass = new Mock<INotSoAwesomeClass>();
            mockNotSoAwesomeClass.Setup(x => x.GiveMeANumber()).Returns(-5);

            var superAwesomeClass = new SuperAwesomeClass(mockNotSoAwesomeClass.Object, 10);

            // Act
            var resultado = superAwesomeClass.SuperTesteableMethod();

            // Assert
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void SuperTesteableMethod_CuandoElNumeroEsPositivo_DevuelveLaDivision()
        {
            // Arrange
            var mockNotSoAwesomeClass = new Mock<INotSoAwesomeClass>();
            mockNotSoAwesomeClass.Setup(x => x.GiveMeANumber()).Returns(5);

            var superAwesomeClass = new SuperAwesomeClass(mockNotSoAwesomeClass.Object, 10);

            // Act
            var resultado = superAwesomeClass.SuperTesteableMethod();

            // Assert
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void AnotherSuperTesteableMethod_CuandoLaCadenaEsCorrecta_DevuelveTrue()
        {
            // Arrange
            var mockNotSoAwesomeClass = new Mock<INotSoAwesomeClass>();
            mockNotSoAwesomeClass.Setup(x => x.GiveMeAString()).Returns("control text");

            var superAwesomeClass = new SuperAwesomeClass(mockNotSoAwesomeClass.Object, 10);

            // Act
            var resultado = superAwesomeClass.AnotherSuperTesteableMethod();

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void AnotherSuperTesteableMethod_CuandoLaCadenaEsIncorrecta_DevuelveFalse()
        {
            // Arrange
            var mockNotSoAwesomeClass = new Mock<INotSoAwesomeClass>();
            mockNotSoAwesomeClass.Setup(x => x.GiveMeAString()).Returns("texto incorrecto");

            var superAwesomeClass = new SuperAwesomeClass(mockNotSoAwesomeClass.Object, 10);

            // Act
            var resultado = superAwesomeClass.AnotherSuperTesteableMethod();

            // Assert
            Assert.IsFalse(resultado);
        }
    }
}