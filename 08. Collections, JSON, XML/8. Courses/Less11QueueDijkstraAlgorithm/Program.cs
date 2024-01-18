namespace Less11QueueDijkstraAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dijkstra's algorithm - https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm
            // Graph coloring - https://en.wikipedia.org/wiki/Graph_coloring

            
            Dijkstra graph = new Dijkstra(6);

            graph.AddEdge(0, 1, 2);
            graph.AddEdge(0, 2, 4);
            graph.AddEdge(1, 2, 1);
            graph.AddEdge(1, 3, 7);
            graph.AddEdge(2, 3, 3);
            graph.AddEdge(3, 4, 2);
            graph.AddEdge(4, 5, 5);

            graph.FindShortestPath(1);
            Console.ReadKey();
        }
    }
}