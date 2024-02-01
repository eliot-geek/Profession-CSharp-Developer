namespace Less00CatHouseRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the Cat class
            Cat cat1 = new Cat("Basik", "Russian Blue Cat");
            Cat cat2 = new Cat("Murzik", "Maine Coon");
            Cat cat3 = new Cat("Plumgilda", "Munchkin");

            Console.WriteLine($"Cat 1 - Name: {cat1.Nickname}, Breed: {cat1.Breed}");
            Console.WriteLine($"Cat 2 - Name: {cat2.Nickname}, Breed: {cat2.Breed}");
            Console.WriteLine($"Cat 3 - Name: {cat3.Nickname}, Breed: {cat3.Breed}");
            Console.ReadLine();


            // Creating instances of the House class
            House house1 = new House(18, 182, "Smolensk, Lenin Street, 1");
            House house2 = new House(18, 182, "Zaprudnya, Proletarian Avenue, 2");

            Console.WriteLine($"House 1 - Floor Count: {house1.FloorCount}, Flat Count: {house1.FlatCount}, Address: {house1.Address}");
            Console.WriteLine($"House 2 - Floor Count: {house2.FloorCount}, Flat Count: {house2.FlatCount}, Address: {house2.Address}");
            Console.ReadLine();


            // Creating an instance of the Robot class
            Robot robot = new Robot("C-3PO", "Stars Wars");
            Console.WriteLine($"Robot - Nickname: {robot.Nickname}, Dislocation: {robot.Dislocation}");
            Console.ReadLine();


            // Calling methods on Cat objects
            cat1.ToPlay();
            cat1.ToSleep();
            cat2.ToMew();
            cat3.ToEat();
            Console.ReadLine();


            // Calling a method on the Robot object
            robot.PerformTask();
            Console.ReadLine();
        }
    }
}
