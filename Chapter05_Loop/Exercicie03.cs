using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_Loop
{
    class Exercicie03
    {
        /*  Faça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.
            Para saber se um número é múltiplo de 3, você pode fazer if(numero % 3 == 0).
        */
        static void Main(string[] args)
        {
            int valor = 0;
            do {
                if (valor % 3 == 0) Console.WriteLine("MULTIPLO DE 3: " + valor);
                valor += 1;    
            } while (valor < 100);

            Console.ReadKey();
        }

    }
}
