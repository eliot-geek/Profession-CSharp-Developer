namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the title of the game
            Console.WriteLine("Guess Number Game");
            // Ask the user to input the maximum integer number of the range
            Console.Write("Enter the maximum integer number of the range: ");
            // Convert the user input to an integer and store it in the 'max' variable
            int max = Convert.ToInt32(Console.ReadLine());
            // Create a new Random object
            Random rand = new Random();

            // Generate a random integer between 1 and the maximum integer entered by the user, and store it in the 'number' variable
            int number = rand.Next(1, max);
            // Initialize the 'count' variable to 0
            int count = 0;
            // Declare the 'userNumber' variable
            int userNumber;

            // Start a loop that continues indefinitely (until a 'break' statement is encountered)
            while (true)
            {
                // Ask the user to input their guessed number
                Console.Write("\nEnter the guessed number: ");
                // Increment the 'count' variable to keep track of the number of attempts made by the user
                count++;
                // Read the user's input and store it in the 'line' variable
                string line = Console.ReadLine();

                // Check if the user pressed the Enter key without entering a number
                if (line == "")
                {
                    // If so, display a message with the correct number and end the game
                    Console.WriteLine($"Sorry to see you go. The number was: {number}");
                    // Exit the loop
                    break;
                }

                // Convert the user's input to an integer and store it in the 'userNumber' variable
                userNumber = Convert.ToInt32(line);

                // Check if the user's guess is lower than the target number
                if (userNumber < number)
                {
                    // If so, display a message asking the user to guess again
                    Console.WriteLine("The entered number is smaller than the target number. Please try again.");
                }
                // Check if the user's guess is higher than the target number
                else if (userNumber > number)
                {
                    // If so, display a message asking the user to guess again
                    Console.WriteLine("The entered number is greater than the target number. Please try again.");
                }
                // If the user's guess is correct
                else
                {
                    // Display a congratulatory message with the number of attempts made by the user, and end the game
                    Console.WriteLine($"Congratulations, you guessed the number! Number of attempts: {count}.");
                    // Exit the loop
                    break;
                }
            }
        }
    }
}