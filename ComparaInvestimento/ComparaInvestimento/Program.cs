using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {
            var CP = new ContaPoupanca();
            var RF = new Investimento();
            var C = new Conta();

            Console.WriteLine("Qual o valor que deseja investir? \n");
            C.valorInvestimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a taxa de juros do investimento? \n");
            C.taxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quatos meses deseja investir? \n");
            C.qtdMes = Convert.ToInt32(Console.ReadLine());

            CP.PreencherConta(C);
            RF.PreencherConta(C);

            RF.CalculaInvestimento(); 
            CP.CalculaInvestimento();

            Console.WriteLine("==============================================================================\n");

            Console.WriteLine("O investimento Total da aplicação na Conta Poupança é: {0} \n", CP.valorTotal);
            Console.WriteLine("O investimento Total da aplicação Renda Fixa sem IR é: {0} \n", RF.valorTotal);
            Console.WriteLine("O investimento Total da aplicação Renda Fixa com IR é: {0} \n", RF.valorComIR);

            Console.WriteLine("==============================================================================\n");
            Console.ReadKey();
        }
    }
}
