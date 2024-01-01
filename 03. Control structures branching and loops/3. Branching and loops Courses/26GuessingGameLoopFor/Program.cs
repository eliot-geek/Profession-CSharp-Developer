namespace _26GuessingGameLoopFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 6.
            // A customer asks you to write a guessing game in which the player must guess a number from the range 1 to 100 in a minimum number of steps.
            // At the same time, after the next attempt, the player must see the message
            // "The number entered is greater than the number guessed. Try again."
            // "The entered number is less than the guessed number. Try again."
            // or "Congratulations, the number is guessed! Number of attempts: {number}.

            // This line prints the text "Game "Guest-it"" to the console.
            Console.WriteLine("Game \"Guest-it\"");
            Random rand = new Random();

            int iiNumber = rand.Next(1, 101);
            int count = 0;
            int userNumber;

            // This is an infinite loop. It will keep running until the user correctly guesses the number or the program is otherwise terminated.
            for (; ; ) 
            {
                Console.Write("\nEnter a number: ");
                count++;
                userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber < iiNumber)
                {
                    Console.WriteLine("The number entered is less than the number guessed. Try again.");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("The entered number is greater than the guessed number. Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations, the number is guessed! Number of attempts: {count}.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
