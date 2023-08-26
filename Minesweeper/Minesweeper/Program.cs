using Minesweeper;

class MinesweeperGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Minesweeper!\n");

        while (true)
        {
            Console.Write("Enter the size of the grid (2 to 10): ");
            int gridSize = int.Parse(Console.ReadLine());

            if (gridSize < 2 || gridSize > 10)
            {
                Console.WriteLine("Incorrect input. Please enter a valid grid size.\n");
                continue;
            }

            Console.Write($"Enter the number of mines (1 to {gridSize * gridSize * 35 / 100}): ");
            int numMines = int.Parse(Console.ReadLine());

            if (numMines < 1 || numMines > gridSize * gridSize * 35 / 100)
            {
                Console.WriteLine("Incorrect input. Please enter a valid number of mines.\n");
                continue;
            }
            PlayGame playGame = new PlayGame();
            playGame.Run(gridSize, numMines);

            Console.Write("Press 'Q' to quit or any other key to play again: ");
            if (Console.ReadKey().Key == ConsoleKey.Q)
                break;

            Console.Clear();
        }
    }
}
