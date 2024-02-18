
// IComparable<in T>
namespace Less14Contravariance
{
    /// <summary>
    /// Abstract class representing an animal.
    /// </summary>
    abstract class Animal
    {
        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class with the specified name.
        /// </summary>
        /// <param name="Name">The name of the animal.</param>
        public Animal(string Name)
        {
            this.Name = Name;
        }
    }

    /// <summary>
    /// Derived class representing a bird.
    /// </summary>
    class Bird : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class with the specified name.
        /// </summary>
        /// <param name="Name">The name of the bird.</param>
        public Bird(string Name) : base(Name) { }
    }


    #region ToDo Important

    // interface IAnimal<in T>

    // T GetAnimal { get; set; }
    // void Method(T args);

    // Error CS1961  Unacceptable deviation:
    // Type parameter "T" must be covariant, valid for "IAnimal<T>.a()".
    // "T" is contravariant. Less14Contravariance  

    #endregion


    /// <summary>
    /// Contravariant interface for animals.
    /// </summary>
    /// <typeparam name="T">Type of animal</typeparam>
    /// <remarks>
    /// This interface allows setting the value of type T.
    /// </remarks>
    interface IAnimal<in T> where T : Animal        // Contravariance
                                                    // interface IAnimal<T> where T : Animal (doesn't work without the <in T>
    {
        /// <summary>
        /// Sets the value of type T.
        /// </summary>
        T SetValue { set; }

        /// <summary>
        /// Sets the value of type T using a method.
        /// </summary>
        /// <param name="args">The value to set.</param>
        void SetValueMethod(T args);
    }


    /// <summary>
    /// Generic class representing a storage for animals.
    /// </summary>
    /// <typeparam name="T">Type of animal</typeparam>
    /// <remarks>
    /// This class implements the <see cref="IAnimal{T}"/> interface and stores animals in a list.
    /// </remarks>
    class Storage<T> : IAnimal<T> where T : Animal
    {
        /// <summary>
        /// List to store animals.
        /// </summary>
        private List<Animal> db;

        /// <summary>
        /// Initializes a new instance of the <see cref="Storage{T}"/> class.
        /// </summary>
        public Storage()
        {
            db = new List<Animal>();
        }

        /// <summary>
        /// Sets the value of type T and adds it to the storage.
        /// </summary>
        public T SetValue
        {
            set => db.Add(value);
        }

        /// <summary>
        /// Sets the value of type T using a method and adds it to the storage.
        /// </summary>
        /// <param name="args">The value to set.</param>
        public void SetValueMethod(T args)
        {
            db.Add(args);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Contravariance makes it possible to use a more universal type than the one originally specified

            // Error CS0266 Cannot implicitly convert type 'Less14Contravariance.Storage<Less14Contravariance.Animal>' 
            // to 'Less14Contravariance.IAnimal<Less14Contravariance.Bird>'. 
            // There is an explicit conversion; consider casting.


            IAnimal<Bird> concreteStorage = new Storage<Animal>();

            #region ToDo
            
            concreteStorage.SetValueMethod(new Bird("concreteBird"));
            Console.WriteLine("Added new Bird to the storage.");

            #endregion

            Console.ReadLine();


            // All arrays are contravariant

            object[] vs = new string[10];

            // Adding elements of different types to the array

            vs[1] = "string";       // Valid, since string is already of type object
            vs[0] = 1;              // Valid, since int can be implicitly boxed to object
            vs[2] = 2.0;            // Invalid, since double cannot be implicitly cast to string

            // Attempting to access an element with a type incompatible with the array throws an exception
            // System.ArrayTypeMismatchException: "Attempted to access an element as a type incompatible with the array."

            Console.ReadLine();
        }
    }
}
