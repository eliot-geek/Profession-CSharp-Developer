namespace _20LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An expression (in mathematical logic) - An expression is a grammatically correct narrative sentence of language (natural or artificial), 
            // which expresses some meaning and is either true, or false, but not both at once.

            // Example 1: Na - metal - true
            // Example 2: 2 + 2 = 5 - false

            bool variable1 = true;  // 1
            bool variable2 = false; // 0

            #region Inversion / Negation / Logical "NOT" / !

            Console.WriteLine("Inversion: ");
            // Definition. The negation of the statement, will be the statement "opposite" to the original one.

            Console.WriteLine($"variable1 = {variable1} !variable1 = {!variable1}");
            Console.WriteLine($"variable2 = {variable2} !variable2 = {!variable2}");

            #endregion

            #region Conjunction / Logical multiplication / Logical "AND" / &&

            Console.WriteLine("\nConjunction: ");
            // Definition 2. The conjunction of two statements, will be the statement true if and only if both initial statements are true
            // Example 4: Na is a metal AND Proxima Centauri is the nearest star to the solar system // true
            // Example 5: Computer works with zeros and ones AND all people drink water // true

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
            // Definition 3. The disjunction of two statements, will be the statement False if and only if both initial statements are false
            // Example 6: Nа is a metal OR 2 + 2 = 5 
            // Example 7: Proxima Centauri is the nearest star to Earth OR all people drink water

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
            // Definition 4. A disjunctive disjunction of two statements will be a statement true if and only if only one of the initial statements is true

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