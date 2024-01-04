using System;

namespace _01Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A variable is a "container" for storing data

            //            ────────────────┐             
            // ┌──────────┐               │             
            // │ 6174     │   Value       │ Variable  
            // └──────────┘               │             
            //     box        Identifier  |             
            //            ────────────────┘             

            // Variables are used to store data in memory during the execution time of the program.

            // A variable is declared as follows:
            // The keyword var followed by the variable qualifier,
            // then an assignment operator and the value of the variable, 
            // the instruction ends with a semicolon
            // 
            // Examples
            var a = 28;
            var b = 84.5;
            var c = "The first program written in Visual C#";

            // Note.
            // The name (identifier of the variable) can contain
            // Latin lowercase and uppercase letters
            // underscore character - "_".
            // numbers,
            // ! but a numeral can't be in the first place

            // An example of how not to write the code
            var g = 1;
            var ab = 2;
            var qwerty = "I'm a programmer!";
            var asdf1234 = 20.19;
            var zx_cv = 28;
            var ___gg777_oy19___ = "Today is a great day.";
            //var 799abcde = "oops..."; //- error 

            // ! Important 
            // Get used to a meaningful naming of variables

            var age = 28;
            var weight = 84.5;
            var title = "The first program written in Visual C#";
            var month = "March";
            var schoolName = "SkillBox";
            var csharpCreater = "Anders Hejlsberg";

            Console.ReadKey();
        }
    }
}