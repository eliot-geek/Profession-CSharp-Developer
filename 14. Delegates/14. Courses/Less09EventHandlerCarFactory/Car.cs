using System;
using System.Threading;

namespace Less09EventHandlerCarFactory
{
    /// <summary>
    /// Represents a Car class responsible for creating car objects.
    /// </summary>
    internal class Car
    {
        /// <summary>
        /// Event triggered when a new car is created.
        /// </summary>
        public static event Action<string, int> CreateCar;

        private static int count;           
        private static Random random;       

        /// <summary>
        /// Static constructor initializes static fields.
        /// </summary>
        static Car()
        {
            count = 0;
            random = new Random();
        }

        /// <summary>
        /// Constructs a new instance of the Car class.
        /// </summary>
        /// <param name="mark">The car's brand.</param>
        /// <param name="model">The car's model.</param>
        /// <param name="engine">The car's engine size.</param>
        public Car(string mark, string model, double engine)
        {
            Mark = mark;
            Model = model;
            Engine = engine;

            count++;

            // Simulate production time delay
            Thread.Sleep(random.Next(1000, 3000));

            // Invoke the CreateCar event, notifying subscribers that a new car has been produced.
            CreateCar?.Invoke($"The Car was produced at {DateTime.Now.ToShortTimeString()}. Parameters {Mark} {Model} {Engine}", count);
        }

        /// <summary>
        /// Gets a string representation of the car.
        /// </summary>
        /// <returns>A string representing the car's brand, model, and engine size.</returns>
        public override string ToString()
        {
            return $"{this.Mark} {this.Model} {this.Engine}";
        }

        /// <summary>
        /// Gets or sets the car's brand.
        /// </summary>
        public string Mark { get; set; }

        /// <summary>
        /// Gets or sets the car's model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the car's engine size.
        /// </summary>
        public double Engine { get; set; }
    }
}
