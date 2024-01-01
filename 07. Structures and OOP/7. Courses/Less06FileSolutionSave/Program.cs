namespace Less06FileSolutionSave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";
            Repository rep = new Repository(path);
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);
            rep.Add(new Worker("Samuel", "Jackson", "Actor", 9999, "Cinema"));
            rep.Save("newdata.csv");
            Console.ReadKey();


            rep.PrintDbToConsole();
            Console.WriteLine(rep.Count);
            Console.ReadKey();
        }
    }
}