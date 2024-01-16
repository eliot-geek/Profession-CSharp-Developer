namespace Less06Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack

            // Push - Inserts an object as the top element of the stack.
            // Pop - Returns the object at the top without removing it.
            //
            // Peek - Returns the object at the top of the stack without removing it.
            // Count - Gets the number of elements contained in the stack.
            // Clear - Removes all objects from the stack.

            // First In Last Out = FILO

            #endregion

            Stack<int> stack = new Stack<int>();

            // Push - Adds an element to the top of the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Iterate over the stack using foreach
            Console.WriteLine("Stack:");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }

            // Pop - Removes and returns the element at the top of the stack
            Console.WriteLine($"\n\nStack.Pop() = {stack.Pop()}");

            // Iterate over the stack after pop operation
            Console.WriteLine("Stack after Pop:");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }

            // Peek - Returns the element at the top of the stack without removing it
            Console.WriteLine($"\n\nStack.Peek() = {stack.Peek()}");

            // Iterate over the stack after peek operation
            Console.WriteLine("Stack after Peek:");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Count - Gets the number of elements in the stack
            Console.WriteLine($"\nNumber of elements in the stack: {stack.Count}");

            // Contains - Determines whether the stack contains a specific value
            Console.WriteLine($"\nStack contains 3: {stack.Contains(3)}");

            // Clear - Removes all elements from the stack
            stack.Clear();
            Console.WriteLine("\nStack.Clear(); done");

            // Count after Clear
            Console.WriteLine($"\nNumber of elements in the stack after Clear: {stack.Count}");

        }
    }
}