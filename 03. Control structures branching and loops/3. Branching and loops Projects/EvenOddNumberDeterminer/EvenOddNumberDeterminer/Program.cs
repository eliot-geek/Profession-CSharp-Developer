namespace EvenOddNumberDeterminer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is even using the modulus operator
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number.");
            }
            else
            {
                Console.WriteLine(number + " is an odd number.");
            }
        }
    }
}
