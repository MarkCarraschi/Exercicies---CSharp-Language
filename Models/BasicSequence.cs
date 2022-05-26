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
            Console.Write("Largura : ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Altura : ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine($"Área : {width * height}");
            Console.WriteLine($"Litros de tinta : {(width * height) * 2}");
        }

        public void ExercicieEleven()
        {
            Console.Write("A : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("B : ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("C : ");
            float c = float.Parse(Console.ReadLine());

            float delta = (b * b) - (4 * a * c);
            Console.WriteLine($"Valor do delta : {delta}");
        }

        public void ExercicieTwelve()
        {
            Console.Write("Preço do produto : ");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine($"Preço promocional : {price * 0.95}");
        }

        public void ExercicieThirteen()
        {
            Console.Write("Salário atual R$ ");
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine($"Salário ajustado R$ {salary * 1.15}");
        }

        public void ExercicieFourteen()
        {
            Console.Write("Quantidade de KM percorridos : ");
            float distance = float.Parse(Console.ReadLine());
            Console.Write("Quantidade de dias alugados: ");
            int quantitieDay = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valor para pagamento R$ {quantitieDay * 90 + distance * 0.20}");
        }

        public void ExercicieFifteen()
        {
            Console.Write("Número de dias trabalhados : ");
            int quantitieDay = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valor recebido R$ {25 * quantitieDay}");
        }

        public void ExercicieSixteen()
        {
            Console.Write("Quantidade de cigarros (dia): ");
            int quantitieCigarettes = int.Parse(Console.ReadLine());
            Console.Write("Anos que utilizou cigarro: ");
            int quantitieYears = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dias perdidos {365 * quantitieYears * quantitieCigarettes * 1 / 6}");
        }
    }
}