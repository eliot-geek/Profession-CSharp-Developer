namespace Less06HeroDruidHunterWarrior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial characteristics\n");

            // Creating and displaying information for different character types.
            Druid druid = new Druid("Druid", 1, 100);
            Console.WriteLine(druid.HeroInformation());

            Warrior warrior = new Warrior("Warrior", 1, 100);
            Console.WriteLine(warrior.HeroInformation());

            Hunter hunter = new Hunter("Hunter", 1, 100);
            Console.WriteLine(hunter.HeroInformation());

            Console.WriteLine("\nAfter the attack\n");

            // Simulating an attack on each character type and displaying the updated information.
            druid.Attacked(50);
            Console.WriteLine(druid.HeroInformation());

            warrior.Attacked(50);
            Console.WriteLine(warrior.HeroInformation());

            hunter.Attacked(50);
            Console.WriteLine(hunter.HeroInformation());

            Console.WriteLine("\nAfter the treatment\n");

            // Simulating a healing action on each character type and displaying the updated information.
            druid.Treatment(20);
            Console.WriteLine(druid.HeroInformation());

            warrior.Treatment(20);
            Console.WriteLine(warrior.HeroInformation());

            hunter.Treatment(20);
            Console.WriteLine(hunter.HeroInformation());

            Console.WriteLine();

            // Displaying the motto for each character type.
            druid.Motto();
            warrior.Motto();
            hunter.Motto();

            Console.ReadLine();

        }
    }
}
