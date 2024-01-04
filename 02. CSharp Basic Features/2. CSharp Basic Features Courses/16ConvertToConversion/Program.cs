namespace _16ConvertToConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "2029";
            int intValue = Convert.ToInt32(inputString);
            Console.WriteLine(intValue); // 2029.

            long l = Convert.ToInt32(intValue);

            double doubleValue = Convert.ToDouble(inputString);
            Console.WriteLine(doubleValue); // 2029

            ulong ulongValue = Convert.ToUInt64(inputString);
            Console.WriteLine(ulongValue); // 2029

            //byte byteValue = byte.Parse(inputString);
            //byte byteValue = Convert.ToByte(inputString);
            //Console.WriteLine(byteValue);         // Unhandled exception: 
            // System.OverflowException: Value was invalid, small or unacceptably large for an unsigned byte.

            #region Data types and their synonyms

            //DataTypes Type.NET
            //sbyte     System.SByte
            //short     System.Int16
            //int       System.Int32
            //long      System.Int64
            //byte      System.SByte
            //ushort    System.UInt16
            //uint      System.UInt32
            //ulong     System.UInt64
            //float     System.Single
            //double    System.Double
            //bool      System.Boolean

            #endregion

            #region Note

            //checked
            //{
            //    byte byteValue = (byte)intValue;
            //    Console.WriteLine(byteValue);
            //}

            //unchecked
            //{
            //    byte byteValue = (byte)intValue;
            //    Console.WriteLine(byteValue);
            //}

            #endregion

            // In general, if you have a string representation of a specific data type that you want to convert to that data type, you should use "Parse".
            // If you have a value of one data type that you want to convert to another data type, you should use "ConvertTo".
        }
    }
}