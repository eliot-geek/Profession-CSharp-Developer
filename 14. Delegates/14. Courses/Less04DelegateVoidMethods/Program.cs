namespace Less04DelegateVoidMethods
{
    internal class Program
    {
        #region Void Delegate (If I change one, I have to change all the others, so it's not very flexible)

        /// <summary>
        /// Delegate representing a method with no parameters and no return value.
        /// </summary>
        delegate void VoidDelegate1();

        /// <summary>
        /// Method with no parameters and no return value.
        /// </summary>
        public static void Void1() { }

        
        delegate void VoidDelegate2(int Argument1);
        public static void Void2(int Args1) { }

        
        delegate void VoidDelegate3(double Argument1);
        public static void Void3(double Args1) { }

        
        delegate void VoidDelegate4(string Argument1);
        public static void Void4(string Args1) { }

        
        delegate void VoidDelegate5(int Argument1, double Argument2);
        public static void Void5(int Args1, double Args2) { }

        
        delegate void VoidDelegate6(int Argument1, double Argument2, string Argument3);
        public static void Void6(int Args1, double Args2, string Args3) { }


        /// <summary>
        /// Delegate representing a method with three parameters: a string, a double, and an integer, and no return value.
        /// </summary>
        /// <param name="Argument1">The first string argument.</param>
        /// <param name="Argument2">The second double argument.</param>
        /// <param name="Argument3">The third integer argument.</param>
        delegate void VoidDelegate7(string Argument1, double Argument2, int Argument3);

        /// <summary>
        /// Method with three parameters: a string, a double, and an integer, and no return value.
        /// </summary>
        /// <param name="Args1">The first string argument.</param>
        /// <param name="Args2">The second double argument.</param>
        /// <param name="Args3">The third integer argument.</param>
        public static void Void7(string Args1, double Args2, int Args3) { }

        
        delegate void VoidDelegate8(int Argument1, int Argument2, int Argument3);
        public static void Void8(int Args1, int Args2, int Args3) { }

        #endregion


        // ===================================================================================================


        #region Return Delegate

        delegate int ReturnDelegate1();
        public static int Return1() { return 0; }

        
        delegate int ReturnDelegate2(int Argument1);
        public static int Return2(int Args1) { return 0; }

        
        delegate string ReturnDelegate3(double Argument1);
        public static string Return3(double Args1) { return String.Empty; }

        
        delegate double ReturnDelegate4(string Argument1);
        public static double Return4(string Args1) { return 0; }

        
        delegate bool ReturnDelegate5(int Argument1, double Argument2);
        public static bool Return5(int Args1, double Args2) { return true; }

        
        delegate char ReturnDelegate6(int Argument1, double Argument2, string Argument3);
        public static char Return6(int Args1, double Args2, string Args3) { return char.MaxValue; }

        
        delegate long ReturnDelegate7(string Argument1, double Argument2, int Argument3);
        public static long Return7(string Args1, double Args2, int Args3) { return 0; }

        
        delegate byte ReturnDelegate8(int Argument1, int Argument2, int Argument3);
        public static byte Return8(int Args1, int Args2, int Args3) { return 0; }

        #endregion


        // ====================================================================================================


        #region ReturnBool Delegate

        delegate bool ReturnBool1(int Argument1);
        public static bool BoolMethod1(int Args1) { return true; }

        
        delegate bool ReturnBool2(string Argument1);
        public static bool BoolMethod2(string Args1) { return true; }

        
        delegate bool ReturnBool3(double Argument1);
        public static bool BoolMethod3(double Args1) { return true; }

        
        delegate bool ReturnBool4(int Argument1);
        public static bool BoolMethod4(byte Args1) { return true; }

        #endregion

        static void Main(string[] args)
        {
            VoidDelegate1 var1 = Void1;
            Console.WriteLine(var1);
        }
    }
}
