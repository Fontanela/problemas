using INSS.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS
{
    public class CalculadorInss : ICalculadorInss
    {
        private IList<TabelaBase> tabelas;

        public CalculadorInss()
        {
            tabelas = new List<TabelaBase>();
            tabelas.Add(new Tabela2011());
            tabelas.Add(new Tabela2012());
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            List<TabelaBase> tabela = tabelas.Where(x => x.Ano == data.Year).ToList();

            return tabela.Count > 0 ? tabela[0].CalcularDesconto(salario) : decimal.Zero;
        }
    }
}