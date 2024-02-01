namespace Less03HeroesGameBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hero hero1 = new Hero("Hero #1", 1, 300);

            Hero hero1 = new Hero("Hero #1", 1, 10);            // forbiddent to beat the player with no strenght
            Console.WriteLine(hero1.HeroInformation());


            // Hero hero2 = new Hero("Hero #1", 1, 400);         // The same name is a problem
            Hero hero2 = new Hero("Hero #2", 1, 400);
            Console.WriteLine(hero2.HeroInformation());

            hero1.Attacked(hero2.Attack());
            Console.WriteLine(hero1.HeroInformation());

            hero1.Treatment();
            Console.WriteLine(hero1.HeroInformation());
            Console.ReadLine();
        }
    }
}
