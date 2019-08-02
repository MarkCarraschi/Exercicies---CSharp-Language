using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_Loop
{
    class Exercicie02
    {
        /*Faça um programa em C# que imprima a soma dos números de 1 até 1000.*/

        static void Main(string [] args)
        {
            int soma=0;
            do
            {
                soma += 1;
                Console.WriteLine("Soma:" + soma);

            } while (soma < 1000);

            Console.ReadKey();
        }

    }
}
