using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11QueueDijkstraAlgorithm
{
    /// <summary>
    /// Basic implementation of a priority queue
    /// </summary>
    /// <typeparam name="T">The type of elements in the priority queue.</typeparam>
    class PriorityQueue<T>
    {
        // List to store elements along with their priorities
        private List<Tuple<T, int>> elements = new List<Tuple<T, int>>();

        /// <summary>
        /// Returns the number of elements currently in the priority queue, indicating its size
        /// </summary>
        public int Count 
        { 
            get 
            { 
                return elements.Count; 
            } 
        }

        /// <summary>
        /// Enqueues (Adds) an element with its priority to the priority queue.
        /// </summary>
        /// <param name="item">The element to be enqueued.</param>
        /// <param name="priority">The priority associated with the element.</param>
        public void Enqueue(T item, int priority)
        {
            elements.Add(new Tuple<T, int>(item, priority));
        }


        /// <summary>
        /// Dequeues (removes) the element with the highest (or lowest, depending on the priority) value.
        /// </summary>
        /// <returns>The dequeued element.</returns>
        public T Dequeue()
        {
            int bestIndex = 0;

            // Find the index of the element with the highest (or lowest) priority
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Item2 < elements[bestIndex].Item2)
                {
                    bestIndex = i;
                }
            }

            // Retrieve the best item and remove it from the priority queue
            T bestItem = elements[bestIndex].Item1;
            elements.RemoveAt(bestIndex);
            return bestItem;
        }
    }
}
