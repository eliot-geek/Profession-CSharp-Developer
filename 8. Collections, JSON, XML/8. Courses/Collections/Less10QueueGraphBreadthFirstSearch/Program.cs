using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace Less10QueueGraphBreadthFirstSearch
{
    class Program
    {
        public static void Main()
        {
            // Breadth - first search(BFS) - https://en.wikipedia.org/wiki/Breadth-first_search


            Graph g = new Graph(6);  
            // Add edges between vertices
            g.AddEdge(0, 1);       
            g.AddEdge(0, 2);       
            g.AddEdge(1, 3);       
            g.AddEdge(2, 4);       
            g.AddEdge(2, 5);   

            Console.WriteLine("Breadth First Traversal (starting from vertex 0):");
            g.BFS(0);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 1):");
            g.BFS(1);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 2):");
            g.BFS(2);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 3):");
            g.BFS(3);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 4):");
            g.BFS(4);

            Console.WriteLine("\nBreadth First Traversal (starting from vertex 5):");
            g.BFS(5);

            Console.ReadKey();
        }
    }
}