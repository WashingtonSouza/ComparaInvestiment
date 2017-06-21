using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    public class Conta
    {
        public double valorInvestimento;
        public int qtdMes;
        public double taxaJuros;
        public double valorTotal;
        private double jurosMensal;
        
        public virtual void CalculaInvestimento()
        {
            valorTotal = valorInvestimento;

            for (int i = 1; i <= qtdMes; i++)
            {
                jurosMensal = (valorTotal * taxaJuros) / 100;

                var dataAtual = DateTime.Now;

                Console.WriteLine("No mês {0} o rendimento será de {1}", new DateTime(dataAtual.Year, i, dataAtual.Day).ToString("MMM"), jurosMensal.ToString("0.##"));

                valorTotal += Convert.ToDouble(jurosMensal.ToString("0.##"));
            }
        }

        public void PreencherConta(Conta conta)
        {
            valorInvestimento = conta.valorInvestimento;
            qtdMes = conta.qtdMes;
            taxaJuros = conta.taxaJuros;
            valorTotal = conta.valorTotal;
        }
    }
}
