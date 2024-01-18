using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10QueueGraphBreadthFirstSearch
{
    class Graph
    {
        /// <summary>
        /// Represents the number of vertices (Nodes) in the graph.
        /// </summary>
        private int NumberOfVertices;

        /// <summary>
        /// Represents the adjacency lists for each vertex (Edges).
        /// </summary>
        private List<int>[] AdjacencyLists;

        /// <summary>
        /// Constructor to initialize the graph with a given number of vertices.
        /// </summary>
        /// <param name="numberOfVertices">The number of vertices in the graph.</param>
        public Graph(int numberOfVertices)
        {
            NumberOfVertices = numberOfVertices;
            AdjacencyLists = new List<int>[numberOfVertices];

            for (int i = 0; i < numberOfVertices; i++)
            {
                AdjacencyLists[i] = new List<int>();
            }
        }

        /// <summary>
        /// Add an edge between vertices v and w.
        /// </summary>
        /// <param name="v">The source vertex.</param>
        /// <param name="w">The destination vertex.</param>
        public void AddEdge(int v, int w)
        {
            AdjacencyLists[v].Add(w);
        }


        /// <summary>
        /// Perform Breadth-First Search (BFS) starting from vertex s.
        /// </summary>
        /// <param name="s">The starting vertex for BFS.</param>
        public void BreadthFirstSearch(int s)
        {
            bool[] visited = new bool[NumberOfVertices];
            Queue<int> queue = new Queue<int>();

            visited[s] = true;                      
            queue.Enqueue(s);                       

            while (queue.Count != 0)
            {
                s = queue.Dequeue();               
                Console.Write(s + " ");

                // Get all adjacent vertices of the dequeued vertex (neighbors)
                foreach (int neighbor in AdjacencyLists[s])
                {
                    // If an adjacent vertex has not been visited, mark it as visited and enqueue it.
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}
