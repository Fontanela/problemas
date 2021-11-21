using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.UnitTest
{
    [TestClass]
    public class CalculadorInssTests2012 : CalculadorInssTestsBase
    {
        [TestMethod]
        public void SalarioPrimeiroNivelEm2012_Retorna7PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 1000.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2012, salario);

            // Assert
            Assert.AreEqual(SetePorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioSegundoNivelEm2012_Retorna8PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 1000.01M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2012, salario);

            // Assert
            Assert.AreEqual(OitoPorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioTerceiroNivelEm2012_Retorna9PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 1500.01M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2012, salario);

            // Assert
            Assert.AreEqual(NovePorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioQuartoNivelEm2012_Retorna11PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 3000.01M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2012, salario);

            // Assert
            Assert.AreEqual(OnzePorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioMaiorQueTodosNiveisEm2012_RetornaTeto()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 4000.01M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2012, salario);

            // Assert
            Assert.AreEqual(Teto2012, Arrendondar(result));
        }
    }
}