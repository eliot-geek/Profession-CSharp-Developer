namespace _03DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1: Built-in methods. DateTime Class - TimeSpan

            DateTime date = new DateTime(2023, 05, 28, 01, 30, 00);
            Console.WriteLine($"{date}");   // 28.05.2023 1:30:00

            // date.Year         // Returns the year component of the date represented by this instance.
            // date.Month        // Returns the month component of the date represented by this instance.
            // date.Day          // Returns the day of the month represented by this instance.
            // date.Hour         // Returns the hour component of the date represented by this instance.
            // date.Minute       // Returns the minute component of the date represented by this instance.
            // date.Second       // Returns the second component of the date represented by this instance.
            // date.Millisecond  // Returns the millisecond component of the date represented by this instance. 

            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Second);
            Console.WriteLine(date.Millisecond);

            Console.WriteLine(date.ToShortTimeString());        // Getting only the time in short format       1:30
            Console.WriteLine(date.ToShortDateString());        // Getting only the date in short format       28.05.2023

            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.ToLongDateString());

            DateTime newDate = date.AddDays(10);
            Console.WriteLine($"{newDate}");        // 07.06.2023 1:30:00

            Console.WriteLine(DateTime.Now);     // Returns a System.DateTime object that represents the current date and time of the local computer.
            Console.ReadKey();


            TimeSpan span = newDate - date;
            Console.WriteLine(span);                     // 10.00:00:00
            Console.WriteLine(span.TotalMinutes);        // 14400


            date = DateTime.Now;
            double sum = 0;

            // Calculate the sum of integers from 0 to 1000
            for (int k = 0; k <= 1000; k++)
            {
                sum += k;
            }
            Console.WriteLine($"sum = {sum}");
            
            TimeSpan timeSpan = DateTime.Now.Subtract(date);
            Console.WriteLine($"timeSpan.TotalMilliseconds = {timeSpan.TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}