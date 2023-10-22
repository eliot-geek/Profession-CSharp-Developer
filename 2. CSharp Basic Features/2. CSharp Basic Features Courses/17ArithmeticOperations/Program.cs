namespace _17ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic operations -, *, /, +

            #region sum +

            int valueA = 2_140_000_003; int valueB = 2_140_000_003;
            double valueC = (double)valueA + (double)valueB;
            Console.WriteLine(valueC); Console.ReadKey();

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA + valueB;
            //Console.WriteLine(valueC); Console.ReadKey();

            double valueD = 20.22; double valueE = 20.25;
            double valueI = valueD + valueE;
            Console.WriteLine(valueI); Console.ReadKey();

            //sbyte valueF = 123; short valueG = 22;
            //var valueH = valueF + valueG;

            long valueK = 32; byte valueL = 11;
            var valueM = valueK + valueL;
            Console.WriteLine(valueM); Console.ReadKey();

            #endregion

            #region Difference -

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA - valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD - valueE;

            //byte valueF = 123; short valueG = 22;
            //var valueH = valueF - valueG;

            //long valueK = 32; byte valueL = 11;
            //var valueM = valueK - valueL;

            #endregion

            #region Product *

            //int valueA = 3; int valueB = 2019;
            //int valueC = valueA * valueB;

            //double valueD = 20.22; double valueE = 20.25;
            //double valueI = valueD * valueE;

            //byte valueF = 123; short valueG = 22;
            //var valueH = valueF * valueG;

            //long valueK = 32; byte valueL = 11;
            //double valueM = valueK * valueL;      //or var or long, the greater between them

            #endregion

            #region division /

            //int valueA = 10; int valueB = 2;
            //int valueC = valueA / valueB;
            //Console.WriteLine(valueC); // 5

            //double valueA = 5; double valueB = 2;
            //double valueC = valueA / valueB;
            //Console.WriteLine(valueC);            // Expectation: 2.5 // with double 
            // Reality: 2       // with int


            // 59 / 8 = 7 + 3
            // a = b * q + r
            // dividend / divisor = quotient + remainder [ 0 <= remainder < |divisor| ]
            // 59 = 7 * 8 + [remainder] 3
            // 21 = 4 * 5 + [remainder] 1
            Console.WriteLine("Integer division");
            Console.WriteLine($"05 / 2 = {05 / 2}");
            Console.WriteLine($"59 / 8 = {59 / 8}");
            Console.WriteLine($"21 / 4 = {21 / 4}");

            Console.WriteLine("Division in real");
            Console.WriteLine($"05.0 / 2.0 = {05.0 / 2.0}");
            Console.WriteLine($"59.0 / 8.0 = {59.0 / 8.0}");
            Console.WriteLine($"21.0 / 4.0 = {21.0 / 4.0}");

            #endregion

            #region The remainder of division %

            Console.WriteLine("Integer division. Remainder");
            Console.WriteLine($"05 / 2 = {05 / 2}"); // 2
            Console.WriteLine($"05 % 2 = {05 % 2}"); // 1
            Console.WriteLine($"59 % 8 = {59 % 8}");
            Console.WriteLine($"21 % 4 = {21 % 4}");
            #endregion
        }
    }
}