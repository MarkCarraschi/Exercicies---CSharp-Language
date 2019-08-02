using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_Loop
{
    class Exercicie05
    {
        /*Escreva um programa em C# que imprime todos os números que são divisíveis por 3 ou por 4 entre 0 e 30*/

        static void Main(string[] args)
        {
            int valor = 0;
            do
            {
                if (valor % 3 == 0 || valor % 4 == 0) Console.WriteLine("Divisivel por 3 ou 4\nValor:"+valor);

                valor += 1;
            } while (valor < 30);

            Console.ReadKey();
        }
    }
}
