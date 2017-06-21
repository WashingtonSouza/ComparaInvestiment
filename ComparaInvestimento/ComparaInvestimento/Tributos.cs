using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    class Tributos
    {
        public static double CalculaIR(Conta conta)
        {
            double valorComIR = 0;

            var imp = conta.valorTotal - conta.valorInvestimento;

            if (conta.qtdMes > 0 && conta.qtdMes <= 12)
            {
                valorComIR = conta.valorTotal - Convert.ToDouble((imp * 0.24).ToString("0.##"));
            }
            else if (conta.qtdMes > 12 && conta.qtdMes <= 24)
            {
                valorComIR = conta.valorTotal - Convert.ToDouble((imp * 0.15).ToString("0.##"));
            }
            else if (conta.qtdMes > 24 && conta.qtdMes <= 36)
            {
                valorComIR = conta.valorTotal - Convert.ToDouble((imp * 0.05).ToString("0.##"));
            }
            else
                valorComIR = conta.valorTotal - Convert.ToDouble((imp * 0.01).ToString("0.##"));

            return valorComIR;
        }

    }
}
