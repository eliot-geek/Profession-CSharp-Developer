namespace ListManipulationApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> collection = Process.CreatedList();
        Process.PrintList(collection);
        Process.RemoveCondition(collection);
        Process.PrintList(collection);
        Console.WriteLine();
        Console.ReadKey();
    }
}