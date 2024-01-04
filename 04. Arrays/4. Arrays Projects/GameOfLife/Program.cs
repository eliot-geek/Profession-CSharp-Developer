namespace GameOfLife
{
    public class LifeSimulation
    {
        private int _heigth;
        private int _width;
        private bool[,] cells;

        /// <summary>
        /// Create a new game
        /// </summary>
        /// <param name="Heigth">Height of the field.</param>
        /// <param name="Width">Width of the field.</param>
        public LifeSimulation(int Heigth, int Width)
        {
            _heigth = Heigth;
            _width = Width;
            cells = new bool[Heigth, Width];
            GenerateField();
        }

        /// <summary>
        /// Go to the next generation and display the result on the console.
        /// </summary>
        public void DrawAndGrow()
        {
            DrawGame();
            Grow();
        }

        /// <summary>
        /// Move the state one forward, according to the established rules
        /// </summary>
        private void Grow()
        {
            for (int i = 0; i < _heigth; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    int numOfAliveNeighbors = GetNeighbors(i, j);

                    if (cells[i, j])
                    {
                        if (numOfAliveNeighbors < 2)
                        {
                            // Any live cell with fewer than two live neighbors dies (underpopulation)
                            cells[i, j] = false;
                        }

                        if (numOfAliveNeighbors > 3)
                        {
                            // Any live cell with more than three live neighbors dies (overpopulation)
                            cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
                            // Any dead cell with exactly three live neighbors becomes alive
                            cells[i, j] = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// See how many living neighbors there are around the cage.
        /// </summary>
        /// <param name="x">X-coordinate of the cell.</param>
        /// <param name="y">Y-coordinate of the cell.</param>
        /// <returns>Number of living cells.</returns>
        private int GetNeighbors(int x, int y)
        {
            int NumOfAliveNeighbors = 0;

            // Iterate over the neighboring cells in a 3x3 grid around the specified cell.
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    // Check if the current neighbor position is within the bounds of the grid.
                    if (!((i < 0 || j < 0) || (i >= _heigth || j >= _width)))
                    {
                        // Check if the cell at the current neighbor position is alive.
                        if (cells[i, j] == true) 
                            NumOfAliveNeighbors++;
                    }
                }
            }
            return NumOfAliveNeighbors;
        }

        /// <summary>
        /// Draw the Game in the Console
        /// </summary>
        private void DrawGame()
        {
            for (int i = 0; i < _heigth; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    // Display 'x' for a live cell, and a space for a dead cell.
                    Console.Write(cells[i, j] ? "x" : " ");

                    // Check if it's the last column in the row.
                    if (j == _width - 1) 
                        Console.WriteLine("\r");
                }
            }

            // Set the cursor position to the beginning of the console window.
            Console.SetCursorPosition(0, Console.WindowTop);
        }

        /// <summary>
        /// Initialize with random values
        /// </summary>
        private void GenerateField()
        {
            Random generator = new Random();

            int number;
            
            for (int i = 0; i < _heigth; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    number = generator.Next(2);

                    // If the number is 0, set the cell to false (dead), otherwise set it to true (alive).
                    cells[i, j] = ((number == 0) ? false : true);
                }
            }
        }
    }

    internal class Program
    {
        // Game restrictions
        private const int Heigth = 10;
        private const int Width = 30;
        private const uint MaxRuns = 100;

        static void Main(string[] args)
        {
            int runs = 0;
            LifeSimulation sim = new LifeSimulation(Heigth, Width);

            while (runs++ < MaxRuns)
            {
                // Advance the simulation to the next generation and display the result.
                sim.DrawAndGrow();
                System.Threading.Thread.Sleep(100);     // Pause
            }
        }
    }
}
