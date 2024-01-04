namespace _14OverloadingMethodsParamsKeyword
{
    internal class Program
    {
        /// <summary>
        /// This method takes in a variable number of integer arguments
        /// </summary>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(params int[] Args) 
        {
            int result = 0;            
            foreach (var e in Args)    
            {
                result += e;            
            }
            return result;              
        }
        // Using the params keyword enables you to provide any number of integer arguments to a method. These values will be summed up, and the method will return the result.

        static void Main(string[] args)
        {
            var res = Sum(1);
            Console.WriteLine(res);

            res = Sum(1, 9);
            Console.WriteLine(res);
            
            res = Sum(1, 9, 9);
            Console.WriteLine(res);
            
            res = Sum(1, 9, 9, 0);
            Console.WriteLine(res);
            
            res = Sum(1, 9, 9, 0, 2);
            Console.WriteLine(res);
            
            res = Sum(1, 9, 9, 0, 2, 8);
            Console.WriteLine(res);
            
            res = Sum(1, 9, 9, 0, 2, 8, 6, 9, 76, 88, 766, 666, 3, 4, 56, 333, 67, 8, 8, 987, 23, 67); // I can add as many i want because of the keyword PARAMS

            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            Console.WriteLine(res);

            res = Sum(col);
            res = Sum(new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2, 8, 0, 9 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2, 8 });
            Console.WriteLine(res);

            res = Sum(new int[] { 2 });
            Console.WriteLine(res);
        }
    }
}
