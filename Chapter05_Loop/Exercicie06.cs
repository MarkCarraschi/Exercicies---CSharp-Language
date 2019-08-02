using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_Loop
{
    class Exercicie06
    {
        /*(Opcional) Faça um programa em C# que imprima os fatoriais de 1 a 10.

                    O fatorial de um número n é n n-1 n-2 ... até n = 1.
                    O fatorial de 0 é 1
                    O fatorial de 1 é (0!) * 1 = 1
                    O fatorial de 2 é (1!) * 2 = 2
                    O fatorial de 3 é (2!) * 3 = 6
                    O fatorial de 4 é (3!) * 4 = 24
        Faça um for que inicie uma variável n (número) como 1 e fatorial (resultado) como 1 e varia n de 1 até 10:
        */
        static void Main(string[] args)
        {
            /*fatorial invertido*/
            int fatorial = 1, n = 10, m = 1;

            Console.WriteLine("FATORIAL ---- INVERTIDO\n");

            while(n > 0)
            {
                for (int i = n; i != 0; i--) fatorial *= i;

                Console.WriteLine("Fatorial de "+ n + " = " + fatorial);
                fatorial = 1;
                n -= 1;
            }

            Console.WriteLine("FATORIAL\n");

            fatorial = 1;
            while (m <= 10)
            {
                for (int i = fatorial; i <= m; i++) fatorial *= i;

                Console.WriteLine("Fatorial de " + m + " = " + fatorial);
                fatorial = 1;
                m += 1;
            }


            Console.ReadKey();
        }

    }
}
