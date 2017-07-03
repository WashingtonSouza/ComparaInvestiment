using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparaInvestimento
{
    class ContaPoupanca : Conta 
    {
        public IList<double> ListJurosPoupanca = new List<double>();
        public double JurosPoupanca { get; set; }

        public override void CalculaInvestimento()
        {
            Console.WriteLine("\n");

            TaxaJuros = JurosPoupanca;

            base.CalculaInvestimento();

        }
    }
}
