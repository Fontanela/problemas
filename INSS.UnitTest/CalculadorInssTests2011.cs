using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace INSS.UnitTest
{
    [TestClass]
    public class CalculadorInssTests2011 : CalculadorInssTestsBase
    {
        [TestMethod]
        public void SalarioPrimeiroNivelEm2011_Retorna8PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 1000.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2011, salario);

            // Assert
            Assert.AreEqual(OitoPorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioSegundoNivelEm2011_Retorna9PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 1500.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2011, salario);

            // Assert
            Assert.AreEqual(NovePorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioTerceiroNivelEm2011_Retorna11PorCento()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 2000.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2011, salario);

            // Assert
            Assert.AreEqual(OnzePorcento, Arrendondar(result / salario));
        }

        [TestMethod]
        public void SalarioMaiorQueTodosNiveisEm2011_RetornaTeto()
        {
            // Arrange
            var calculadorInss = new CalculadorInss();
            var salario = 4000.00M;

            // Act
            var result = calculadorInss.CalcularDesconto(Data2011, salario);

            // Assert
            Assert.AreEqual(Teto2011, Arrendondar(result));
        }
    }
}