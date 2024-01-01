namespace _05MethodParametersModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.2 Method parameters, parameter modifiers, return values

            // 5.2 Method parameters, parameter modifiers, return values
            //
            //
            // LevelsAccess Modifiers ReturnType NameMethod(ParametersMethod)
            // {
            //      Method body
            // }
            //
            // Access levels: [ private, public, protected, internal ]. 
            //              With four access modifiers, six accessibility levels can be declared.
            //
            // Access modifiers: static [ , abstract, async, extern, override, virtual ]
            //
            // returnableType: int, double, string, etc.
            //                 void if there is no need to return anything
            // 
            // NameMethod: lowercase and uppercase letters of Roman alphabet, figures, _
            //             a numeral can not occupy the first place
            // 
            // ParametersMethod: arguments which, as a rule, are subjected to some actions
            //                  Formal parameters - parameters specified in the method description
            //                  Actual parameters - parameters that are specified when calling the method


            // static   ReturnableType  MethodName(Method Parameters)
            // {
            //      Method body
            // }

            Console.WriteLine("5.2 Method parameters, parameter modifiers, return values!");
        }
    }
}