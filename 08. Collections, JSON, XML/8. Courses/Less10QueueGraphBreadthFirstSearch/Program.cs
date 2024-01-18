using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace Less10QueueGraphBreadthFirstSearch
{
    class Program
    {
        public static void Main()
        {
            // Breadth - first search(BFS) - https://en.wikipedia.org/wiki/Breadth-first_search
            Graph graph = new Graph(6);

            // Add edges between vertices
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 5);
            graph.AddEdge(3, 4);

            Console.WriteLine("Breadth First Traversal (starting from vertex 0):");
            graph.BreadthFirstSearch(0);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 1):");
            graph.BreadthFirstSearch(1);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 2):");
            graph.BreadthFirstSearch(2);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 3):");
            graph.BreadthFirstSearch(3);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 4):");
            graph.BreadthFirstSearch(4);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 5):");
            graph.BreadthFirstSearch(5);

            Console.ReadKey();

        }
    }
}