namespace Less06ActionFuncPredicate
{
    internal class Program
    {
        //delegate void VoidDelegate2(int Argument1);
        //delegate void VoidDelegate3(double Argument1);
        //delegate void VoidDelegate4(string Argument1);
        //delegate void VoidDelegate<T>(T Args);
        //delegate void VoidDelegate5(int Argument1, double Argument2);

        //delegate void VoidDelegate6(int Argument1, double Argument2, string Argument3);
        //delegate void VoidDelegate7(string Argument1, double Argument2, int Argument3);
        //delegate void VoidDelegate8(int Argument1, int Argument2, int Argument3);
        //delegate void VoidDelegate<T1, T2, T3>(T1 Argument1, T2 Argument2, T3 Argument3);



        // ======================
        // ======= Action =======
        // ======================
        public static void Void1() { }
        public static void Void2(int Args1) { }
        public static void Void3(double Args1) { }
        public static void Void4(string Args1) { }
        public static void Void5(int Args1, double Args2) { }
        public static void Void6(int Args1, double Args2, string Args3) { }
        public static void Void7(string Args1, double Args2, int Args3) { }
        public static void Void8(int Args1, int Args2, int Args3) { }

        
        // ===============================================================================

        
        //delegate int ReturnDelegate1();
        //delegate int ReturnDelegate2(int Argument1);
        //delegate string ReturnDelegate3(double Argument1);
        //delegate double ReturnDelegate4(string Argument1);

        //delegate TOut ReturnDelegate<TIn, TOut>(TIn Argument1);
        //delegate bool ReturnDelegate5(int Argument1, double Argument2);
        //delegate char ReturnDelegate6(int Argument1, double Argument2, string Argument3);
        //delegate long ReturnDelegate7(string Argument1, double Argument2, int Argument3);
        //delegate byte ReturnDelegate8(int Argument1, int Argument2, int Argument3);
        //delegate TOut ReturnDelegate<TIn1, TIn2, TIn3, TOut>(TIn1 Argument1, TIn2 Argument2, TIn3 Argument3);

        
        
        // ======================
        // ======== Func ========
        // ======================
        public static int Return1() { return 0; }
        public static int Return2(int Args1) { return 0; }
        public static string Return3(double Args1) { return String.Empty; }
        public static double Return4(string Args1) { return 0; }
        public static bool Return5(int Args1, double Args2) { return true; }
        public static char Return6(int Args1, double Args2, string Args3) { return char.MaxValue; }
        public static long Return7(string Args1, double Args2, int Args3) { return 0; }
        public static byte Return8(int Args1, int Args2, int Args3) { return 0; }

        // ===============================================================================


        //delegate bool ReturnBool1(int Argument1);
        //delegate bool ReturnBool2(string Argument1);
        //delegate bool ReturnBool3(double Argument1);
        //delegate bool ReturnBool4(int Argument1);
        //delegate bool PredicateDelegate<TIn>(TIn Argument1);



        // ======================
        // ===== Predicate ======
        // ======================
        public static bool BoolMethod1(int Args1) { return true; }
        public static bool BoolMethod2(string Args1) { return true; }
        public static bool BoolMethod3(double Args1) { return true; }
        public static bool BoolMethod4(byte Args1) { return true; }


        static void Main(string[] args)
        {
            //VoidDelegate<int> var1 = Void2;
            //VoidDelegate<double> var2 = Void3;
            //VoidDelegate<string> var3 = Void4;

            //VoidDelegate<int, double, string> var6 = Void6;
            //VoidDelegate<string, double, int> var7 = Void7;
            //VoidDelegate<int, int, int> var8 = Void8;

            //ReturnDelegate<int, int> var9 = Return2;
            //ReturnDelegate<double, string> var10 = Return3;
            //ReturnDelegate<string, double> var11 = Return4;

            //ReturnDelegate<int, double, string, char> var12 = Return6;
            //ReturnDelegate<string, double, int, long> var13 = Return7;
            //ReturnDelegate<int, int, int, byte> var14 = Return8;

            //PredicateDelegate<int> var15 = BoolMethod1;
            //PredicateDelegate<string> var16 = BoolMethod2;
            //PredicateDelegate<double> var17 = BoolMethod3;
            //PredicateDelegate<byte> var18 = BoolMethod4;


            // ======================================================================================================


            // Action
            Action action = Void1;
            Action<int> var1 = Void2;
            Action<double> var2 = Void3;
            Action<string> var3 = Void4;
            Action<int, double, string> var6 = Void6;
            Action<string, double, int> var7 = Void7;
            Action<int, int, int> var8 = Void8;


            // Func
            Func<int, int> var9 = Return2;
            Func<double, string> var10 = Return3;
            Func<string, double> var11 = Return4;
            Func<int, double, string, char> var12 = Return6;
            Func<string, double, int, long> var13 = Return7;
            Func<int, int, int, byte> var14 = Return8;


            // Predicate
            Predicate<int> var15 = BoolMethod1;
            Predicate<string> var16 = BoolMethod2;
            Predicate<double> var17 = BoolMethod3;
            Predicate<byte> var18 = BoolMethod4;


            // Func
            Func<int, bool> var19 = BoolMethod1;
            Func<string, bool> var20 = BoolMethod2;
            Func<double, bool> var21 = BoolMethod3;
            Func<byte, bool> var22 = BoolMethod4;


            // Output the result
            Console.WriteLine("Result of action: " + action.Method.Name);
            Console.WriteLine("Result of var01: " + var1.Method.Name);
            Console.WriteLine("Result of var02: " + var2.Method.Name);
            Console.WriteLine("Result of var03: " + var3.Method.Name);
            Console.WriteLine("Result of var06: " + var6.Method.Name);
            Console.WriteLine("Result of var07: " + var7.Method.Name);
            Console.WriteLine("Result of var08: " + var8.Method.Name);
            Console.WriteLine("Result of var09: " + var9.Method.Name);
            Console.WriteLine("Result of var10: " + var10.Method.Name);
            Console.WriteLine("Result of var11: " + var11.Method.Name);
            Console.WriteLine("Result of var12: " + var12.Method.Name);
            Console.WriteLine("Result of var13: " + var13.Method.Name);
            Console.WriteLine("Result of var14: " + var14.Method.Name);
            Console.WriteLine("Result of var15: " + var15.Method.Name);
            Console.WriteLine("Result of var16: " + var16.Method.Name);
            Console.WriteLine("Result of var17: " + var17.Method.Name);
            Console.WriteLine("Result of var18: " + var18.Method.Name);
            Console.WriteLine("Result of var19: " + var19.Method.Name);
            Console.WriteLine("Result of var20: " + var20.Method.Name);
            Console.WriteLine("Result of var21: " + var21.Method.Name);
            Console.WriteLine("Result of var22: " + var22.Method.Name);
        }
    }
}
