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
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n\nStack.Pop() = {stack.Pop()}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n\nStack.Peek() = {stack.Peek()}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}