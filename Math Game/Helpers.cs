namespace Math_Game
{
    internal class Helpers
    {
        static public List<string> games = new();
        internal static string GetName()
        {
            Console.WriteLine("Please input your name: ");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please input your name.");
                name = Console.ReadLine();
            }
            return name;
        }
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(1, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(0, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("------------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine($"Press any key to return to the main menu.");
            Console.ReadLine();
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Answer must be an Integer. Try Again.");
                result = Console.ReadLine();
            }
            return result;
        }
    }
}
