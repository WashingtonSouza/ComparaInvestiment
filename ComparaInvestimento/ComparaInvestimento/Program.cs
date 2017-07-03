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
            var cp = new ContaPoupanca();
            var rf = new Investimento();
            var c = new Conta();

            Console.WriteLine("Qual o valor que deseja investir? \n");
            c.ValorInvestimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a taxa de juros do investimento de Renda Fixa? \n");
            c.TaxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a taxa de juros do investimento de Poupança? \n");
            cp.JurosPoupanca = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quatos meses deseja investir? \n");
            c.QuantidadeMes = Convert.ToInt32(Console.ReadLine());

            cp.PreencherConta(c);
            rf.PreencherConta(c);

            rf.CalculaInvestimento(); 
            cp.CalculaInvestimento();

            Console.WriteLine("==============================================================================\n");

            var dataAtual = DateTime.Now;
                  
            foreach (var juros in cp.JurosMensal)
            {
                Console.WriteLine("O rendimento da Poupança será de {0} ", juros.ToString("0.##"));
            }

            foreach (var juros in rf.JurosMensal)
            {
                Console.WriteLine("O rendimento da Renda Fixa será de {0} ", juros.ToString("0.##"));
            }           

            Console.WriteLine("==============================================================================\n");

            Console.WriteLine("O investimento Total da aplicação na Conta Poupança é: {0} \n", cp.ValorTotal);
            Console.WriteLine("O investimento Total da aplicação Renda Fixa sem IR é: {0} \n", rf.ValorTotal);
            Console.WriteLine("O investimento Total da aplicação Renda Fixa com IR é: {0} \n", rf.ValorComIR);

            Console.WriteLine("==============================================================================\n");

            if (cp.ValorTotal > rf.ValorComIR)
            {
                Console.WriteLine("O investimento indicado é a Poupança com o rendimento de: {0}", cp.ValorTotal);
            }
            else if (cp.ValorTotal < rf.ValorComIR)
            {
                Console.WriteLine("O investimento indicado é o Renda Fixa com rendimento de: {0}", rf.ValorComIR);
            }
            else
                Console.WriteLine("Os investimento de Poupança e Renda Fixa com os respectivos valores {0} e {1} são iguais.", cp.ValorTotal, rf.ValorComIR);

            Console.WriteLine("==============================================================================\n");

            Console.ReadKey();
        }
    }
}
