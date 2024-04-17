using System;
using MathGame.Models;

namespace MathGame
{
	public class GameUtilities
	{
		public GameUtilities()
		{
		}

        internal static string GetUserInput()
        {
            return Console.ReadLine().Trim().ToUpper();
        }

        public static void OpenGame(string operation)
        {
            switch (operation)
            {
                case "A":
                    operation = "addition";
                    break;
                case "S":
                    operation = "subtraction";
                    break;
                case "M":
                    operation = "multiplication";
                    break;
                case "D":
                    operation = "division";
                    break;
            }
            Console.WriteLine($"Get ready to do some {operation}!");
        }

        internal static void PrintGames(List<Game> games)
        {
            Console.Clear();
            Console.WriteLine("Game History:");
            Console.WriteLine("------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}/10 pts");
            }
            Console.WriteLine("------------\n");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }

        internal static string ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !int.TryParse(result, out _))
            {
                Console.WriteLine("Your response needs to be an integer. Please try again.");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}

