using INSS.Model;

namespace INSS.Tabelas
{
    /// <summary>
    /// Define a tabela de INSS do ano 2011.
    /// </summary>
    internal class Tabela2011 : TabelaBase
    {
        public Tabela2011()
        {
            Ano = 2011;

            NiveisSalariais.Add(new NivelSalarial(1106.90M, Aliquotas.OitoPorcento));
            NiveisSalariais.Add(new NivelSalarial(1106.91M, 1844.43M, Aliquotas.NovePorcento));
            NiveisSalariais.Add(new NivelSalarial(1844.84M, 3689.66M, Aliquotas.OnzePorcento));

            Teto = 405.86M;
        }
    }
}