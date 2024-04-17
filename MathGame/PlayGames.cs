using System;
namespace MathGame
{
	public class PlayGames
	{
		public PlayGames()
		{
		}

        internal static string AdditionGame()
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
                var result = Console.ReadLine();

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
            return $"{DateTime.Now} – Addition: Score = {score}";
        }

        internal static string SubtractionGame()
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
                var result = Console.ReadLine();

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
            return $"{DateTime.Now} – Subtraction: Score = {score}";
        }

        internal static string MultiplicationGame()
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
                var result = Console.ReadLine();

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
            return $"{DateTime.Now} – Multiplication: Score = {score}";
        }

        internal static string DivisionGame()
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
                var result = Console.ReadLine();

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
            return $"{DateTime.Now} – Division: Score = {score}";
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

