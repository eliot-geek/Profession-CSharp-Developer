namespace _06ClientDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The customer wants to write an application that will display the name of the day of the week based on the number entered, or will report that the number entered is invalid

            Console.Write("Enter a number between 1 and 7: ");
            // Read user input and convert to integer
            int dayIndex = Convert.ToInt32(Console.ReadLine());

            #region first method

            // Determine the name of the day of the week based on the number entered
            if (dayIndex == 1)
            {
                Console.WriteLine("Monday");
            }
            else
            {
                if (dayIndex == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else
                {
                    if (dayIndex == 3)
                    {
                        Console.WriteLine("Wednesday");
                    }
                    else
                    {
                        if (dayIndex == 4)
                        {
                            Console.WriteLine("Thursday");
                        }
                        else
                        {
                            if (dayIndex == 5)
                            {
                                Console.WriteLine("Friday");
                            }
                            else
                            {
                                if (dayIndex == 6)
                                {
                                    Console.WriteLine("Saturday");
                                }
                                else
                                {
                                    if (dayIndex == 7)
                                    {
                                        Console.WriteLine("Sunday");
                                    }
                                    else
                                    {
                                        // If the number entered is not between 1 and 7, display an error message
                                        Console.WriteLine("Invalid input.\nThere are seven days in a week on planet Earth"); 
                                    }
                                }
                            }
                        }
                    }
                }
            }

            #endregion

            #region Second method

            if (dayIndex == 1) Console.WriteLine("Monday");
            else if (dayIndex == 2) Console.WriteLine("Tuesday");
            else if (dayIndex == 3) Console.WriteLine("Wednesday");
            else if (dayIndex == 4) Console.WriteLine("Thursday");
            else if (dayIndex == 5) Console.WriteLine("Friday");
            else if (dayIndex == 6) Console.WriteLine("Saturday");
            else if (dayIndex == 7) Console.WriteLine("Sunday");
            else Console.WriteLine("Invalid input.\nThere are seven days in a week on planet Earth"); // If the number entered is not between 1 and 7, display an error message

            #endregion
        }
    }
}