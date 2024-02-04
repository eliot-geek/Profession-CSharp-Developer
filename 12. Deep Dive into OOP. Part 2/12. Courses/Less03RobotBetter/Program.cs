namespace Less03RobotBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot("Robot_1", "Test");

            // Alternative: Creating a list (robots) with a single Robot instance (robot1)
            // var robots = new List<Robot> { robot1 };

            var robots = new List<Robot> { new Robot("Robot_1", "Test") };

            Robot robot2 = new Robot("Robot_1", "Test");

            Console.WriteLine(robots.Contains(robot2));
            Console.WriteLine(robots.Contains(robot1));
        }
    }
}
