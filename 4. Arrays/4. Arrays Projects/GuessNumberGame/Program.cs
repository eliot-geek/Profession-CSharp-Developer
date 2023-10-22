namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess Number Game");
            Console.Write("Enter the maximum integer number of the range: ");
            int max = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();

            int number = rand.Next(1, max);
            int count = 0;
            int userNumber;

            // Start a loop that continues indefinitely (until a 'break' statement is encountered)
            while (true)
            {
                Console.Write("\nEnter the guessed number: ");
                count++;
                string line = Console.ReadLine();

                // Check if the user pressed the Enter key without entering a number
                if (line == "")
                {
                    Console.WriteLine($"Sorry to see you go. The number was: {number}");
                    break;
                }

                userNumber = Convert.ToInt32(line);
                if (userNumber < number)
                {
                    Console.WriteLine("The entered number is smaller than the target number. Please try again.");
                }
                else if (userNumber > number)
                {
                    Console.WriteLine("The entered number is greater than the target number. Please try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations, you guessed the number! Number of attempts: {count}.");
                    break;
                }
            }
        }
    }
}
