namespace PrimeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can use simple prime numbers such as 3, 7, 37, 79, and 173 to check for prime numbers
            // Get input from user
            Console.Write("Enter an integer: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            // Initialize a boolean variable to false
            bool isPrime = false;

            // Check all numbers from 2 to inputNumber - 1 for factors
            int i = 2;
            while (i < inputNumber)
            {
                if (inputNumber % i == 0)
                {
                    // If a factor is found, set isPrime to true and exit the loop
                    isPrime = true;
                    break;
                }
                i++;
            }

            // Print the result
            if (isPrime)
            {
                Console.WriteLine($"{inputNumber} is not a prime number.");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is a prime number.");
            }
        }
    }
}