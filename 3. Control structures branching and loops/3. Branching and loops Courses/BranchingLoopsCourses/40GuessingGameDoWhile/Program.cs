namespace _40GuessingGameDoWhile
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

            Console.WriteLine("Game \"Guest-it\"");
            Random rand = new Random();

            int iiNumber = rand.Next(1, 101);
            int count = 0;
            int userNumber;

            // for (; ; )
            // while (true)
            do
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
            } while (true) ;
        }
    }
}