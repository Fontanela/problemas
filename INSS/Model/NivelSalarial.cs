using System;

namespace INSS.Model
{
    /// <summary>
    /// Define o nível salarial da tabela de INSS.
    /// </summary>
    internal class NivelSalarial
    {
        internal decimal valorInicial;
        internal decimal valorFinal;
        private decimal aliquota;

        internal NivelSalarial(decimal valor, decimal aliquota) : this(decimal.Zero, valor, aliquota) { } //Caso seja o primeiro nível

        internal NivelSalarial(decimal valorInicial, decimal valorFinal, decimal aliquota)
        {
            this.valorInicial = valorInicial;
            this.valorFinal = valorFinal;
            this.aliquota = aliquota;
        }

        /// <summary>
        /// Aplica a alíquota no salário.
        /// </summary>
        /// <returns>Valor a ser descontado, arredondado.</returns>
        internal decimal AplicarAliquota(decimal salario)
        {
            return Arrendondar(salario * aliquota);
        }

        /// <summary>
        /// Arredonda o valor recebido com duas casas decimais.
        /// </summary>
        /// <returns>Valor arredondado.</returns>
        private decimal Arrendondar(decimal valor)
        {
            return Math.Round(valor, 2);
        }

        /// <summary>
        /// Checa se o salário pertence ao nível salarial.
        /// </summary>
        internal bool SalarioPertenceAoNivel(decimal salario)
        {
            return salario >= valorInicial && salario <= valorFinal;
        }
    }
}
