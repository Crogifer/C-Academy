namespace Math_Game
{
    internal class GameEngine
    {
        internal void AdditionGame()
        {
            Console.Clear();
            Console.WriteLine("\nAddition Game Selected\n");

            var random = new Random();
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct!\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                }
            }
            Helpers.games.Add($"{DateTime.Now}: Addition - Score = {score}");
            Console.Clear();
            Console.WriteLine($"Game Over. Score = {score}\n");
            Console.WriteLine($"Press any key to return to the main menu.");
            Console.ReadLine();
        }

        internal void SubtractionGame()
        {
            Console.Clear();
            Console.WriteLine("\nSubtraction Game Selected\n");

            var random = new Random();
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct!\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                }
            }
            Helpers.games.Add($"{DateTime.Now}: Subtraction - Score = {score}");
            Console.Clear();
            Console.WriteLine($"Game Over. Score = {score}\n");
            Console.WriteLine($"Press any key to return to the main menu.");
            Console.ReadLine();
        }

        internal void MultiplicationGame()
        {
            Console.Clear();
            Console.WriteLine("\nMultiplication Game Selected\n");

            var random = new Random();
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Correct!\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                }
            }
            Helpers.games.Add($"{DateTime.Now}: Multiplication - Score = {score}");
            Console.Clear();
            Console.WriteLine($"Game Over. Score = {score}\n");
            Console.WriteLine($"Press any key to return to the main menu.");
            Console.ReadLine();
        }

        internal void DivisionGame()
        {
            Console.Clear();
            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division Game Selected");
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct!\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n");
                    Console.WriteLine($"Press any key to continue.");
                    Console.ReadLine();
                }

            }
            Helpers.games.Add($"{DateTime.Now}: Division - Score = {score}");
            Console.Clear();
            Console.WriteLine($"Game Over. Score = {score}\n");
            Console.WriteLine($"Press any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
