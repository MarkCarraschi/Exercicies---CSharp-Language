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

        public void ExercicieSix()
        {
            Console.Write("Digite um número: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"O antecessor de {input} é {input - 1}");
            Console.WriteLine($"O sucessor de {input} é {input + 1}");
        }

        public void ExercicieSeven()
        {
            Console.Write("Digite um número: ");
            float input = float.Parse(Console.ReadLine());
            Console.WriteLine($"O dobro de {input} é {input * 2}");
            Console.WriteLine($"A terça parte de {input} é {input / 3}");
        }

        public void ExercicieEight()
        {
            Console.Write("Digite uma distância em metros : ");
            float input = float.Parse(Console.ReadLine());
            Console.WriteLine($"Quilômetro (KM): {input / 1000}        |      Decimetro (DM): {input * 10}");
            Console.WriteLine($"Hectômetro (HM): {input / 100}         |      Centímetro (CM): {input * 100}");
            Console.WriteLine($"Decametro (DAM): {input / 10}          |      Milímitro (MM): {input * 1000}");
        }

        public void ExercicieNine()
        {
            Console.Write("Carteira R$ ");
            float input = float.Parse(Console.ReadLine());
            Console.WriteLine($"Carteira US$ {input * 3.45}");
        }

        public void ExercicieTen()
        {

        }
    }
}