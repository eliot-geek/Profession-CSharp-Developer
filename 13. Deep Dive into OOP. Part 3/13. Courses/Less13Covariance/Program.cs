namespace Less13Covariance
{
    /// <summary>
    /// Abstract class representing an animal.
    /// </summary>
    abstract class Animal
    {
        public string Name { get; private set; }

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
        public Bird(string Name) : base(Name)
        {

        }
    }

    #region ToDo Important

    // interface IAnimal<out T>
    // Covariant interface for animals.

    // T GetAnimal { get; set; }
    // void Method(T args);
    // Error CS1961 Unacceptable deviation

    // Type parameter "T" must be invariant, valid for "IAnimal<T>.GetAnimal".
    // "T" is covariant. Less13Covariance

    #endregion

    /// <summary>
    /// Covariant interface for animals.
    /// </summary>
    /// <typeparam name="T">Type of animal</typeparam>
    interface IAnimal<out T> where T : Animal
        // interface IAnimal<T> where T : Animal (it doesn't work, but if you add "out" <out T>, it will work)
    {
        /// <summary>
        /// Gets the value of type T.
        /// </summary>
        T GetValue { get; }

        /// <summary>
        /// Gets the value of type T using a method.
        /// </summary>
        /// <returns>The value of type T</returns>
        T GetValueMethod();
    }

    /// <summary>
    /// Derived class representing a kiwi bird.
    /// </summary>
    class Kiwi : IAnimal<Bird>
    {
        /// <summary>
        /// Property to get the value of type Bird.
        /// </summary>
        public Bird GetValue 
        { 
            get 
            { 
                return new Bird("KiwiBirdP"); 
            } 
        }

        /// <summary>
        /// Method to get the value of type Bird.
        /// </summary>
        /// <returns>A new Bird object representing a kiwi bird</returns>
        public Bird GetValueMethod() 
        { 
            return new Bird("KiwiBirdM"); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kiwi kiwi = new Kiwi();
            IAnimal<Bird> birdAnimal = kiwi;

            // Forbidden because the types are invariant
            // IAnimal<Animal> animalIAnimal = kiwi;

            // But possible with "out T" on IAnimal interface "interface IAnimal<out T> where T : Animal"
            IAnimal<Animal> animalIAnimal = kiwi;

            Console.WriteLine("Type of birdAnimal: " + birdAnimal.GetValue.GetType().Name);
            Console.WriteLine("Type of animalIAnimal: " + animalIAnimal.GetValue.GetType().Name);

            // Accessing the GetValue property and printing the returned Bird object
            //Bird birdP = kiwi.GetValue;
            Console.WriteLine("Value returned by GetValue property: " + kiwi.GetValue.Name);

            //Bird birdM = kiwi.GetValueMethod();
            Console.WriteLine("Value returned by GetValueMethod method: " + kiwi.GetValueMethod().Name);

            // Covariance makes it possible to use a more specific type than originally specified
        }
    }
}
