namespace _15ParseConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string inputString = "2029";
            //int intValue = (int)inputString;      // Error CS0029.  
                                                    // Fails to implicitly convert type "string" to "int".


            string inputString = "2029";
            int intValue = int.Parse(inputString);
            Console.WriteLine(intValue); // 2029.

            double doubleValue = double.Parse(inputString);
            Console.WriteLine(doubleValue); // 2029

            ulong ulongValue = ulong.Parse(inputString);
            Console.WriteLine(ulongValue); // 2029.

            byte byteValue = byte.Parse(inputString);
            Console.WriteLine(byteValue); // Unhandled exception: 
                                          // System.OverflowException: Value was invalid 
                                          // small or unacceptably large for an unsigned byte.
        }
    }
}