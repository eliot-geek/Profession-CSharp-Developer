namespace Less05FileSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";
            Repository rep = new Repository(path);
            rep.Load();
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);
            Console.ReadKey();


            rep.Add(new Worker("Samuel", "Jackson", "Actor", 9999, "Cinema"));
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);
            Console.ReadKey();
        }
    }
}