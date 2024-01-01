namespace Less01MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray my = new MyArray(3);
            Console.WriteLine(my.Print("Test 1: "));
            my.Add(1);

            Console.WriteLine(my.Print("Test 2: "));
            my.Add(2);
            my.Add(3);

            Console.WriteLine(my.Print("Test 3: "));
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                my.Add(random.Next(100));
            }
            Console.WriteLine(my.Print("Test 4: "));

            my.Add(11235814);
            Console.WriteLine(my.Print("Test 5: "));

            Console.ReadKey();
        }
    }
}