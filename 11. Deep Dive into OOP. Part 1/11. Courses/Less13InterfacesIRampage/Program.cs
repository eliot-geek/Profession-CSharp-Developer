namespace Less13InterfacesIRampage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Druid instance with specified initial characteristics.
            Druid druid = new Druid("druid", 1, 500);

            Console.WriteLine(druid.HeroInformation());

            // Creating an IRampage instance representing a Warrior.
            IRampage warrior = new Warrior();
            warrior.UltraAttack(druid);
            Console.WriteLine(druid.HeroInformation());

            // Creating an IRampage instance representing a Hunter.
            IRampage hunter = new Hunter();
            hunter.UltraAttack(druid);
            Console.WriteLine(druid.HeroInformation());

            Console.ReadLine();


            #region Best way

            Console.WriteLine(druid.HeroInformation());

            // Creating a list of IRampage instances with a Hunter and a Warrior.
            List<IRampage> rampage = new List<IRampage>()
            {
                new Hunter(),
                new Warrior(),
            };

            foreach (var e in rampage)
            {
                e.UltraAttack(druid);
                //Console.WriteLine(druid.HeroInformation());
            }
            
            Console.WriteLine(druid.HeroInformation());

            foreach (var e in rampage)
            {
                e.Recharge();
                //Console.WriteLine(druid.HeroInformation());
            }

            foreach (var e in rampage)
            {
                e.UltraAttack(druid);
                //Console.WriteLine(druid.HeroInformation());
            }
            
            Console.WriteLine(druid.HeroInformation());

            foreach (var e in rampage)
            {
                e.UltraAttack(druid);
                //Console.WriteLine(druid.HeroInformation());
            }
            
            Console.WriteLine(druid.HeroInformation());

            #endregion
        }
    }
}
