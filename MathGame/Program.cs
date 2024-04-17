namespace MathGame;

class Program
{
    public static void Main(string[] args)
    {
        Menus.OpeningMenu();
        List<string> games = new List<string>();

        string areaSelected = GameUtilities.GetUserInput();

        while (!areaSelected.Equals("Q", StringComparison.OrdinalIgnoreCase))
        {
            if (areaSelected == "A")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.AdditionGame());
            }
            if (areaSelected == "S")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.SubtractionGame());
            }
            if (areaSelected == "M")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.MultiplicationGame());
            }
            if (areaSelected == "D")
            {
                GameUtilities.OpenGame(areaSelected);
                games.Add(PlayGames.DivisionGame());
            }
            if (areaSelected == "S")
            {
                GameUtilities.ViewGames(games);
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
