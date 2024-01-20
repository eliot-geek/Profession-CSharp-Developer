namespace CheckDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for Duplicates\n");

            HashSet<int> numbersSet = new HashSet<int>();

            while (true)
            {
                Console.Write("Enter a number (or press Enter to finish): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                // Try to parse the input as an integer (boolean)
                if (int.TryParse(input, out int number))
                {
                    if (Repetition.AddNumberToSet(numbersSet, number))
                    {
                        Console.WriteLine("Number successfully saved.");
                    }
                    else
                    {
                        Console.WriteLine("Number was entered previously.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Repetition.DisplayNumbersSet(numbersSet);
            Console.WriteLine("\nChecking for Duplicates is now closed.");
        }
    }
}