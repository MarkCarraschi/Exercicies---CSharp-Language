using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_Conditional
{
    class Exercicie04
    {
        static void Main(string[] args)
        {
            int idade;
            string entradaNacionalidade;

            Console.WriteLine("Type your age:");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type your nationality: (yes or no)");
            entradaNacionalidade = Console.ReadLine();

            if (entradaNacionalidade.ToLower() == "yes" && idade >= 16)
                Console.WriteLine("You can vote.");
            else
                Console.WriteLine("You cannot vote.");
            Console.ReadKey();

        }
    }
}
