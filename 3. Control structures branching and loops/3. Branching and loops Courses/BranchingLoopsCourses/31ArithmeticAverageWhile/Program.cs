namespace _31ArithmeticAverageWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 4. A customer asks you to write a program to calculate the average score received by the students on the exam
            // (!) A user inputs 10 numbers from the keyboard. Find the arithmetic mean of these numbers

            //Console.Write("Enter 1-e note: ");
            ////double value1 = double.Parse(Console.ReadLine());
            //double value1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 2-e note: ");
            ////double value2 = double.Parse(Console.ReadLine());
            //double value2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 3-e note: ");
            ////double value3 = double.Parse(Console.ReadLine());
            //double value3 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 4-e note: ");
            ////double value4 = double.Parse(Console.ReadLine());
            //double value4 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 5-e note: ");
            ////double value5 = double.Parse(Console.ReadLine());
            //double value5 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 6-e note: ");
            ////double value6 = double.Parse(Console.ReadLine());
            //double value6 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 7-e note: ");
            ////double value7 = double.Parse(Console.ReadLine());
            //double value7 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 8-e note: ");
            ////double value8 = double.Parse(Console.ReadLine());
            //double value8 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 9-e note: ");
            ////double value9 = double.Parse(Console.ReadLine());
            //double value9 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter 10-e note: ");
            ////double value10 = double.Parse(Console.ReadLine());
            //double value10 = Convert.ToDouble(Console.ReadLine());

            //double average = (value1 + value2 + value3 + value4 + value5 + value5 + value6 + value7 + value8 + value9 + value10) / 10;
            //Console.WriteLine($"Average = {average}");


            // For
            //double value;
            //double average = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"Enter {i}-e note: ");
            //    value = Convert.ToDouble(Console.ReadLine());
            //    average += value;
            //}
            //Console.WriteLine($"Average = {average / 10}");


            // While
            double value;
            double average = 0;
            int i = 1;

            while (i <= 10)
            {
                Console.Write($"Enter {i}-e note: ");
                value = Convert.ToDouble(Console.ReadLine());
                average += value;
                i++;
            }
            Console.WriteLine($"Average = {average / 10}");
        }
    }
}