namespace _05ClientMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The customer asks you to write a program that should generate two random numbers from the range -10 to 10 and then the screen should display:
            // 1.1. Maximum of the numbers
            // 1.2. Minimum of the numbers
            // 2. Add to the program a possibility to determine the equality of numbers and display a message about it on the screen
            // 3. Add possibility to enter data from the keyboard

            // Create a new Random object to generate random numbers
            Random rand = new Random();

            //// 3. Add possibility to enter data from the keyboard
            //Console.Write("Enter the first number : ");
            //int firstnumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //int secondnumber = int.Parse(Console.ReadLine());

            // Generate two random numbers within the range -10 to 10
            int firstnumber = rand.Next(-10, 11);
            int secondnumber = rand.Next(-10, 11);
            // Display the generated numbers
            Console.WriteLine($"Random firstNumber is {firstnumber}");
            Console.WriteLine($"Random secondNumber is {secondnumber}");

            #region 1.1

            // Determine and display the maximum number and the minimum number
            Console.WriteLine("\nFirst question 1.1\n");

            if (firstnumber > secondnumber)
            {
                Console.WriteLine($"Maximal number is {firstnumber}");
            }
            else
            {
                Console.WriteLine($"Maximal number is {secondnumber}");
            }

            if (firstnumber < secondnumber)
            {
                Console.WriteLine($"Minimal number is {firstnumber}");
            }
            else
            {
                Console.WriteLine($"Minimal number is {secondnumber}");
            }

            #endregion

            #region 1.2

            Console.WriteLine("\nSecond question 1.2\n");

            if (firstnumber > secondnumber)
            {
                Console.WriteLine($"Maximal number is {firstnumber}");
                Console.WriteLine($"Minimal number is {secondnumber}");
            }
            else
            {
                Console.WriteLine($"Maximal number is {secondnumber}");
                Console.WriteLine($"Minimal number is {firstnumber}");
            }

            #endregion

            #region 1.3

            Console.WriteLine("\nThird question 1.3\n");

            bool flag = firstnumber > secondnumber;

            if (flag)
            {
                Console.WriteLine($"Maximal number is {firstnumber}");
                Console.WriteLine($"Minimal number is {secondnumber}");
            }
            else
            {
                Console.WriteLine($"Maximal number is {secondnumber}");
                Console.WriteLine($"Minimal number is {firstnumber}");
            }

            #endregion

            #region 1.4

            Console.WriteLine("\nFourth question 1.4\n");

            int maxValue, minValue;

            if (firstnumber > secondnumber)
            {
                maxValue = firstnumber;
                minValue = secondnumber;
            }
            else
            {
                maxValue = secondnumber;
                minValue = firstnumber;
            }

            Console.WriteLine($"Maximal number is {maxValue}");
            Console.WriteLine($"Minimal number is {minValue}");

            #endregion

            #region Point 2
            // Check if the two numbers are equal and display a message accordingly
            Console.WriteLine("\nSecond Point 2\n");

            if (firstnumber == secondnumber)
            {
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }

            #endregion

            #region Point 3

            //Console.Write("Enter first number : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            #endregion
            
            Console.ReadKey();
        }
    }
}