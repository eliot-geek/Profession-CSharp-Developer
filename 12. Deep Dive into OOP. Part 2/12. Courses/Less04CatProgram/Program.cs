namespace Less04CatProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>();

            var random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                var cat = new Cat($"Cat{i}", $"Breed{i}", random.Next(3, 12));
                cats.Add(cat);

                Console.WriteLine(cat);
            }

            Console.ReadKey();

            // Attempting to sort the list (fails due to lack of comparison logic in the Cat class)
            cats.Sort();

            // Displaying the cats after the failed attempt to sort
            foreach (var cat in cats)
                Console.WriteLine(cat);

            Console.ReadLine();
        }
    }
}
