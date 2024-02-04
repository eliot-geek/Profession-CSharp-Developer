namespace Less09IndexersHistory
{
    internal class SomethingA
    {
        public int[] array;

        /// <summary>
        /// Constructor for SomethingA class.
        /// Initializes an array with values from 1 to 10.
        /// </summary>
        public SomethingA() 
        { 
            array = Enumerable.Range(1, 10).ToArray(); 
        }

        // Indexers

        //public int this[int index]
        //{
        //    get { return this.array[index]; }
        //    set { this.array[index] = value; }
        //}

        // public int Count { get { return this.array.Length; } }
    }


    class SomethingB
    {
        int index;

        /// <summary>
        /// Returns the element corresponding to the current position.
        /// </summary>
        /// <returns></returns>
        public int Current() { return array[index]; }

        /// <summary>
        /// Moves the enumerator to the next element.
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            return ++index < array.Length;
        }

        /// <summary>
        /// Sets the enumerator to its initial position, i.e., before the first element.
        /// </summary>
        public void Reset() { index = -1; }

        int[] array;

        /// <summary>
        /// Constructor for SomethingB class.
        /// Initializes an array with values from 11 to 20 and sets the index to -1.
        /// </summary>
        public SomethingB()
        {
            array = Enumerable.Range(11, 10).ToArray();
            index = -1;
        }

        //public int this[int index]
        //{
        //    get { return this.array[index]; }
        //    set { this.array[index] = value; }
        //}

        //public int Count { get { return this.array.Length; } }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region SomethingA

            var a = new SomethingA();

            for (int i = 0; i < a.array.Length; i++)
            {
                Console.Write($"{a.array[i],3} ");
            }
            
            Console.ReadKey();

            #endregion




            #region SomethingB

            var b = new SomethingB();

            b.Reset();

            while (b.MoveNext())
            {
                Console.Write($"{b.Current(),3} ");
            }

            Console.WriteLine();
            Console.ReadKey();

            b.Reset();

            while (b.MoveNext())
            {
                Console.Write($"{b.Current(),3} ");
            }
            
            Console.ReadLine();

            #endregion
        }
    }
}