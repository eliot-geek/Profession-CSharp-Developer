namespace _10StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Alexander";
            string lastName = "Pushkin";
            string specialization = "Writer";
            string pattern = "First Name: {0} Last Name: {1} Specialization: {2}";

            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              specialization);

            // string interpolation
            Console.WriteLine($"First Name: {firstName} Last Name: {lastName} Specialization: {specialization}");

            #region Calculator
            Console.ReadKey(); Console.Clear();

            int a = 100;
            int b = 11;
            int c = 111;
            Console.WriteLine($"{a} + {b} = {c}");
            #endregion

            #region Database v 1.0
            Console.ReadKey(); Console.Clear();

            string name1 = "Agata", lastName1 = "Lebedeva";
            string name2 = "Adelaide", lastName2 = "Vinogradova";
            string name3 = "Alima", lastName3 = "Popova";
            string name4 = "Katya", lastName4 = "Kalinina";
            string name5 = "Renata", lastName5 = "Ivanova";

            Console.WriteLine($"{name1} {lastName1}");
            Console.WriteLine($"{name2} {lastName2}");
            Console.WriteLine($"{name3} {lastName3}");
            Console.WriteLine($"{name4} {lastName4}");
            Console.WriteLine($"{name5} {lastName5}");
            #endregion

            #region Database v2.0
            Console.ReadKey(); Console.Clear();

            Console.WriteLine($"{name1,10} {lastName1,11}"); // // Writes two strings, `name1` and `lastName1`, to the console with a minimum field width of 10 and 11 characters, respectively
            Console.WriteLine($"{name2,10} {lastName2,11}");
            Console.WriteLine($"{name3,10} {lastName3,11}");
            Console.WriteLine($"{name4,10} {lastName4,11}");
            Console.WriteLine($"{name5,10} {lastName5,11}");
            #endregion
        }
    }
}