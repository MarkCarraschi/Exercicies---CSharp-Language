using System;

namespace csharp_exercicies
{
    class ViewBasicExercise
    {
        public ViewBasicExercise(BasicSequence basicSequence)
        {
            while (true)
            {
                Console.WriteLine("Digite o número do exercício : ");
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        basicSequence.ExercicieOne();
                        break;
                    case 2:
                        basicSequence.ExercicieTwo();
                        break;
                    case 3:
                        basicSequence.ExercicieThree();
                        break;
                    case 4:
                        basicSequence.ExercicieFour();
                        break;
                    case 5:
                        basicSequence.ExercicieFive();
                        break;
                    case 6:
                        basicSequence.ExercicieSix();
                        break;
                    case 7:
                        basicSequence.ExercicieSeven();
                        break;
                    case 8:
                        basicSequence.ExercicieEight();
                        break;
                    case 9:
                        basicSequence.ExercicieNine();
                        break;
                    case 10:
                        basicSequence.ExercicieTen();
                        break;
                    case 11:
                        basicSequence.ExercicieEleven();
                        break;
                    case 12:
                        basicSequence.ExercicieTwelve();
                        break;
                    case 13:
                        basicSequence.ExercicieThirteen();
                        break;
                    case 14:
                        basicSequence.ExercicieFourteen();
                        break;
                    case 15:
                        basicSequence.ExercicieFifteen();
                        break;
                    case 16:
                        basicSequence.ExercicieSixteen();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}