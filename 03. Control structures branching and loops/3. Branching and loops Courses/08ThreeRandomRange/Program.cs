namespace _08ThreeRandomRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The customer asks you to write a program that should generate three random numbers from range from -21 to 22, and then displays the maximum number on the screen.
            // If there are multiple maximum numbers (i.e., two or all three numbers are equal), the program should display only one number without any additional messages.

            #region if-else

            Random rand = new Random();

            // Generate three random numbers within the range of -21 to 22
            int firstnumber = rand.Next(-21, 23);
            int secondnumber = rand.Next(-21, 23);
            int thirdnumber = rand.Next(-21, 23);

            Console.WriteLine($"FirstNumber is {firstnumber}");
            Console.WriteLine($"SecondNumber is {secondnumber}");
            Console.WriteLine($"ThirdNumber is {thirdnumber}");

            int maxValue;

            // If the first number is greater than the other two numbers,
            if ((firstnumber > secondnumber) && (firstnumber > thirdnumber))
            {
                // then it is the maximum.
                maxValue = firstnumber;
            }
            // If the first number is less than the second number or the third number, then the maximum is among the other two numbers.
            else
            {
                // We compare the second and third numbers, if the second number is greater than the third number,
                if (secondnumber > thirdnumber)
                {
                    // then the maximum is the second number
                    maxValue = secondnumber;
                }
                else
                {
                    // the maximum is the third number
                    maxValue = thirdnumber;
                }
            }
            // Display the result on the screen
            Console.WriteLine($"\nMaximal number = {maxValue}\n");

            #endregion

            #region Resolution by ?:

            // Generate three random numbers within the range of -21 to 22
            int a = rand.Next(-21, 23);
            int b = rand.Next(-21, 23);
            int c = rand.Next(-21, 23);

            // Display the first, second, and third numbers on the screen
            Console.WriteLine($"FirstNumber is {a}");
            Console.WriteLine($"SecondNumber is {b}");
            Console.WriteLine($"ThirdNumber is {c}");

            // Find the maximum value among the three numbers using the ternary operator
            maxValue = (a > b) && (a > c) ? a : (b > c) ? b : c;

            //maxValue = (firstnumber > b) && (firstnumber > thirdnumber) ? firstnumber : (secondnumber > thirdnumber) ? secondnumber : thirdnumber;

            // Display the maximum number on the screen
            Console.WriteLine($"\nMaximal number = {maxValue}");
            Console.ReadKey();
            #endregion
        }
    }
}