using INSS.Model;

namespace INSS.Tabelas
{
    /// <summary>
    /// Define a tabela de INSS do ano 2012.
    /// </summary>
    internal class Tabela2012 : TabelaBase
    {
        public Tabela2012()
        {
            Ano = 2012;

            NiveisSalariais.Add(new NivelSalarial(1000.00M, Aliquotas.SetePorcento));
            NiveisSalariais.Add(new NivelSalarial(1000.01M, 1500.00M, Aliquotas.OitoPorcento));
            NiveisSalariais.Add(new NivelSalarial(1500.01M, 3000.00M, Aliquotas.NovePorcento));
            NiveisSalariais.Add(new NivelSalarial(3000.01M, 4000.00M, Aliquotas.OnzePorcento));

            Teto = 500.00M;
        }
    }
}