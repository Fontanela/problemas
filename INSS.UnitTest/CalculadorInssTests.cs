using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.UnitTest
{
    [TestClass]
    public class CalculadorInssTests : CalculadorInssTestsBase
    {
        [TestMethod]
        public void SalarioNegativo_RetornaZero()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = -10.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2011, salario);

            // Assert
            Assert.AreEqual(Zero, result);
        }

        [TestMethod]
        public void SalarioZero_RetornaZero()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 0.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2011, salario);

            // Assert
            Assert.AreEqual(Zero, result);
        }

        [TestMethod]
        public void AnoDeTabelaNaoCadastrado_RetornaZero()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 1000.00M;

            //Act
            var desconto = calculadorInss.CalcularDesconto(Data2000, salario);
            //Assert
            Assert.AreEqual(0, desconto);
        }
    }
}