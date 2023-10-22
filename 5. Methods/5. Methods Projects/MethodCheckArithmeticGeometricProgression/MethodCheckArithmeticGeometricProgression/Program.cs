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
        /// method that checks what a given sequence is
        /// </summary>
        /// <param name="array"></param>
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
                Console.WriteLine("The sequence is not a progression");
            }
        }

        /// <summary>
        /// method to find out if it's an arithmetic progression
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
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
        /// method to find out if it's a geometric progression
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static bool GeometricProgression(params double[] array)
        {
            double commonRation = 0.0d;
            if (array[0] == 0 || array[1] == 0)
            {
                return false;
            }

            commonRation = array[1] / array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] * commonRation != array[i + 1])
                    return false;
            }
            return true;
        }

        /// <summary>
        ///  This method determines whether a given sequence of numbers is an arithmetic or geometric progression.
        /// </summary>
        /// <param name="numbers"></param>
        static void CheckProgression(int[] numbers)
        {
            bool isArithmetic = true;
            bool isGeometric = true;

            if (numbers.Length < 2)
            {
                Console.WriteLine("The sequence is neither an arithmetic nor a geometric progression.");
                return;
            }

            // Check if the sequence is an arithmetic progression.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] != numbers[1] - numbers[0])
                {
                    isArithmetic = false;
                    break;
                }
            }

            // Check if the sequence is a geometric progression.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] / numbers[i - 1] != numbers[1] / numbers[0])
                {
                    isGeometric = false;
                    break;
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
            int[] numbe = { 2 };
            CheckProgression(numbe);
            Delay();


            // Second Method
            double[] Progression1 = new double[] { 3, 5, 7, 9 };
            Progression(Progression1);
            double[] Progression2 = new double[] { 48, -24, 12, -6 };
            Progression(Progression2);
            double[] Progression3 = new double[] { 1, 0, 0 };
            Progression(Progression3);
            double[] Progression4 = new double[] { 1 };
            Progression(Progression4);
            Delay();
        }
    }
}
