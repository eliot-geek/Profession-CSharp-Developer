namespace _00DataRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ways to get data in the app - Data output
            string name = "Bill Gates";
            byte age = 63;
            ushort costs = 118;

            #region data input

            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of monthly expenses: ");
            costs = Convert.ToUInt16(Console.ReadLine());

            #endregion

            Console.WriteLine("Name: " + name + " Age: " + age + " Expenses: $" + costs);      // concatenate strings
            Console.WriteLine("Name: {0} Age: {1} Expenses: ${2}", name, age, costs);          // formatted output
            Console.WriteLine($"Name: {name} Age: {age} Expenses: ${costs}");                  // interpolate the lines
            Console.ReadKey();
        }
    }
}
