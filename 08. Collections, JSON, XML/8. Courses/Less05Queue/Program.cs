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

            // Enqueue - Adds an element to the end of the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Iterate over the queue using foreach
            Console.WriteLine("Queue:");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Dequeue - Removes and returns the element at the beginning of the queue
            Console.WriteLine($"\nQueue.Dequeue() = {queue.Dequeue()}");

            // Iterate over the queue after dequeue operation
            Console.WriteLine("Queue after Dequeue:");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Peek - Returns the element at the beginning of the queue without removing it
            Console.WriteLine($"\nQueue.Peek() = {queue.Peek()}");

            // Iterate over the queue after peek operation
            Console.WriteLine("Queue after Peek:");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Count - Gets the number of elements in the queue
            Console.WriteLine($"\nNumber of elements in the queue: {queue.Count}");

            // Contains - Determines whether the queue contains a specific value
            Console.WriteLine($"\nQueue contains 3: {queue.Contains(3)}");

            // Clear - Removes all elements from the queue
            queue.Clear();
            Console.WriteLine("\nQueue.Clear(); done");

            // Count after Clear
            Console.WriteLine($"\nNumber of elements in the queue after Clear: {queue.Count}");
        }
    }
}