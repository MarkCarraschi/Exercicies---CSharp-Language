using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_Conditional
{
    class Exercicie01
    {
        static void Main(string[] args)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;

            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                Console.WriteLine("\nOperação realizada.\nValor atual do saldo: " + saldo);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                Console.ReadKey();
            }

        }
    }
}
