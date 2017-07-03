using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    class Investimento : Conta
    {
        public double ValorComIR { get; set; }
         
        public override void CalculaInvestimento()
        {
            base.CalculaInvestimento();

            CalculaIR();    
        }

        public void CalculaIR()
        {
            double ValorComIR = 0;

            var imp = ValorTotal - ValorInvestimento;

            if ( QuantidadeMes > 0 &&  QuantidadeMes <= 12)
            {
                this.ValorComIR = ValorTotal - Convert.ToDouble((imp * 0.25).ToString("0.##"));
            }
            else if (QuantidadeMes > 12 && QuantidadeMes <= 24)
            {
                ValorComIR = ValorTotal - Convert.ToDouble((imp * 0.15).ToString("0.##"));
            }
            else if (QuantidadeMes > 24 && QuantidadeMes <= 36)
            {
                ValorComIR = ValorTotal - Convert.ToDouble((imp * 0.05).ToString("0.##"));
            }
            else
                ValorComIR = ValorTotal - Convert.ToDouble((imp * 0.01).ToString("0.##"));
        }
    }
}
