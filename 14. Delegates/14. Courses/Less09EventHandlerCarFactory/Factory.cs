using System;
using System.Collections.Generic;

namespace Less09EventHandlerCarFactory
{
    /// <summary>
    /// Represents a Factory class responsible for producing cars.
    /// </summary>
    internal class Factory
    {
        private int count;              
        static private Random random;  

        /// <summary>
        /// Static constructor initializes static fields.
        /// </summary>
        static Factory()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructs a new instance of the Factory class.
        /// </summary>
        /// <param name="Count">The total number of cars to be produced.</param>
        public Factory(int Count)
        {
            this.count = Count;

            // Subscribe to the CreateCar event of the Car class
            Car.CreateCar += Car_CreateCar;
        }

        /// <summary>
        /// Event handler for the Car's CreateCar event.
        /// </summary>
        /// <param name="Msg">Message indicating car production information.</param>
        /// <param name="Number">Total number of cars produced.</param>
        private void Car_CreateCar(string Msg, int Number)
        {
            Console.WriteLine($"Factory: {Msg}. Total {Number}");
        }

        /// <summary>
        /// Produces a list of cars based on the specified count.
        /// </summary>
        /// <returns>List of Car objects produced by the factory.</returns>
        public List<Car> ToProduce()
        {
            List<Car> cars = new List<Car>();

            for (int i = 0; i < this.count; i++)
            {
                cars.Add(new Car(
                    mark: $"Mark_{random.Next(1, 6)}",
                    model: $"Model_{random.Next(1, 6)}",
                    engine: random.Next(1, 3) + Math.Round(random.NextDouble(), 1)
                    ));
            }

            return cars;
        }
    }
}
