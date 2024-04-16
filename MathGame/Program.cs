namespace MathGame;

class Program
{
    public static void Main(string[] args)
    {
        OpeningMenu();
        List<string> games = new List<string>();

        string areaSelected = GetUserInput();

        while (!areaSelected.Equals("Q", StringComparison.OrdinalIgnoreCase))
        {
            if (areaSelected == "A")
            {
                OpenGame(areaSelected);
                games.Add(AdditionGame());
            }
            if (areaSelected == "S")
            {
                OpenGame(areaSelected);
                games.Add(SubtractionGame());
            }
            if (areaSelected == "M")
            {
                OpenGame(areaSelected);
                games.Add(MultiplicationGame());
            }
            if (areaSelected == "D")
            {
                OpenGame(areaSelected);
                games.Add(DivisionGame());
            }
            if (areaSelected == "S")
            {
                ViewGames(games);
            }
            else
            {
                Console.WriteLine("Oops! That input doesn't seem right. Please choose a letter from the menu!");
                Menu();
            }
            Menu();
            areaSelected = GetUserInput();
        }
    }

    private static string GetUserInput()
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

    public static void OpeningMenu()
     {
            Console.WriteLine("Howdy! Welcome to Math World!\n" +
                        "Currently, we have four areas of training.\n" +
                        "Please pick one of the following options to begin your training,\n" +
                        "or you can take a break if you need to.\n" +
                        "A – Addition\n" +
                        "S – Subtraction\n" +
                        "M – Multiplication\n" +
                        "D – Division\n" +
                        "Q – Quit for now\n" +
                        "_________________________");
     }

    public static void Menu()
     {
        Console.WriteLine("Please pick one of the following options to begin your training,\n" +
                        "or you can take a break if you need to.\n" +
                        "A – Addition\n" +
                        "S – Subtraction\n" +
                        "M – Multiplication\n" +
                        "D – Division\n" +
                        "Q – Quit for now\n" +
                        "S – View scores" +
                        "_________________________");
     }

    public static string AdditionGame()
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

    private static string SubtractionGame()
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

    private static string MultiplicationGame()
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

    private static string DivisionGame()
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

        var result = new int[] {firstNumber, secondNumber};
        return result;
    }

    private static void ViewGames(List<string> games)
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
