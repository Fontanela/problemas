using INSS.Model;
using System.Collections.Generic;

namespace INSS.Tabelas
{
    /// <summary>
    /// Define a tabela base de INSS.
    /// </summary>
    internal abstract class TabelaBase
    {
        internal int Ano { get; set; }
        protected decimal Teto { get; set; }
        protected IList<NivelSalarial> NiveisSalariais { get; private set; }

        public TabelaBase()
        {
            NiveisSalariais = new List<NivelSalarial>();
        }

        /// <summary>
        /// Encontra o  nível pertencente ao salário especificado e aplica o desconto no salário.
        /// </summary>
        /// <param name="salario">Salario utilizado para o calculo.</param>
        /// <returns>Valor a ser descontado.</returns>
        public decimal CalcularDesconto(decimal salario)
        {
            if (salario <= decimal.Zero)
            {
                return decimal.Zero;
            }

            foreach (var nivelSalarial in NiveisSalariais)
            {
                if (nivelSalarial.SalarioPertenceAoNivel(salario))
                    return nivelSalarial.AplicarAliquota(salario);
            }

            return Teto;
        }
    }
}