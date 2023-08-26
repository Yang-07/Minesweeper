using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Grid
    {
        public void InitializeGrid(char[,] grid)
        {
            int gridSize = grid.GetLength(0);
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = '_';
                }
            }
        }
        public void PlaceMines(bool[,] mineLocations, int numMines, char[,] grid)
        {
            int gridSize = mineLocations.GetLength(0);
            Random random = new Random();

            while (numMines > 0)
            {
                int row = random.Next(gridSize);
                int col = random.Next(gridSize);

                if (!mineLocations[row, col])
                {
                    mineLocations[row, col] = true;
                    grid[row, col] = '*';
                    numMines--;
                }
            }
        }

        public void DisplayGrid(char[,] grid, bool[,] revealed)
        {
            int gridSize = grid.GetLength(0);

            Console.WriteLine("Here is your minefield:\n");

            Console.Write("  ");
            for (int col = 0; col < gridSize; col++)
            {
                Console.Write($"{col + 1} ");
            }
            Console.WriteLine();

            for (int row = 0; row < gridSize; row++)
            {
                Console.Write((char)('A' + row) + " ");
                for (int col = 0; col < gridSize; col++)
                {
                    char cell = revealed[row, col] ? grid[row, col] : '_';
                    Console.Write(cell + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
