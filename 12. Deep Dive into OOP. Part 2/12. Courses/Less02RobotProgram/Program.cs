namespace Less02RobotProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Robot instance (robot1) and adding it to a list (robots)
            Robot robot1 = new Robot("Robot_1", "Test");
            var robots = new List<Robot> { robot1 };

            // Alternative: creating and adding a new Robot instance directly in the list
            // var robots = new List<Robot> { new Robot("Robot_1", "Test") };

            Robot robot2 = new Robot("Robot_1", "Test");

            Console.WriteLine(robots.Contains(robot2)); // False
            Console.WriteLine(robots.Contains(robot1)); // True

        }
    }
}
