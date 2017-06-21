using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    class ContaPoupanca : Conta
    {
        public double JurosPoup = 0.5;

        public override void CalculaInvestimento()
        {
            Console.WriteLine("\n");

            taxaJuros = JurosPoup;

            base.CalculaInvestimento();

            Console.WriteLine("O investimento Total da aplicação na Conta Poupança é: {0} \n", valorTotal);
            Console.WriteLine("==============================================================================\n");
        }
    }
}
