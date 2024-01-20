namespace ListManipulationApp;

internal class Program
{
    /// <summary>
    /// Fill a given list of integers with 100 random numbers in the range from 0 to 100.
    /// </summary>
    /// <param name="list">The list to be filled with random numbers.</param>
    static void FillList(List<int> list)
    {
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            list.Add(random.Next(0, 101));
        }
    }

    /// <summary>
    /// Remove numbers from the list that are greater than the specified lower bound 
    /// and less than the specified upper bound.
    /// </summary>
    /// <param name="list">The list of integers to be modified.</param>
    /// <param name="lowerBound">The lower bound for removal.</param>
    /// <param name="upperBound">The upper bound for removal.</param>
    static void RemoveNumbersInRange(List<int> list, int lowerBound, int upperBound)
    {
        Console.WriteLine($"\nRemove numbers greater than {lowerBound}, but less than {upperBound}");
        list.RemoveAll(num => num > lowerBound && num < upperBound);
    }

    /// <summary>
    /// Display the elements of the given list of integers along with a message.
    /// </summary>
    /// <param name="list">The list of integers to be displayed.</param>
    /// <param name="message">The additional message to be displayed.</param>
    static void DisplayList(List<int> list, string message)
    {
        Console.WriteLine($"The list contains {list.Count} integers. ");
        Console.WriteLine(message);

        foreach (var num in list)
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        Console.WriteLine("First Approch");
        List<int> collection = new List<int>();
        FillList(collection);
        DisplayList(collection, "Original List:");
        RemoveNumbersInRange(collection, 25, 50);
        DisplayList(collection, "List after removal:");
        Console.ReadLine();


        Console.WriteLine("Second Approch (Class)");
        List<int> collection1 = Process.CreatedList();
        Process.PrintList(collection1);
        Process.RemoveCondition(collection1);
        Process.PrintList(collection1);
        Console.ReadLine();
    }
}