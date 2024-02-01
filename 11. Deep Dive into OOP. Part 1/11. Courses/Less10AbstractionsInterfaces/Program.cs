namespace Less10AbstractionsInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the base class is not possible since it's abstract.
            // Compilation error: Cannot create an instance of the abstract class or interface 'Hero'.
            // Hero hero = new Hero();


            // Creating an instance of Druid, a subclass of Hero.
            Hero druid = new Druid();
            druid.Motto();

            // Creating an instance of Hunter, a subclass of Hero.
            Hero hunter = new Hunter();
            hunter.Motto();

            // Creating an instance of Warrior, a subclass of Hero.
            Hero warrior = new Warrior();
            warrior.Motto();

        }
    }
}
