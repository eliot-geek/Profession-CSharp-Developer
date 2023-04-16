namespace SmallestElementFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            // initialize the minimum value with the maximum possible integer value
            int minValue = int.MaxValue; 

            Console.Write("Enter the length of the sequence: ");
            // read the length of the sequence from the console input
            length = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter the sequence (each integer separated by Enter key): ");

            // loop through the sequence entered by the user
            for (int i = 0; i < length; i++) 
            {
                // read each integer from the console input
                int input = int.Parse(Console.ReadLine());
                // if the entered value is less than the current minimum value
                if (input < minValue) 
                {
                    // update the minimum value with the entered value
                    minValue = input; 
                }
            }
            // print the smallest element in the sequence
            Console.WriteLine($"The smallest element in the sequence is {minValue}"); 
        }
    }
}