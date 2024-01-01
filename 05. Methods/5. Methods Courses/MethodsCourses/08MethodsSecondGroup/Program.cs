namespace _08MethodsSecondGroup
{
    internal class Program
    {

        /// <summary>
        /// A method to delay console closure by Interval seconds 
        /// </summary>
        /// <param name="Interval">Number of seconds until the console closes</param>
        static void Pause(int Interval)
        {
            Thread.Sleep(Interval * 1000);
        }

        /// <summary>
        /// Output a personalized greeting to the console
        /// </summary>
        /// <param name="Name">The name to be greeted</param>
        static void Hi(string Name)
        {
            Random r = new Random();
            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0: 
                    text = $"Hello, {Name}!"; 
                    break;
                case 1: 
                    text = $"Good morning, {Name}!"; 
                    break;
                case 2: 
                    text = $"Greetings to you, {Name}!"; 
                    break;
                case 3: 
                    text = $"Glad to see you, {Name}!"; 
                    break;
                default: 
                    text = $"I've been waiting for you, {Name}!"; 
                    break;
            }
            Console.WriteLine(text);
        }

        /// <summary>
        /// Arranged clutter on the screen the desired number of times
        /// </summary>
        /// <param name="Text1">First text to be displayed on the screen</param>
        /// <param name="Text2">Second text to be displayed on the screen</param>
        /// <param name="Count">How many times to output one of the randomly selected texts</param>
        static void ApplauseAndOvations(string Text1, string Text2, int Count)
        {
            Random r = new Random();
            int max = new int[] { Text1.Length, Text1.Length }.Max();

            for (int i = 0; i < Count; i++)
            {
                int posX = r.Next(Console.WindowWidth - max);       // Get console width
                int posY = r.Next(Console.WindowHeight);            // Get console height
                Console.SetCursorPosition(posX, posY + 1);          // Set the cursor to a random position on the screen
                Console.Write(r.Next(2) == 0 ? Text1 : Text2);      // Output one of the joyful messages
            }
        }

        static void Main(string[] args)
        {
            #region 02. Second Group
            ////
            ////    │   Something   │
            ////    │     takes     │
            ////    │   arguments   │
            //// ┌──┘               └────────────────────────┐
            //// │                                           │
            //// │              Doing something              │
            //// │                                           │
            //// └───────────────────────────────────────────┘
            // 
            //   static void MethodName(FormalParameters)
            //   {
            //
            //   }
            #endregion

            Hi("Elon");                                     // Calling the method Hi
            ApplauseAndOvations("Waouhh!", "Dammmm!", 70);  // Calling the method ApplauseAndOvations
            Pause(10);                                      // Calling the method Pause
        }
    }
}