﻿namespace GameOfLife
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
                            cells[i, j] = false;
                        }

                        if (numOfAliveNeighbors > 3)
                        {
                            cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
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

            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= _heigth || j >= _width)))
                    {
                        if (cells[i, j] == true) NumOfAliveNeighbors++;
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
                    Console.Write(cells[i, j] ? "x" : " ");
                    if (j == _width - 1) Console.WriteLine("\r");
                }
            }
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
            #region Game Of Life

            // Task 3.Game of Life 
            // Implement your own version of the Game of Life.Your task is to emulate the life of bacteria in a Petri dish.
            // The Petri dish is a bool array of size m by n.A bacterium is a visible symbol in this array.

            // Detailed algorithm of the application:

            // Create a bool array in which there is either a bacterium or not. Randomly place bacteria in this array.
            // Come up with rules for the development of life.For example, a bacterium dies if there are more than three cells nearby, as it lacks food.
            // And it dies if there are less than three cells(out of boredom).
            // In the main loop, on each iteration, check the rules that govern the life of the bacterium and redraw the resulting new state.
            // Tips and recommendations:
            // You can hide the cursor using the command Console.CursorVisible = false;

            #endregion

            int runs = 0;
            LifeSimulation sim = new LifeSimulation(Heigth, Width);

            while (runs++ < MaxRuns)
            {
                sim.DrawAndGrow();

                // Give the user a chance to see what's going on, we wait a bit
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}