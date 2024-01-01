namespace _38ArithmeticAverageDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 4. A customer asks you to write a program to calculate the average score received by the students on the exam
            // (!) A user inputs 10 numbers from the keyboard. Find the arithmetic mean of these numbers

            double value;
            double average = 0;
            int i = 1;

            do
            {
                Console.Write($"Enter {i}-e note: ");
                value = Convert.ToDouble(Console.ReadLine());
                average += value;
                i++;
            } while (i <= 10);

            Console.WriteLine($"Average = {average / 10}");
        }
    }
}