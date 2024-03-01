namespace Less03SomethingException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new SomethingException("Something from SomethingException");
            }
            catch (SomethingException e)
            {
                Console.WriteLine(e.Message);           // Exception of type 'Less03SomethingException.SomethingException' was thrown.
                Console.WriteLine(e.SomethingMessage);  // Something from SomethingException
            }

            try
            {
                throw new SomethingException1("Something from SomethingException1");
            }
            catch (SomethingException1 e)
            {
                Console.WriteLine(e.Message);           // Something from SomethingException
            }


            try
            {
                throw new SomethingException("SomethingException", 1);
            }

            catch (SomethingException e) when (e.ErrorCode == 1)
            {
                Console.WriteLine($"{e.Message} Code = {e.ErrorCode}");     // Action 1
            }
            catch (SomethingException e) when (e.ErrorCode == 2)
            {
                Console.WriteLine($"Code = {e.ErrorCode}");                 // Action 2
            }
            catch (SomethingException e) when (e.ErrorCode == 8)
            {
                Console.WriteLine($"{e.Message}.");                         // Action 3
            }
            catch (Exception e)
            {
                // TODO: Handle other types of exceptions
                Console.WriteLine($"An error occurred: {e.Message}");
            }


            //catch (SomethingException e)
            //{
            //    if (e.ErrorCode == 1) Console.WriteLine($"{e.Message} Code = {e.ErrorCode}");       // Action 1
            //    if (e.ErrorCode == 2) Console.WriteLine($"Code = {e.ErrorCode}");                   // Action 2
            //    if (e.ErrorCode == 8) Console.WriteLine($"{e.ErrorCode}");                          // Action 3
            //}

            // Docs thrown
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/throw
        }
    }
}
