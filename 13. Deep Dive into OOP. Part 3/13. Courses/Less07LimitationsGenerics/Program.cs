using Less06LimitationsGenericsTypes;

namespace Less07LimitationsGenerics
{
    /// <summary>
    /// Represents a generic class with a field that must have a parameterless constructor.
    /// </summary>
    /// <typeparam name="T">The type of the field, which must have a parameterless constructor.</typeparam>
    class Class1<T> where T : new()
    {
        public T field;

        /// <summary>
        /// Initializes a new instance of the Class1 class with a new instance of type T.
        /// </summary>
        public Class1()
        {
            field = new T();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Add the Less06 link first

            Class1<Worker> worker = new Class1<Worker>();
            Console.WriteLine($"Worker.field is of type: {worker.field.GetType().Name}");

            // Instantiate Class1 with Cat type (requires a parameterless constructor)
            // There should be a default constructor in the Cat class defined in Less06 for this to work.
            Class1<Cat> cat = new Class1<Cat>();
            Console.WriteLine($"Cat.field is of type: {cat.field.GetType().Name}");
        }
    }
}
