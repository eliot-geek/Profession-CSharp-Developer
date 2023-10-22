using System.Reflection;
using static System.Net.Mime.MediaTypeNames;


namespace _09MethodsThirdGroup
{
    internal class Program
    {
        /// <summary>
        /// Method for generating a string from a set of random characters
        /// </summary>
        /// <returns>Random string</returns>
        static string GetRandomString()
        {
            // Guid.NewGuid() method creates a unique identifier (GUID) that can be used as a random string
            // ToString() method is called to convert the GUID to a string
            var result = Guid.NewGuid().ToString();
            return result;
        }

        /// <summary>
        /// A method that returns a random greeting
        /// </summary>
        /// <param name="Name">Random greeting</param>
        static string GetRandomHi()
        {
            Random r = new Random();
            string text = string.Empty;

            switch (r.Next(5))
            {
                case 0:
                    text = $"Hello!";
                    break;
                case 1:
                    text = $"Good morning!";
                    break;
                case 2:
                    text = $"Greetings to you!";
                    break;
                case 3:
                    text = $"Glad to see you!";
                    break;
                default:
                    text = $"I've been waiting for you!";
                    break;
            }
            return text;
        }

        #region VS2022 - THIS METHOD DOESN'T WORK ON VISUAL STUDIO 2022
        // A method that returns the full path to the current application BUT IT DOESN'T WORK ON VISUAL STUDIO 2022
        
        //static string GetPath()
        //{
        //    return Application.ExecutablePath;
        //}

        //res = GetPath(); 
        //Console.WriteLine(res);
        #endregion

        /// <summary>
        ///  method that returns the full path to the current application
        /// </summary>
        /// <returns>Full path to the current application</returns>
        public static string GetCurrentApplicationPath()
        {
            return Assembly.GetExecutingAssembly().Location;
        }

        static void Main(string[] args)
        {
            #region 03. Third Group

            ////
            //// 
            ////
            //// ┌───────────────────────────────────────────┐
            //// │                                           └──────
            //// │              Doing something                     >>> gives out the result of his work
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘
            ////
            // 
            //   static TypeData MethodName()
            //   {
            //      
            //   }

            #endregion

            string res = GetRandomString(); 
            Console.WriteLine(res);             // 1c43db96-0b95-48f4-a6c3-217068da97da
            res = GetRandomHi(); 
            Console.WriteLine(res);             // Greetings to you!
            res = GetCurrentApplicationPath();
            Console.WriteLine(res);             // C:\Users\leosa\Downloads\PushHub\5. Methods\5. Methods Courses\MethodsCourses\09MethodsThirdGroup\bin\Debug\net6.0\09MethodsThirdGroup.dll
            Console.ReadKey();
        }
    }
}