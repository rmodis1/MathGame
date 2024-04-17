using System;
namespace MathGame
{
	public class Menus
	{
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
                            "V – View scores\n" +
                            "_________________________");
        }
    }
}

