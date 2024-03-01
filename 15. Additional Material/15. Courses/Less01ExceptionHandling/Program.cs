namespace Less01ExceptionHandling
{
    internal class Program
    {
        #region Example 4 Method TryParse

        /// <summary>
        /// Tries to parse the input string into an integer.
        /// </summary>
        /// <param name="input">The input string to be parsed.</param>
        /// <param name="number">When this method returns, contains the integer equivalent of the input string, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>True if the input string was successfully parsed; otherwise, false.</returns>
        static bool TryParse(string input, out int number)
        {
            try
            {
                number = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                number = default(int);
                // number = 0;
                return false;
            }
        }

        #endregion

        static void Main(string[] args)
        {

            #region Example 1 int.Parse and int.TryParse

            // System.ArgumentNullException - If string s1 = null;
            // FormatException              - If string s1 = 7U or something like that
            // OverflowException            - If string s1 is more than the int.maxValue

            Console.Write("Enter n: ");
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);
            Console.WriteLine($"Good, n = {n}");
            Console.ReadLine();

            // Handling
            int k;
            Console.Write("Enter k: ");
            string s2 = Console.ReadLine();
            bool flag = int.TryParse(s2, out k);
            Console.WriteLine(flag ? $"Good, k = {k}" : $"Bad k = {k}");
            Console.ReadLine();

            #endregion


            #region Example 2 try catch

            int l;
            try
            {
                Console.Write("Enter l: ");
                string s3 = Console.ReadLine();
                l = int.Parse(s3);
                Console.WriteLine($"Good, l = {l}");
            }
            catch
            {
                l = 0;
                Console.WriteLine($"Bad, l = {l}");
            }
            Console.ReadLine();

            #endregion


            #region Example 3 try catch

            int h;
            Console.Write("Enter h: ");
            string s4 = Console.ReadLine();
            try
            {
                h = int.Parse(s4);
                Console.WriteLine($"Good, h = {h}");
            }
            catch
            {
                h = 0;
                Console.WriteLine($"Bad, h = {h}");
            }
            Console.ReadLine();

            #endregion


            #region Example 4 Method TryParse

            Console.Write("Enter t: ");
            string s5 = Console.ReadLine();
            int t;
            bool f = TryParse(s5, out t);
            Console.WriteLine(f ? $"Good, t = {t}" : $"Bad t = {t}");
            Console.ReadLine();

            #endregion


            #region Example 5 try catch array

            // Creating an array with 10 elements

            try
            {
                int[] arr = new int[10];

                // Trying to access the eleventh element, which does not exist
                // This line will throw an IndexOutOfRangeException
                arr[11] = 1;
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();

            #endregion


            #region Example 6 try catch some extensions

            try
            {
                int[] arr = new int[10];

                Console.Write("Enter arr[11]: ");
                
                arr[11] = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Console.ReadLine();

            #endregion


            #region Example 7 try catch some extensions

            try
            {
                int[] arr = new int[10];

                Console.Write("Enter arr[11]: ");
                
                arr[11] = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Error");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Error");
            }

            //catch (Exception)
            //{
            //    Console.WriteLine("Error");
            //}
            
            catch (Exception e)
            {
                Console.WriteLine($"Error >> {e.Message} {e.GetType()}");
            }

            #endregion


            // Docs try-catch
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/try-catch

            // Docs Exception
            // https://docs.microsoft.com/ru-ru/dotnet/api/system.exception?view=netframework-4.8
        }
    }
}
