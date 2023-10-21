using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10QueueGraphBreadthFirstSearch
{
    /// <summary>
    /// Represent the graph and perform BFS
    /// </summary>
    class Graph
    {
        private int V;              // Number of vertices (Nodes)
        private List<int>[] adj;    // Adjacency lists for each vertex (Edges)

        /// <summary>
        /// Constructor to initialize the graph with a given number of vertices
        /// </summary>
        /// <param name="v"></param>
        public Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }


        /// <summary>
        /// Add an edge between vertices v and w
        /// </summary>
        /// <param name="v"></param>
        /// <param name="w"></param>
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        /// <summary>
        /// Perform Breadth-First Search (BFS) starting from vertex s
        /// </summary>
        /// <param name="s"></param>
        public void BFS(int s)
        {
            bool[] visited = new bool[V];           
            Queue<int> queue = new Queue<int>();    

            visited[s] = true;                      
            queue.Enqueue(s);                       

            while (queue.Count != 0)
            {
                s = queue.Dequeue();               
                Console.Write(s + " ");

                // Get all adjacent vertices of the dequeued vertex (neighbors)
                foreach (int n in adj[s])
                {
                    // If an adjacent vertex has not been visited, mark it as visited and enqueue it.
                    if (!visited[n])
                    {
                        visited[n] = true;
                        queue.Enqueue(n);
                    }
                }
            }
        }
    }
}
