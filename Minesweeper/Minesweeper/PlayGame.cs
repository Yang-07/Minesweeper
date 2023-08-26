namespace Minesweeper
{
    public class PlayGame
    {
        private static Grid gridObj = new Grid();

        public void Run(int gridSize, int numMines)
        {
            char[,] grid = new char[gridSize, gridSize];
            bool[,] mineLocations = new bool[gridSize, gridSize];

            gridObj.InitializeGrid(grid);
            gridObj.PlaceMines(mineLocations, numMines, grid);

            bool[,] revealed = new bool[gridSize, gridSize];
            bool gameOver = false;

            while (true)
            {
                gridObj.DisplayGrid(grid, revealed);

                Console.Write("Select a square to reveal (e.g. A1): ");
                string input = Console.ReadLine().ToUpper();

                if (input.Length < 2 || !char.IsLetter(input[0]) || !char.IsDigit(input[1]))
                {
                    Console.WriteLine("Incorrect input.\n");
                    continue;
                }

                int row = input[0] - 'A';
                int col = int.Parse(input.Substring(1)) - 1;

                if (row < 0 || row >= gridSize || col < 0 || col >= gridSize)
                {
                    Console.WriteLine("Invalid square.\n");
                    continue;
                }

                if (revealed[row, col])
                {
                    Console.WriteLine("Square already revealed.\n");
                    continue;
                }

                if (mineLocations[row, col])
                {
                    gameOver = true;
                    break;
                }

                UncoverSquare(grid, revealed, row, col);

                if (CheckForWin(grid, mineLocations))
                {
                    gridObj.DisplayGrid(grid, revealed);
                    Console.WriteLine("Congratulations, you have won the game!\n");
                    break;
                }
            }

            if (gameOver)
            {
                gridObj.DisplayGrid(grid, revealed);
                Console.WriteLine("Oh no, you detonated a mine! Game over.\n");
            }
        }
        static void UncoverSquare(char[,] grid, bool[,] revealed, int row, int col, int count = 0)
        {
            int gridSize = grid.GetLength(0);
            int countMines = CountAdjacentMines(grid, row, col);
            revealed[row, col] = true;

            if (count > 0)
            {
                grid[row, col] = (char)('0' + countMines);
                return;
            }

            if (countMines == 0)
            {
                grid[row, col] = (char)('0' + countMines);
                for (int r = row - 1; r <= row + 1; r++)
                {
                    for (int c = col - 1; c <= col + 1; c++)
                    {
                        if (r >= 0 && r < gridSize && c >= 0 && c < gridSize && !revealed[r, c])
                        {
                            UncoverSquare(grid, revealed, r, c, 1);
                        }
                    }
                }
            }
            else
            {
                grid[row, col] = (char)('0' + countMines);
            }
        }

        static int CountAdjacentMines(char[,] grid, int row, int col)
        {
            int gridSize = grid.GetLength(0);
            int count = 0;

            for (int r = row - 1; r <= row + 1; r++)
            {
                for (int c = col - 1; c <= col + 1; c++)
                {
                    if (r >= 0 && r < gridSize && c >= 0 && c < gridSize && grid[r, c] == '*')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static bool CheckForWin(char[,] grid, bool[,] mineLocations)
        {
            int gridSize = grid.GetLength(0);

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    if (!mineLocations[row, col] && grid[row, col] == '_')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
