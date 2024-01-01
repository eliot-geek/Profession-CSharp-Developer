namespace _02IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conditional statements are used to execute different blocks of code based on different conditions
            // The if statement will be executed only if the condition in the brackets is "true". 
            // A condition can include any comparison and logical operators i.e. bool result

            // The Random class is a built-in class in C# that allows you to generate random numbers.
            Random rand = new Random();

            // Returns 0, 1, or 2
            int x = rand.Next(3); 
            Console.WriteLine($"The value of x is {x}");

            if (x < 2)
                Console.WriteLine("x can be either 0 or 1");

            // commonly used form of notation
            if (x < 2)
            {
                Console.WriteLine("x can be either 0 or 1");
            }
            Console.ReadKey();
        }
    }
}