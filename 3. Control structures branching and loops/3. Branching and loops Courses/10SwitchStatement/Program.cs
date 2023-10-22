namespace _10SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An integer can take many variants
            // Applying if-else to all values can be cumbersome therefore, in some cases, it is more advantageous to use the switch selection operator

            Console.Write("Enter a day's number: ");
            int dayIndex = Convert.ToInt32(Console.ReadLine());

            // Not recommended
            if (dayIndex == 1) Console.WriteLine("Monday");
            else if (dayIndex == 2) Console.WriteLine("Tuesday");
            else if (dayIndex == 3) Console.WriteLine("Wednesday");
            else if (dayIndex == 4) Console.WriteLine("Thursday");
            else if (dayIndex == 5) Console.WriteLine("Friday");
            else if (dayIndex == 6) Console.WriteLine("Saturday");
            else if (dayIndex == 7) Console.WriteLine("Sunday");
            else Console.WriteLine("Invalid input.\nThere are seven days in a week on planet Earth");

            // Recommended
            switch (dayIndex)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input.\nThere are seven days in a week on planet Earth");
                    break;
            }
        }
    }
}