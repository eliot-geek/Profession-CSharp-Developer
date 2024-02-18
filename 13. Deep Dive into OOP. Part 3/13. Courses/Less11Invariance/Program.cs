namespace Less11Invariance
{
    internal class Program
    {
        /// <summary>
        /// Base class representing an animal.
        /// </summary>
        class Animal { }

        /// <summary>
        /// Derived class representing a cat.
        /// </summary>
        class Cat : Animal { }

        /// <summary>
        /// Derived class representing a dog.
        /// </summary>
        class Dog : Animal { }

        /// <summary>
        /// Derived class representing a bird.
        /// </summary>
        class Bird : Animal { }

        /// <summary>
        /// Derived class representing a kiwi bird.
        /// </summary>
        class Kiwi : Bird { }

        static void Main(string[] args)
        {
            Kiwi kiwi = new Kiwi();                         // Creating a new instance of Kiwi.
            
            Bird bird = kiwi;                               // Implicitly casting Kiwi to Bird since Kiwi inherits from Bird.
            
            Animal animal = bird;                           // Implicitly casting Bird to Animal since Bird inherits from Animal.
                   animal = kiwi;                           // Assigning kiwi to the animal variable.

            object abstractObject = animal;                 // Boxing the animal reference type into an object type.
            abstractObject = bird;                          // Reassigning abstractObject to refer to the bird object.
            abstractObject = animal;                        // Reassigning abstractObject to refer to the animal object.

            List<Kiwi> listkiwi = new List<Kiwi>();         // Creating a new list to hold Kiwi objects.
                
            List<Bird> listbird = new List<Bird>();         // Creating a new list to hold Bird objects.
            
            List<Animal> listAnimal = new List<Animal>();   // Creating a new list to hold Animal objects.


            // This line is commented out. By default, all types are invariant, meaning we can put in them only what they contain.
            // List<Animal> listanimal = new List<Bird>(); 

            // Do not confuse with that
            //listAnimal.Add(new Cat());    // Adding a new Cat object to the list of Animal objects.
            //listAnimal.Add(new Bird());   // Adding a new Bird object to the list of Animal objects.
            //listAnimal.Add(new Kiwi());   // Adding a new Kiwi object to the list of Animal objects.


            // These lines are commented out. List<Animal> and List<Bird> are not related in any way in the inheritance hierarchy.
            //List<Animal> errorListAnimal = new List<Bird>();  
            //List<Bird> errorListBird = new List<Kiwi>();      

            // Invariance makes it possible to use only the type that is initially specified in the generalization.

        }
    }
}
