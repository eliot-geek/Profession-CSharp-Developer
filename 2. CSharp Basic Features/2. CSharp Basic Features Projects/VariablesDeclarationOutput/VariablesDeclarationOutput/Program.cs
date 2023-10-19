namespace VariablesDeclarationOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string fullName = "Anders Hejlsberg";
            int age = 62;
            string email = "andershejlsberg@gmail.com";
            double programmingScores = 95.5;
            double mathScores = 87.2;
            double physicsScores = 91.7;

            // Display information on the screen
            Console.WriteLine("Full Name: {0}", fullName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Email: {0}", email);
            Console.WriteLine("Programming Scores: {0}", programmingScores);
            Console.WriteLine("Math Scores: {0}", mathScores);
            Console.WriteLine("Physics Scores: {0}", physicsScores);
        }
    }
}