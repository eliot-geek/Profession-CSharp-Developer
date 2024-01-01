namespace SmallestElementFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int minValue = int.MaxValue; 

            Console.Write("Enter the length of the sequence: ");
            length = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter the sequence (each integer separated by Enter key): ");
            for (int i = 0; i < length; i++) 
            {
                int input = int.Parse(Console.ReadLine());
                // if the entered value is less than the current minimum value
                if (input < minValue) 
                {
                    minValue = input; 
                }
            }
            Console.WriteLine($"The smallest element in the sequence is {minValue}"); 
        }
    }
}
