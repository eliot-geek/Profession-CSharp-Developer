using System;

namespace MethodCheckArithmeticGeometricProgression
{
    internal class Program
    {
        /// <summary>
        /// A method to make the console close delayed
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Determines the type of the given sequence (arithmetic, geometric, or not a progression).
        /// </summary>
        /// <param name="array">The sequence to be checked.</param>
        static void Progression(params double[] array)
        {
            if (array.Length < 2)
            {
                Console.WriteLine("The sequence has less than three members, you can't determine the type");
                return;
            }
            if (ArithmeticProgression(array))
            {
                Console.WriteLine("The sequence is an arithmetic progression");
            }
            else if (GeometricProgression(array))
            {
                Console.WriteLine("The sequence is a geometric progression");
            }
            else
            {
                Console.WriteLine("The sequence is neither an arithmetic nor a geometric progression");
            }
        }

        /// <summary>
        /// Method to determine if the given sequence is an arithmetic progression.
        /// </summary>
        /// <param name="array">The input sequence.</param>
        /// <returns>True if the sequence is an arithmetic progression, otherwise false.</returns>
        static bool ArithmeticProgression(params double[] array)
        {
            double commonDifference = array[1] - array[0];

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] + commonDifference != array[i + 1])
                    return false;
            }

            return true;
        }


        /// <summary>
        /// Method to determine if the given sequence is a geometric progression.
        /// </summary>
        /// <param name="array">The input sequence.</param>
        /// <returns>True if the sequence is a geometric progression, otherwise false.</returns>
        static bool GeometricProgression(params double[] array)
        {
            if (array[0] == 0 || array[1] == 0)
            {
                return false;
            }

            double commonRatio = array[1] / array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] * commonRatio != array[i + 1])
                    return false;
            }

            return true;
        }


        /// <summary>
        /// This method checks if a given sequence of numbers is an arithmetic or geometric progression.
        /// </summary>
        /// <param name="numbers">The sequence of numbers to check.</param>
        static void CheckProgression(int[] numbers)
        {
            bool isArithmetic = true;
            bool isGeometric = true;

            if (numbers.Length < 2)
            {
                Console.WriteLine("The sequence has less than three members, you can't determine the type.");
                return;
            }

            // Check if the sequence is an arithmetic progression.
            double commonDifference = numbers[1] - numbers[0];
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] != commonDifference)
                {
                    isArithmetic = false;
                    break;
                }
            }

            // Check if the sequence is a geometric progression.
            if (numbers[0] == 0 || numbers[1] == 0)
            {
                isGeometric = false;
            }
            else
            {
                double commonRatio = numbers[1] / numbers[0];
                for (int i = 2; i < numbers.Length; i++)
                {
                    if (numbers[i] / numbers[i - 1] != commonRatio)
                    {
                        isGeometric = false;
                        break;
                    }
                }
            }

            if (isArithmetic)
            {
                Console.WriteLine("The sequence is an arithmetic progression.");
            }
            else if (isGeometric)
            {
                Console.WriteLine("The sequence is a geometric progression.");
            }
            else
            {
                Console.WriteLine("The sequence is neither an arithmetic nor a geometric progression.");
            }
        }

        static void Main(string[] args)
        {
            // First Method
            int[] numbers = { 2, 4, 6, 8, 10 };
            CheckProgression(numbers);
            int[] number = { 2, 4, 8, 16, 32 };
            CheckProgression(number);
            int[] numb = { 1, 0, 0 };
            CheckProgression(numb);
            int[] numbe = { 2 };
            CheckProgression(numbe);
            Delay();
            Console.WriteLine("\n");

            // Second Method
            double[] Progression1 = new double[] { 2, 4, 6, 8, 10 };
            Progression(Progression1);
            double[] Progression2 = new double[] { 2, 4, 8, 16, 32 };
            Progression(Progression2);
            double[] Progression3 = new double[] { 1, 0, 0 };
            Progression(Progression3);
            double[] Progression4 = new double[] { 1 };
            Progression(Progression4);
            Delay();
        }
    }
}
