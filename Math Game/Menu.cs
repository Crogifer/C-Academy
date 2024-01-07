namespace Math_Game
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void RunMenu(string name, DateTime date)
        {
            bool gameIsOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"---------------------------------
{date}
Hello {name}, Welcome to Math Game.
What game would you like to play?
1 - Addition
2 - Subtraction
3 - Multiplication
4 - Division
5 - History
6 - Exit Program");
                Console.WriteLine("---------------------------------");

                int gameSelected = Convert.ToInt32(Console.ReadLine());
                switch (gameSelected)
                {
                    case 1:
                        engine.AdditionGame();
                        break;
                    case 2:
                        engine.SubtractionGame();
                        break;
                    case 3:
                        engine.MultiplicationGame();
                        break;
                    case 4:
                        engine.DivisionGame();
                        break;
                    case 5:
                        Helpers.GetGames();
                        break;
                    case 6:
                        Console.WriteLine("Exiting Program");
                        gameIsOn = false;
                        break;
                    default:
                        Console.WriteLine("Please Select a Valid Option");
                        break;
                }
            } while (gameIsOn);
        }
    }
}
