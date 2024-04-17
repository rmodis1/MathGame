using MathGame.Models;

namespace MathGame;

class Program
{
    public static void Main(string[] args)
    {
        Menus.OpeningMenu();
        List<Game> games = new ();

        string areaSelected = GameUtilities.GetUserInput();

        while (!areaSelected.Equals("Q", StringComparison.OrdinalIgnoreCase))
        {
            if (areaSelected == "A")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.AdditionGame());
            }
            else if (areaSelected == "S")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.SubtractionGame());
            }
            else if (areaSelected == "M")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.MultiplicationGame());
            }
            else if (areaSelected == "D")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.DivisionGame());
            }
            else if (areaSelected == "V")
            {
                GameUtilities.PrintGames(games);
            }
            else
            {
                Console.WriteLine("Oops! That input doesn't seem right. Please choose a letter from the menu!");
                Menus.Menu();
            }
            Menus.Menu();
            areaSelected = GameUtilities.GetUserInput();
        }
    }
}