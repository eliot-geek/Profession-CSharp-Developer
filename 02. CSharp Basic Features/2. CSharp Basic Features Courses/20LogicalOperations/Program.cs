namespace _20LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool variable1 = true;  // 1
            bool variable2 = false; // 0

            #region Inversion / Negation / Logical "NOT" / !

            Console.WriteLine("Inversion: ");
            Console.WriteLine($"variable1 = {variable1} !variable1 = {!variable1}");
            Console.WriteLine($"variable2 = {variable2} !variable2 = {!variable2}");

            #endregion

            #region Conjunction / Logical multiplication / Logical "AND" / &&

            Console.WriteLine("\nConjunction: ");
            variable1 = true;
            variable2 = false;
            // bool result = variable1 && variable2;

            Console.WriteLine($"{true}  && {true}  = {true && true}");
            Console.WriteLine($"{true}  && {false} = {true && false}");
            Console.WriteLine($"{false} && {true}  = {false && true}");
            Console.WriteLine($"{false} && {false} = {false && false}");
            Console.ReadKey();
            #endregion

            #region Disjunction / Logical addition / Logical "OR" / ||

            Console.WriteLine("\nDisjunction: ");
            variable1 = true;
            variable2 = false;
            // bool result = variable1 || variable2;

            Console.WriteLine($"{true}  || {true}  = {true || true}");
            Console.WriteLine($"{true}  || {false} = {true || false}");
            Console.WriteLine($"{false} || {true}  = {false || true}");
            Console.WriteLine($"{false} || {false} = {false || false}");
            Console.ReadKey();
            #endregion

            #region Separating disjunction / Strict disjunction / Excluding "OR" / ^

            Console.WriteLine("\nSeparative disjunction: ");
            variable1 = true;
            variable2 = false;
            bool result = variable1 ^ variable2;

            Console.WriteLine($"{true}  ^ {true}  = {true ^ true}");
            Console.WriteLine($"{true}  ^ {false} = {true ^ false}");
            Console.WriteLine($"{false} ^ {true}  = {false ^ true}");
            Console.WriteLine($"{false} ^ {false} = {false | false}");
            #endregion

            #region Other operations
            Console.WriteLine();
            bool flag1 = 4 > 5; Console.WriteLine(flag1);
            bool flag2 = 1 < 3; Console.WriteLine(flag2);

            char c = 'f';

            bool flag3 = c == 'f'; Console.WriteLine(flag3);
            bool flag4 = 28 == 28; Console.WriteLine(flag4);
            bool flag5 = 28 >= 24; Console.WriteLine(flag5);
            bool flag6 = 9 <= 9; Console.WriteLine(flag6);
            bool flag7 = 28 != 90; Console.WriteLine(flag7);

            string s = "C#";
            bool flag8 = 28 != 90 && s == "C#"; Console.WriteLine(flag8);
            #endregion
        }
    }
}
