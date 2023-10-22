namespace AveragePointAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // grades in programming, mathematics, and physics
            double programmingScore = 99.1;
            double mathScore = 90.5;
            double physicsScore = 88.3;

            // a variable under the sum of points
            double totalScore = programmingScore + mathScore + physicsScore;

            // variable under the average score
            double averageScore = totalScore / 3.0;

            // screen output
            Console.WriteLine("Total Points: " + totalScore);
            Console.WriteLine("Grade Point Average: " + averageScore);
            Console.ReadKey();
        }
    }
}