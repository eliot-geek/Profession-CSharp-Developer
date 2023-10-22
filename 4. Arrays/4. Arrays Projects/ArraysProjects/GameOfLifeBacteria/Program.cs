namespace GameOfLifeBacteria
{
    internal class Program
    {
        static int m = 20;                          // number of rows
        static int n = 40;                          // number of columns
        static bool[,] petriDish = new bool[m, n];  // initialize the Petri dish

        static void Main(string[] args)
        {
            #region Game Of Life

            // Task 6.Game of Life
            // Implement your own version of the Game of Life.Your task is to emulate the life of bacteria in a Petri dish.
            // The Petri dish is a bool array of size m by n.A bacterium is a visible symbol in this array.

            // Detailed algorithm of the application:

            // Create a bool array in which there is either a bacterium or not.Randomly place bacteria in this array.
            // Come up with rules for the development of life.For example, a bacterium dies if there are more than three cells nearby, as it lacks food.
            // And it dies if there are less than three cells(out of boredom).
            // In the main loop, on each iteration, check the rules that govern the life of the bacterium and redraw the resulting new state.
            // Tips and recommendations:
            // You can hide the cursor using the command Console.CursorVisible = false;

            #endregion

            Console.CursorVisible = false; // hide the cursor
            Random rand = new Random();

            // randomly place bacteria in the Petri dish
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    petriDish[i, j] = rand.Next(2) == 1; // 50/50 chance of being alive or dead
                }
            }

            // main loop
            while (true)
            {
                Console.SetCursorPosition(0, 0); // move cursor to top left corner
                PrintPetriDish(); // print current state of Petri dish

                // create a copy of the Petri dish to calculate the new state
                bool[,] newPetriDish = new bool[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int numNeighbors = CountNeighbors(i, j);
                        if (petriDish[i, j])
                        { // if bacterium is alive
                            if (numNeighbors == 2 || numNeighbors == 3)
                            {
                                newPetriDish[i, j] = true; // bacterium survives
                            }
                            else
                            {
                                newPetriDish[i, j] = false; // bacterium dies
                            }
                        }
                        else
                        { // if bacterium is dead
                            if (numNeighbors == 3)
                            {
                                newPetriDish[i, j] = true; // new bacterium is born
                            }
                            else
                            {
                                newPetriDish[i, j] = false; // no change
                            }
                        }
                    }
                }

                petriDish = newPetriDish; // update the Petri dish
                System.Threading.Thread.Sleep(500); // wait for 0.5 seconds
            }
        }

        // print the current state of the Petri dish
        static void PrintPetriDish()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(petriDish[i, j] ? "@" : "."); // @ represents a live bacterium, . represents a dead bacterium
                }
                Console.WriteLine();
            }
        }

        // count the number of live neighbors for a given cell
        static int CountNeighbors(int row, int col)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i < 0 || i >= m || j < 0 || j >= n)
                    {
                        continue; // skip cells outside of Petri dish
                    }
                    else if (i == row && j == col)
                    {
                        continue; // skip current cell
                    }
                    else if (petriDish[i, j])
                    {
                        count++; // count live neighbor
                    }
                }
            }
            return count;
        }
    }
}