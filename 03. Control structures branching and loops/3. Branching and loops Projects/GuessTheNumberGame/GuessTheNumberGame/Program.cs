namespace GuessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess the Number Game!");
            Console.Write("Enter the maximum integer number of the range: ");
            int maxNumber = int.Parse(Console.ReadLine());

            Random random = new Random();
            int numberToGuess = random.Next(maxNumber + 1);

            Console.WriteLine($"A random number between 0 and {maxNumber} has been generated. Try to guess it!");
            // Loop until the user guesses the number or inputs an empty string
            while (true)
            {
                Console.Write("Enter your guess (or tape ENTER to quit): ");
                string input = Console.ReadLine();

                // Check if the user input is an empty string, and end the game if it is
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"The number to guess was {numberToGuess}. Thanks for playing!");
                    break;
                }

                // Parse the user input to an integer, and check if it matches the number to guess
                int guess = int.Parse(input);
                if (guess == numberToGuess)
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    break;
                }
                else if (guess < numberToGuess)
                {
                    Console.WriteLine("Your guess is smaller than the number to guess. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is greater than the number to guess. Try again!");
                }
            }
            Console.ReadLine();
        }
    }
}
