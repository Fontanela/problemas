using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace INSS.UnitTest
{
    [TestClass]
    public class CalculadorInssTestsBase
    {
        internal const decimal Zero = 0.00M;
        internal const decimal SetePorcento = 0.07M;
        internal const decimal OitoPorcento = 0.08M;
        internal const decimal NovePorcento = 0.09M;
        internal const decimal OnzePorcento = 0.11M;
        internal const decimal Teto2011 = 405.86M;
        internal const decimal Teto2012 = 500.00M;
        internal DateTime Data2000 = new DateTime(2000, 01, 01);
        internal DateTime Data2011 = new DateTime(2011, 01, 01);
        internal DateTime Data2012 = new DateTime(2012, 01, 01);

        [TestMethod]
        internal decimal Arrendondar(decimal valor)
        {
            return Math.Round(valor, 2);
        }
    }
}