namespace Less16ClassStatic
{
    /// <summary>
    /// A static class demonstrating the use of static members.
    /// </summary>
    static class StaticClass
    {
        /// <summary>
        /// Static Constructor for StaticClass, executed upon the first access to the class.
        /// </summary>
        static StaticClass()
        {
            Console.WriteLine("The first appeal to StaticClass");
            id = 0;
        }

        /// <summary>
        /// Static field representing an ID.
        /// </summary>
        static int id;

        /// <summary>
        /// Gets or sets the static ID.
        /// </summary>
        public static int Id 
        { 
            get 
            { 
                return id; 
            } 
            set 
            { 
                id = value; 
            } 
        }

        /// <summary>
        /// Sets the static ID with the provided value.
        /// </summary>
        /// <param name="value">Value to set as the ID.</param>
        static public void SetId(int value)
        {
            id = value;
        }

        /// <summary>
        /// Gets the current static ID.
        /// </summary>
        /// <returns>Current ID value.</returns>
        public static int GetId()
        {
            return id;
        }

        /// <summary>
        /// Overrides the default ToString method to provide a custom string representation.
        /// </summary>
        /// <returns>String representation of the static class state.</returns>
        public static new string ToString()
        {
            return $"Id = {id}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrating the use of static members in StaticClass.

            Console.WriteLine(StaticClass.Id);

            StaticClass.SetId(100);

            Console.WriteLine(StaticClass.GetId());

            StaticClass.Id = 300;

            Console.WriteLine(StaticClass.ToString());
        }
    }
}
