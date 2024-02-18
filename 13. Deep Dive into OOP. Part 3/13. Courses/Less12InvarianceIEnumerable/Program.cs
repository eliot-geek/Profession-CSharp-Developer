namespace Less12InvarianceIEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kiwi> listKiwi = new List<Kiwi>()
            {
                new Kiwi()
            };

            List<Bird> listBird = new List<Bird>()
            {
                new Bird()
            };

            List<Animal> listAnimal = new List<Animal>
            {
                new Animal()
            };

            // Covariance makes it possible to use a more specific type than originally specified

            // Assigning a list of Kiwi objects to an IEnumerable of Animal (covariance)
            IEnumerable<Animal> enumerableAnimal = listAnimal;

            // Converting the IEnumerable to a List of Animal
            listAnimal = enumerableAnimal.ToList();


            // Assigning a list of Kiwi objects to an IEnumerable of object (covariance)
            IEnumerable<object> enumerableObject = listKiwi;

            // Converting the IEnumerable to a List of object
            List<object> listObject = enumerableObject.ToList();

            // Iterating over the list of objects and printing their types
            Console.WriteLine("Contents of listObject:");
            foreach (var item in listObject)
            {
                Console.WriteLine(item.GetType());
            }

            // Using listBird
            Console.WriteLine("Contents of listBird:");
            foreach (var bird in listBird)
            {
                Console.WriteLine(bird.GetType());
            }

            // Using listAnimal
            Console.WriteLine("Contents of listAnimal:");
            foreach (var animal in listAnimal)
            {
                Console.WriteLine(animal.GetType());
            }
            Console.ReadLine();
        }
    }
}
