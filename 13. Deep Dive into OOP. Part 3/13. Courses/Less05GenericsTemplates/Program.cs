namespace Less05GenericsTemplates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<int> ints = new Repository<int>();

            ints.Push(9);
            ints.Push(0);
            ints.Push(2);
            ints.Push(8);
            ints.Push(0);
            ints.Push(9);

            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write($"{ints[i]} ");
            }
            Console.WriteLine($"\nInts.Count = {ints.Count}\n");

            // Pop() removes the last element from the array and returns it. However, it doesn't delete or erase the memory where the element was stored;
            // rather, it simply removes it from the array and reduces the length of the array by one.

            while (ints.Count != 0)
            {
                Console.Write($"{ints.Pop()} ");
            }
            Console.WriteLine($"\nInts.Count = {ints.Count}\n");


            Repository<Worker> workers = new Repository<Worker>();
            
            for (int i = 1; i <= 5; i++)
            {
                workers.Push(new Worker($"Name_{i}", $"LastName_{i}", 20 + i, i * 5000));
            }

            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine($"{workers[i]} ");
            }
            Console.WriteLine($"Workers.Count = {workers.Count}\n");

            while (workers.Count != 0)
            {
                Console.WriteLine($"{workers.Pop()} ");
            }
            Console.WriteLine($"Workers.Count = {workers.Count}");
            Console.ReadLine();
        }
    }
}
