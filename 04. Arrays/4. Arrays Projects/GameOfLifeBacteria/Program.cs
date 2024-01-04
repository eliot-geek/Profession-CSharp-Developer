namespace GameOfLifeBacteria
{
    internal class Program
    {
        static int m = 20;                          // number of rows
        static int n = 40;                          // number of columns
        static bool[,] petriDish = new bool[m, n];  // initialize the Petri dish

        static void Main(string[] args)
        {
            // Hide the cursor
            Console.CursorVisible = false; 
            
            Random rand = new Random();

            // Randomly place bacteria in the Petri dish
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // 50/50 chance of being alive or dead
                    petriDish[i, j] = rand.Next(2) == 1; 
                }
            }

            // Main loop
            while (true)
            {
                Console.SetCursorPosition(0, 0);  // Move cursor to top left corner
                PrintPetriDish();                 // Print current state of Petri dish

                // Create a copy of the Petri dish to calculate the new state
                bool[,] newPetriDish = new bool[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int numNeighbors = CountNeighbors(i, j);
                        if (petriDish[i, j])
                        { 
                            if (numNeighbors == 2 || numNeighbors == 3)
                            {
                                newPetriDish[i, j] = true;     // Bacterium survives
                            }
                            else
                            {
                                newPetriDish[i, j] = false;     // Bacterium dies
                            }
                        }
                        else
                        { 
                            if (numNeighbors == 3)
                            {
                                newPetriDish[i, j] = true;     // New Bacterium is born
                            }
                            else
                            {
                                newPetriDish[i, j] = false;     // No change
                            }
                        }
                    }
                }

                petriDish = newPetriDish;               // update the Petri dish
                System.Threading.Thread.Sleep(500);     // wait for 0.5 seconds
            }
        }

        static void PrintPetriDish()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(petriDish[i, j] ? "@" : ".");     // @ represents a live bacterium, . represents a dead bacterium
                }
                Console.WriteLine();
            }
        }


        // Count the number of live neighbors for a given cell
        static int CountNeighbors(int row, int col)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i < 0 || i >= m || j < 0 || j >= n)
                    {
                        continue;     // skip cells outside of Petri dish
                    }
                    else if (i == row && j == col)
                    {
                        continue;     // skip current cell
                    }
                    else if (petriDish[i, j])
                    {
                        count++;     // count live neighbor
                    }
                }
            }
            return count;
        }
    }
}
