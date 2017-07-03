using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    public class Conta
    {
        public double ValorInvestimento;
        public int QuantidadeMes;
        public double TaxaJuros;
        public double ValorTotal;
        public IList<double> JurosMensal = new List<double>();
        public double Juros;
        
        public virtual void CalculaInvestimento()
        {
            ValorTotal = ValorInvestimento;

            for (int i = 1; i <= QuantidadeMes; i++)
            {
                this.Juros = (ValorTotal * TaxaJuros) / 100;
                JurosMensal.Add(Juros);

                ValorTotal += Convert.ToDouble(Juros.ToString("0.##" ));
            }
        }

        public void PreencherConta(Conta conta)
        {
            ValorInvestimento = conta.ValorInvestimento;
            QuantidadeMes = conta.QuantidadeMes;
            TaxaJuros = conta.TaxaJuros;
            ValorTotal = conta.ValorTotal;
        }
    }
}
