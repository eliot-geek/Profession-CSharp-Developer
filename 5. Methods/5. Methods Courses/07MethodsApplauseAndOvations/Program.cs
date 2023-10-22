namespace _07MethodsApplauseAndOvations
{
    internal class Program
    {
        /// <summary>
        /// Empty Method
        /// </summary>
        static void MethodName()
        {

        }

        /// <summary>
        /// Console closing delay method
        /// </summary>
        static void Pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Displaying the welcome message in the console
        /// </summary>
        static void Hi()
        {
            Console.WriteLine("Hello!");
        }

        /// <summary>
        /// The console mess
        /// </summary>
        static void ApplauseAndOvations()
        {
            Random r = new Random();

            for (int i = 0; i < r.Next(30, 50); i++)
            {
                int posX = r.Next(Console.WindowWidth - 5);             // Get console width
                int posY = r.Next(Console.WindowHeight - 1);            // Get console height
                Console.SetCursorPosition(posX, posY + 1);              // Set the cursor to a random position on the screen
                Console.Write(r.Next(2) == 0 ? "Yeahhh!" : "Yyyy!");    // Output one of the joyful messages
            }
        }


        static void Main(string[] args)
        {
            #region 01. First Group

            ////
            //// ┌───────────────────────────────────────────┐
            //// │                                           │
            //// │              Doing something              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            ////
            ////
            //   static void MethodName()
            //   {
            //
            //   }

            #endregion

            Hi(); // Calling the method Hi
            ApplauseAndOvations(); // Calling the method ApplauseAndOvations
            Pause(); // Calling the method Pause
        }
    }
}