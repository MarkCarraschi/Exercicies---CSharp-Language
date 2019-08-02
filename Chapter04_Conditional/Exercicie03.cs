using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_Conditional
{
    class Exercicie03
    {
        static void Main(string[] args)
        {
            double saldo = 100.0;
            double taxa;

            if (saldo < 1000)
                taxa = 0.01;
            else if (saldo < 5000)
                taxa = 0.05;
            else
                taxa = 0.1;

            Console.WriteLine("Valor da taxa: " + taxa);
            Console.WriteLine("Valor do salário: " + (saldo - (taxa*saldo)));
            Console.ReadKey();
        }
    }
}
