using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_Conditional
{
    class Exercicie02
    {
        static void Main(string[] args)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                Console.WriteLine("Operação realizada com sucesso\nValor do saldo: "+saldo);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nOperação Inválida\nSaldo insuficiente.");
                Console.ReadKey();
            }
        }
    }
}
