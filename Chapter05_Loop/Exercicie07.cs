using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_Loop
{
    class Exercicie07
    {
        static void Main(string[] args)
        {
            /*(Opcional) Faça um programa em C# que imprima os primeiros números da série de Fibonacci 
             * até passar de 100. A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21 etc... 
             * Para calculá-la, o primeiro elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo 
             * elemento vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3).*/

            int fn = 0, fn1 = 0, fn2 = 0;


            for(int i = 0; i < 30; i++)
            {

                if (fn == 0) {
                    Console.WriteLine("Fibonacci: " + fn);
                    fn = fn + 1;
                }else if(fn == 1 && fn1 == 0)
                {
                    Console.WriteLine("Fibonacci: " + fn);
                    fn1 = fn1 + 1;
                }
                else
                {
                    fn = fn1 + fn2;
                    Console.WriteLine("Fibonacci: " + fn);
                    fn1 = fn;
                    fn2 = fn1;
                }

            }

            Console.ReadKey();
        }
    }
}
