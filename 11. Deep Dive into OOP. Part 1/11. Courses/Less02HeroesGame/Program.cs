namespace Less02HeroesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not recommended (we can change uint to int in the Hero class)
            // Hero hero1 = new Hero("Hero #1", 1, 10);


            Hero hero1 = new Hero("Hero #1", 1, 300);
            Console.WriteLine(hero1.HeroInformation());


            // Incorrect logic
            // hero1.Treatment();
            // hero1.Treatment();
            // hero1.Treatment();
            // hero1.Treatment();
            // hero1.Treatment();
            // hero1.Treatment();
            // hero1.Treatment();
            // Console.WriteLine(hero1.HeroInformation());


            Hero hero2 = new Hero("Hero #2", 1, 400);
            Console.WriteLine(hero2.HeroInformation());


            // Incorrect logic (not recommended)
            // hero1.Level = 100;


            hero1.Attacked(hero2.Attack());
            Console.WriteLine(hero1.HeroInformation());

            hero1.Attacked(hero2.Attack());
            Console.WriteLine(hero1.HeroInformation());

            hero1.Attacked(hero2.Attack());
            Console.WriteLine(hero1.HeroInformation());

            hero1.Treatment();
            Console.WriteLine(hero1.HeroInformation());

            Console.ReadLine();
        }
    }
}
