namespace _02IntroductionImprovement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // There are two arrays containing at least 10 and at most 20 elements.
            // Organize the filling and displaying of each of them. Find the maximum and minimum elements in each array

            #region Example 1
            
            // First Array
            Random r = new Random();
            int N = r.Next(10, 20);
            int[] arr = new int[N];
            Console.WriteLine("arr");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
                Console.Write($"{arr[i],3}");
            }
            Console.WriteLine();

            // Maxmimum
            int maxArr = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxArr) 
                    maxArr = arr[i];
            }
            Console.WriteLine($"\nmaxArr = {maxArr}");

            // Minimum
            int minArr = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minArr) 
                    minArr = arr[i];
            }
            Console.WriteLine($"minArr = {minArr}");

            // Second Array
            Console.WriteLine("\nbrr");
            int M = r.Next(10, 20);
            int[] brr = new int[M];
            for (int i = 0; i < brr.Length; i++)
            {
                brr[i] = r.Next(20);
                Console.Write($"{brr[i],3}");
            }
            Console.WriteLine();

            // Maximum
            int maxBrr = brr[0];
            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] > maxBrr) 
                    maxBrr = brr[i];
            }
            Console.WriteLine($"\nmaxBrr = {maxBrr}");

            // Minimum
            int minBrr = brr[0];
            for (int i = 0; i < brr.Length; i++)
            {
                if (brr[i] < minBrr) 
                    minBrr = brr[i];
            }
            Console.WriteLine($"minBrr = {minBrr}");


            #region Note

            Console.WriteLine("\nEasy ways to find Max and Min");
            Console.WriteLine($"arrMax = {arr.Max()}");
            Console.WriteLine($"arrMix = {arr.Min()}");
            Console.WriteLine($"brrMax = {brr.Max()}");
            Console.WriteLine($"brrMix = {brr.Min()}");

            #endregion

            #endregion
        }
    }
}