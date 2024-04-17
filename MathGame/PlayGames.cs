using System;
using MathGame.Models;

namespace MathGame
{
	public class PlayGames
	{
        internal static Game AdditionGame()
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;


            for (int i = 0; i < 10; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.Clear();

                Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
                var result = GameUtilities.ValidateResult(Console.ReadLine());

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry, that answer is incorrect!");
                }
                Console.ReadLine();
            }
            Console.WriteLine($"Good game! You got {score}/10 problems correct!\n" +
                $"Press any key to return to the main menu!");
            Console.ReadLine();
            return new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = "Addition"
            };
        }

        internal static Game SubtractionGame()
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
                var result = GameUtilities.ValidateResult(Console.ReadLine());

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry, that answer is incorrect!");
                }
                Console.ReadLine();
            }
            Console.WriteLine($"Good game! You got {score}/10 problems correct!\n");
            Console.ReadLine();
            return new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = "Subtraction"
            };
        }

        internal static Game MultiplicationGame()
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
                var result = GameUtilities.ValidateResult(Console.ReadLine());

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry, that answer is incorrect!");
                }
                Console.ReadLine();
            }
            Console.WriteLine($"Good game! You got {score}/10 problems correct!\n");
            Console.ReadLine();
            return new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = "Multiplication"
            };
        }

        internal static Game DivisionGame()
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                int[] numbers = GetDivisionNumbers();
                firstNumber = numbers[0];
                secondNumber = numbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
                var result = GameUtilities.ValidateResult(Console.ReadLine());

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Sorry, that answer is incorrect!");
                }
                Console.ReadLine();
            }
            Console.WriteLine($"Good game! You got {score}/10 problems correct!\n");
            Console.ReadLine();
            return new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = "Division"
            };
        }

        public static int[] GetDivisionNumbers()
        {
            Random random = new();
            int firstNumber = random.Next(2, 99);
            int secondNumber = random.Next(2, 99);
            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(2, 99);
                secondNumber = random.Next(2, 99);
            }

            var result = new int[] { firstNumber, secondNumber };
            return result;
        }
    }
}

