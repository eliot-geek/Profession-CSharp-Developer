namespace EvenOddNumberDeterminer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter an integer
            Console.Write("Please enter an integer: ");

            // Read the entered number and convert to integer
            int number = int.Parse(Console.ReadLine());

            // Check if the number is even using the modulus operator
            if (number % 2 == 0)
            {
                // If the number is even, print a message indicating it's even
                Console.WriteLine(number + " is an even number.");
            }
            else
            {
                // If the number is odd, print a message indicating it's odd
                Console.WriteLine(number + " is an odd number.");
            }
        }
    }
}