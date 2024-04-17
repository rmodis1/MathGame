using System;
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

        internal static void ViewGames(List<string> games)
        {
            Console.Clear();
            Console.WriteLine("Game History:");
            Console.WriteLine("------------");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------\n");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
    }
}

