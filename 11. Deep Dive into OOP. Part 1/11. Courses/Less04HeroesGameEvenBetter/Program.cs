namespace Less04HeroesGameEvenBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Hero #2", 1, 100);
            Console.WriteLine(hero1.HeroInformation());

            for (int i = 0; i < 10; i++)
            {
                Hero hero2 = new Hero("Hero #1", 1, 100);
                Console.WriteLine(hero2.HeroInformation());
            }

            Console.ReadLine();
        }
    }
}
