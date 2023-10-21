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
    /// <typeparam name="T"></typeparam>
    class PriorityQueue<T>
    {
        private List<Tuple<T, int>> elements = new List<Tuple<T, int>>();

        /// <summary>
        /// Property
        /// </summary>
        /// returns the number of elements currently in the priority queue, indicating its size
        public int Count { get { return elements.Count; } }
        
        /// <summary>
        /// Enqueue method (Add)
        /// </summary>
        /// <param name="item"></param>
        /// <param name="priority"></param>
        public void Enqueue(T item, int priority)
        {
            elements.Add(new Tuple<T, int>(item, priority));
        }

        /// <summary>
        /// Dequeues (removes) the element with the highest (or lowest, depending on the priority) value
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            int bestIndex = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Item2 < elements[bestIndex].Item2)
                {
                    bestIndex = i;
                }
            }

            T bestItem = elements[bestIndex].Item1;
            elements.RemoveAt(bestIndex);
            return bestItem;
        }
    }
}
