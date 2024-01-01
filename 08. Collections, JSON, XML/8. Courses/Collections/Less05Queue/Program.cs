namespace Less05Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Queue

            // Enqueue - Adds an object to the end of the queue.
            // Dequeue - Removes an object from the beginning of the queue and returns it.
            //
            // Peek - Returns the object at the beginning of the queue without removing it.
            // Count - Gets the number of elements contained in the queue.
            // Clear - Removes all objects from the queue.

            // First In, First Out (FIFO)

            #endregion

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n\nQueue.Dequeue() = {queue.Dequeue()}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n\nQueue.Peek() = {queue.Peek()}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}