using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_Loop
{
    class Exercicie04
    {
        /*(Opcional) Escreva um programa em C# que some todos os números de 1 a 100, pulando os múltiplos de 3. O programa deve imprimir o resultado final em um MessageBox.
         * Qual o resultado?*/

        static void Main(string[] args)
        {
            int valor = 0;
            do
            {
                if (valor % 3 == 0) valor+=0;
                else valor += valor;

                valor += 1;
            } while (valor < 100);

            Console.WriteLine("Valor final: " + valor);

            Console.ReadKey();
        }
    }
}
