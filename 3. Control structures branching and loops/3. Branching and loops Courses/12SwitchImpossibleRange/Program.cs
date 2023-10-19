namespace _12SwitchImpossibleRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note - When using the switch operator it is not possible to specify value ranges
            
            Random r = new Random();
            //int value = Convert.ToInt32(Console.ReadLine());

            int value = r.Next(10);
            Console.WriteLine($"RandomNumber r is {value}");

            // It is recommended to use if-else in this case because we can just change the value range
            if (value > 0 && value < 5)
            {
                Console.WriteLine("0 <= value < 5");
            }
            else if (value >= 5 && value < 10)
            {
                Console.WriteLine("5 <= value < 10");
            }

            #region Switch option 1

            // For example, if we have 10,000 cases or more, would we write another 10,000 lines? Of course not, so in this case it is not recommended to use switch, use if-else instead.
            switch (value)
            {
                case 0: Console.WriteLine("0 <= value < 5"); break;
                case 1: Console.WriteLine("0 <= value < 5"); break;
                case 2: Console.WriteLine("0 <= value < 5"); break;
                case 3: Console.WriteLine("0 <= value < 5"); break;
                case 4: Console.WriteLine("0 <= value < 5"); break;
                case 5: Console.WriteLine("5 <= value < 10"); break;
                case 6: Console.WriteLine("5 <= value < 10"); break;
                case 7: Console.WriteLine("5 <= value < 10"); break;
                case 8: Console.WriteLine("5 <= value < 10"); break;
                case 9: Console.WriteLine("5 <= value < 10"); break;
            }

            #endregion

            #region Switch option 2
            // Not recommended again
            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: Console.WriteLine("0 <= value < 5"); break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Console.WriteLine("5 <= value < 10"); break;
            }

            #endregion

            #region switch option 3
            // Not recommended again
            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: Console.WriteLine("0 <= value < 5"); break;
                default: Console.WriteLine("5 <= value < 10"); break; // If we enter a number outside the range, the program will give a false answer (-3, -18, 23)
            }
            #endregion
        }
    }
}