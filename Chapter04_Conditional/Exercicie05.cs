using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_Conditional
{
    class Exercicie05
    {
        /*
         Crie um programa que tenha uma variável double valorDaNotaFiscal e, 
         de acordo com esse valor, o imposto deve ser calculado. As regras de cálculo são:

                Se o valor for menor ou igual a 999, o imposto deve ser de 2%
                Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5%
                Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8%
         */

        static void Main(string[] args)
        {
            double valorDaNotaFiscal = 562.25;
            double IR;

            if (valorDaNotaFiscal <= 999)
                IR = 0.02;
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
                IR = 0.025;
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
                IR = 0.028;
            else
                IR = 0.03;

            Console.WriteLine("Valor com o desconto do IR: " + (valorDaNotaFiscal-(valorDaNotaFiscal*IR)));
            Console.ReadKey();
        }

    }
}
