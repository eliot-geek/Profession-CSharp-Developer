namespace Less06LimitationsGenericsTypes
{

    /// <summary>
    /// Represents a generic class with a field that must be a reference type.
    /// </summary>
    /// <typeparam name="T">The type of the field, which must be a reference type.</typeparam>
    class Class1<T> where T : class
    {
        public T Field;
    }

    /// <summary>
    /// Represents a generic class with a field that must be a value type.
    /// </summary>
    /// <typeparam name="T">The type of the field, which must be a value type.</typeparam>
    class Class2<T> where T : struct
    {
        public T Field;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class1

            Class1<Cat> cat1 = new Class1<Cat>();
            Class1<string> string1 = new Class1<string>();


            // Instantiate Class1 with Worker type (impossible due to the class constraint)
            // Impossible because there is a limitation on Class1, Worker is a structure in this case not a class
            //Class1<Worker> worker1 = new Class1<Worker>(); 

            // Instantiate Class1 with double type (impossible due to the class constraint)
            // Impossible because double is a structure, not a class
            //Class1<double> double1 = new Class1<double>(); 

            #endregion



            #region Class2

            Class2<Worker> worker2 = new Class2<Worker>();
            Class2<double> double2 = new Class2<double>();


            // Instantiate Class2 with Cat type (impossible due to the struct constraint)
            //Class2<Cat> cat2 = new Class2<Cat>(); 

            // Instantiate Class2 with string type (impossible due to the struct constraint)
            //Class2<string> string2 = new Class2<string>();

            #endregion
        }
    }
}
