namespace _03IntegerTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // There are four types of integers with a sign, which can be used depending on how big (or small) a number is to be stored,

            // Signed integers
            sbyte int8 = 2;     // from -128 to +127
            short int16 = 1;    // from -32768 to +32767
            int int32 = 0;      // from -2^31 to +2^31-1 >>> from -2 147 483 648 to +2 147 483 647
            long int64 = -1;    // from -2^63 to +2^63-1 >>> from -9 223 372 036 854 775 808 to +9 223 372 036 854 775 807

            // unsigned types can be used if only positive values are to be stored

            // unsigned integers
            byte uInt8 = 0;         // from 0 to 255
            ushort uInt16 = 1;      // from 0 to 65535
            uint uInt32 = 2;        // from 0 to 2^32-1 >>> from 0 to 4 294 967 296
            ulong uInt64 = 3;       // 0 to 2^64-1 >>> 0 to 18 446 744 073 709 551 616


            // Note 1 Works with C# 7.0
            // In addition to standard decimal notation, integers can also be
            // hexadecimal and binary notation.
            // For hexadecimal we must use the prefix 0x
            // For binary, prefix 0b must be used.

            // Example
            int hexNumber = 0x7C6;              // 0x7C6 is 1990 in decimal notation
            Console.WriteLine(hexNumber);       // 1990

            int binNumber = 0b11100;            // 0b11100 is 28 in decimal notation
            Console.WriteLine(binNumber);       // 28

            // Note 2 Works with C# 7.0
            // Added use of number delimiters (_) to improve readability of long numbers.
            // This number separator can appear anywhere in the number.
            int number = 1000000000;
            int _number = 1_000_000_______000;

            Console.ReadKey();
        }
    }
}