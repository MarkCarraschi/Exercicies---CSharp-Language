using System;

namespace csharp_exercicies
{
    class BasicSequence
    {

        public BasicSequence() { }

        public void ExercicieOne()
        {
            Console.WriteLine("Olá, Mundo!");
        }

        public void ExercicieTwo()
        {
            Console.Write("Qual é o seu nome? ");
            string input = Console.ReadLine();
            Console.WriteLine($"Olá {input}, é um prazer te conhecer!");
        }

        public void ExercicieThree()
        {
            Console.Write("Nome do funcionário: ");
            string nameEmployee = Console.ReadLine();
            Console.Write("Salário: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"O funcionário {nameEmployee} tem um salário de R${salary} em Junho.");
        }

        public void ExercicieFour()
        {
            Console.Write("Digite um valor: ");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            int secondInput = Convert.ToInt32(Console.ReadLine());
            int sum = firstInput + secondInput;
            Console.WriteLine($"A soma entre {firstInput} e {secondInput} é igual a {sum}");
        }

        public void ExercicieFive()
        {
            Console.Write("Nota 1: ");
            float firstScore = float.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            float secondScore = float.Parse(Console.ReadLine());
            Console.WriteLine($"A média entre {firstScore} e {secondScore} é igual a {(firstScore + secondScore) / 2}");
        }
    }
}