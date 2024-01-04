namespace _21RecursiveFunctionMapLove
{
    internal class Program
    {
        /// <summary>
        /// Define a function named Print that takes in a 2D character array named Map as an argument
        /// </summary>
        /// <param name="Map"></param>
        static void Print(char[,] Map)
        {
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    Console.Write(Map[i, j] == '.' ? ' ' : Map[i, j]);  
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Define a function named ToColor that takes in a 2D character array named Map and two integers named PosX and PosY as arguments
        /// </summary>
        /// <param name="Map"></param>
        /// <param name="PosX"></param>
        /// <param name="PosY"></param>
        static void ToColor(char[,] Map, int PosX, int PosY)
        {
            // If the current element of Map is a dot
            if (Map[PosX, PosY] == '.')
            {
                Map[PosX, PosY] = '+';                // Change the current element to a plus sign to "color" it = "color" the current cell
                ToColor(Map, PosX - 1, PosY);         // Recursively call ToColor with the cell above the current one as arguments
                ToColor(Map, PosX, PosY + 1);         // Recursively call ToColor with the cell to the right of the current one as arguments
                ToColor(Map, PosX + 1, PosY);         // Recursively call ToColor with the cell below the current one as arguments
                ToColor(Map, PosX, PosY - 1);         // Recursively call ToColor with the cell to the left of the current one as arguments
            }
        }


        static void Main(string[] args)
        {
            // Define a 2D character array named map and initialize it with the specified elements
            char[,] map = new char[,]
             {
                {'.','+','+','.','+','+','.', },
                {'+','.','.','+','.','.','+', },
                {'+','.','.','.','.','.','+', },
                {'.','+','.','.','.','+','.', },
                {'.','.','+','.','+','.','.', },
                {'.','.','.','+','.','.','.', }
            };

            Print(map);          
            Console.ReadKey();

            ToColor(map, 1, 1);    // Call the ToColor function with map and (1,1) as arguments to "color" the connected cells
            Print(map);            // Call the Print function with map as an argument to print the new contents of map after coloring the connected cells
            Console.ReadKey();


            #region Important
            // It's possible to treat this task by the Lee Algorithm https://en.wikipedia.org/wiki/Lee_algorithm
            #endregion
        }
    }
}
