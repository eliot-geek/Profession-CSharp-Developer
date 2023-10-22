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
            // This line creates a new instance of the Random class and assigns it to the variable "rand".
            Random rand = new Random();

            // This line generates a random integer between 1 and 100 (inclusive) and assigns it to the variable "iiNumber".
            int iiNumber = rand.Next(1, 101);
            // This line initializes the variable "count" to 0. It will be used to keep track of the number of guesses the user makes.
            int count = 0;
            // This line initializes the variable "userNumber" to 0. It will be used to store the user's guess.
            int userNumber;

            // This is an infinite loop. It will keep running until the user correctly guesses the number or the program is otherwise terminated. (If i get out from the cycle i use break)
            for (; ; ) 
            {
                // This line prompts the user to enter a number.
                Console.Write("\nEnter a number: ");
                // This line increments the count of the number of guesses made by the user.
                count++;
                // This line reads a line of text from the console, converts it to an integer, and assigns it to the variable "userNumber".
                userNumber = Convert.ToInt32(Console.ReadLine());

                // If the user's guess is less than the random number, this block of code executes.
                if (userNumber < iiNumber)
                {
                    Console.WriteLine("The number entered is less than the number guessed. Try again.");
                }
                // If the user's guess is greater than the random number, this block of code executes.
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("The entered number is greater than the guessed number. Try again.");
                }
                // If the user's guess is equal to the random number, this block of code executes.
                else
                {
                    // This line prints a congratulations message to the console, along with the number of guesses made by the user.
                    Console.WriteLine($"Congratulations, the number is guessed! Number of attempts: {count}.");
                    // This line waits for the user to press a key before exiting.
                    Console.ReadKey();
                    // This "break" statement exits the loop, since the user has correctly guessed the number.
                    break;
                }
            }
        }
    }
}