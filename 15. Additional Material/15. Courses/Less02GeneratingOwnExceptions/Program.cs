using System.Security.Claims;

namespace Less02GeneratingOwnExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Handle differents exceptions


            try
            {
                Class.Method();
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Error. e.Message = {e.Message}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Index Error. e.Message = {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"General error. e.Message = {e.Message}");
            }
        }
    }
}
