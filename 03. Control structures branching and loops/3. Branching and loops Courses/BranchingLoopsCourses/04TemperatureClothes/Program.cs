namespace _04TemperatureClothes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The customer asks you to write a program that determines the current temperature and recommends clothing for the walk

            // The Random class is a built-in class in C# that allows you to generate random numbers.
            Random rand = new Random();

            int temperature = rand.Next(30);
            Console.WriteLine($"Current temperature = {temperature} c");

            if (temperature < 18)
            {
                Console.WriteLine("It's chilly outside, so I recommend a warmer jacket.");
            }
            else
            {
                Console.WriteLine("It's warm outside, you don't need a jacket.");
            }
        }
    }
}