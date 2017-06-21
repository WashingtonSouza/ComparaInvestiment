using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    class Investimento : Conta, ITributavel
    {
        public double valorComIR;

        public override void CalculaInvestimento()
        {
            Console.WriteLine("\n");
            Console.WriteLine("==============================================================================\n");

            base.CalculaInvestimento();
            Console.WriteLine("O investimento Total da aplicação Renda Fixa sem IR é: {0}", this.valorTotal);

            CalculaIR();
            Console.WriteLine("O investimento Total da aplicação Renda Fixa com IR é: {0} \n", valorComIR);

            Console.WriteLine("==============================================================================\n");
        }

        public void CalculaIR()
        {
            valorComIR = Tributos.CalculaIR(this);
        }
    }
}
