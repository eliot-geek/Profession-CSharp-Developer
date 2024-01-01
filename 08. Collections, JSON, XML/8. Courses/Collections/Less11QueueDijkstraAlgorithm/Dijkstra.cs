using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11QueueDijkstraAlgorithm
{
    /// <summary>
    /// Dijkstra's Algorithm
    /// </summary>
    class Dijkstra
    {
        private int V;                          // Number of vertices in the graph
        private List<Tuple<int, int>>[] adj;    // Adjacency lists with edge weights

        /// <summary>
        /// Constructor to initialize the Dijkstra's algorithm implementation 
        /// </summary>
        /// <param name="v">The number of vertices in the graph</param>
        public Dijkstra(int v)
        {
            V = v;
            adj = new List<Tuple<int, int>>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Tuple<int, int>>();
            }
        }

        /// <summary>
        /// Add an edge between two vertices in a graph, along with an associated weight
        /// </summary>
        /// <param name="v">The source vertex from which the edge originates</param>
        /// <param name="w">The target vertex to which the edge leads</param>
        /// <param name="weight">The weight or cost associated with the edge</param>
        public void AddEdge(int v, int w, int weight)
        {
            adj[v].Add(new Tuple<int, int>(w, weight));
            adj[w].Add(new Tuple<int, int>(v, weight));
        }

        /// <summary>
        /// Finding the shortest path
        /// </summary>
        /// <param name="source">source vertex</param>
        public void FindShortestPath(int source)
        {
            int[] distance = new int[V];
            for (int i = 0; i < V; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;
            
            PriorityQueue<int> queue = new PriorityQueue<int>();
            queue.Enqueue(source, 0);

            while (queue.Count > 0)
            {
                int u = queue.Dequeue();
                foreach (var neighbor in adj[u])
                {
                    int v = neighbor.Item1;
                    int weight = neighbor.Item2;

                    int newDistance = distance[u] + weight;
                    if (newDistance < distance[v])
                    {
                        distance[v] = newDistance;
                        queue.Enqueue(v, newDistance);
                    }
                }
            }

            for (int i = 0; i < V; i++)
            {
                Console.WriteLine($"Shortest distance from {source} to {i} is {distance[i]}");
            }
        }
    }
}
