using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11QueueDijkstraAlgorithm
{
    class Dijkstra
    {
        // Number of vertices in the graph
        private int NumberOfVertices;

        // Adjacency lists with edge weights
        private List<Tuple<int, int>>[] AdjacencyLists;        

        /// <summary>
        /// Constructor to initialize the Dijkstra's algorithm implementation 
        /// </summary>
        /// <param name="numberOfVertices">The number of vertices in the graph</param>
        public Dijkstra(int numberOfVertices)
        {
            NumberOfVertices = numberOfVertices;
            AdjacencyLists = new List<Tuple<int, int>>[numberOfVertices];
            for (int i = 0; i < numberOfVertices; i++)
            {
                AdjacencyLists[i] = new List<Tuple<int, int>>();
            }
        }


        /// <summary>
        /// Add an edge between two vertices in a graph, along with an associated weight
        /// </summary>
        /// <param name="source">The source vertex from which the edge originates</param>
        /// <param name="target">The target vertex to which the edge leads</param>
        /// <param name="weight">The weight or cost associated with the edge</param>
        public void AddEdge(int source, int target, int weight)
        {
            AdjacencyLists[source].Add(new Tuple<int, int>(target, weight));
            AdjacencyLists[target].Add(new Tuple<int, int>(source, weight));
        }

        /// <summary>
        /// Finding the shortest path using Dijkstra's algorithm
        /// </summary>
        /// <param name="source">Source vertex for finding the shortest paths</param>
        public void FindShortestPath(int source)
        {
            int[] distance = new int[NumberOfVertices];
            for (int i = 0; i < NumberOfVertices; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;

            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(source, 0);

            while (priorityQueue.Count > 0)
            {
                int u = priorityQueue.Dequeue();
                foreach (var neighbor in AdjacencyLists[u])
                {
                    int v = neighbor.Item1;
                    int weight = neighbor.Item2;

                    int newDistance = distance[u] + weight;
                    if (newDistance < distance[v])
                    {
                        distance[v] = newDistance;
                        priorityQueue.Enqueue(v, newDistance);
                    }
                }
            }

            for (int i = 0; i < NumberOfVertices; i++)
            {
                Console.WriteLine($"Shortest distance from {source} to {i} is {distance[i]}");
            }
        }
    }
}
