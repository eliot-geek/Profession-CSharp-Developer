namespace Less08Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A team consisting of heroes

            // The total number of hero characters to create.
            int count = 10; 

            Random r = new Random();

            // Randomly allocating the count of each hero type.
            int countDruid = r.Next(0, count);
            int countHunter = r.Next(0, count - countDruid);
            int countWarrior = count - countDruid - countHunter;

            // Displaying the counts of each hero type.
            Console.WriteLine($"countDruid: {countDruid} countHunter: {countHunter} countWarrior: {countWarrior}");

            // Creating and displaying Druid characters.
            List<Druid> druids = new List<Druid>();
            for (int i = 0; i < countDruid; i++)
            {
                druids.Add(new Druid());
                Console.WriteLine(druids[i].HeroInformation());
                druids[i].Motto();
            }
            Console.WriteLine();

            // Creating and displaying Hunter characters.
            List<Hunter> hunters = new List<Hunter>();
            for (int i = 0; i < countHunter; i++)
            {
                hunters.Add(new Hunter());
                Console.WriteLine(hunters[i].HeroInformation());
                hunters[i].Motto();
            }
            Console.WriteLine();

            // Creating and displaying Warrior characters.
            List<Warrior> warriors = new List<Warrior>();
            for (int i = 0; i < countWarrior; i++)
            {
                warriors.Add(new Warrior());
                Console.WriteLine(warriors[i].HeroInformation());
                warriors[i].Motto();
            }
            Console.WriteLine();

            Console.ReadLine();

            #endregion

            #region Polymorphism - Demonstrating polymorphism with a base class and derived classes

            // Creating a Hero object and displaying its information.
            Hero hero = new Hero();
            Console.WriteLine(hero.HeroInformation());

            // Creating a hero type object, assigning it to the base class reference, and displaying its information.
            hero = new Druid();
            Console.WriteLine(hero.HeroInformation());
            hero = new Hunter();
            Console.WriteLine(hero.HeroInformation());
            hero = new Warrior();
            Console.WriteLine(hero.HeroInformation());

            Console.ReadLine();

            #endregion


            #region Polymorphism (is as)

            Hero hero1 = new Hero();
            Console.WriteLine(hero1.HeroInformation());

            hero1 = new Druid();
            Console.WriteLine(hero1.HeroInformation());

            // Attempting to call the Heal method directly on the base class reference would result in a compilation error.
            // hero1.Heal();

            // Using casting to call the Heal method on the Druid object through explicit casting.
            ((Druid)hero1).Heal();

            // Using 'as' keyword for safe casting to call the Heal method on the Druid object.
            (hero1 as Druid)?.Heal();

            Console.ReadLine();

            #endregion


            #region A team consisting of 10 heroes with Polymorphism (best way)

            Random random = new Random();

            // Creating a list to hold instances of the base class Hero.
            List<Hero> heroes = new List<Hero>();

            // Generating a team of 10 heroes with different types using polymorphism.
            for (int i = 0; i < 10; i++)
            {
                // Randomly selecting a hero type (Druid, Hunter, or Warrior).
                switch (random.Next(3))
                {
                    case 0:
                        heroes.Add(new Druid());
                        break;
                    case 1:
                        heroes.Add(new Hunter());
                        break;
                    default:
                        heroes.Add(new Warrior());
                        break;
                }


                //Console.WriteLine(heroes[i].HeroInformation());
                //Console.WriteLine(heroes[i].ToString());


                // Displaying hero information using the overridden ToString method.
                // The shorter the code, the better the code.
                Console.WriteLine(heroes[i]);


                // Not suitable; it's only designed for Druids. If the random selection results in a Warrior or Hunter, the program will crash immediately.
                // (heroes[i] as Druid).Heal(); 


                // Performing actions specific to the Druid class, if the hero is a Druid.
                if (heroes[i] is Druid)
                {
                    (heroes[i] as Druid).Heal();
                }

                // Same but effective and exact answer
                // Performing actions specific to the Druid class using exact type checking.
                if (heroes[i].GetType() == typeof(Druid)) 
                {
                    //(heroes[i] as Druid).Heal();
                    ((Druid)heroes[i] as Druid).Heal();
                }

                // Displaying the motto of each hero.
                heroes[i].Motto();
            }

            #endregion

        }
    }
}
