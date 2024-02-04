using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10IEnumerator
{
    /// <summary>
    /// Class responsible for data storage and generation of worker information.
    /// Implements the ICloneable interface for creating a deep copy of the repository.
    /// Implements the IEnumerable interface for iterating over the collection of workers.
    /// </summary>
    internal class Repository : ICloneable, IEnumerable
    {
        /// <summary>
        /// Database of first names.
        /// </summary>
        static readonly string[] firstNames;

        /// <summary>
        /// Database of last names.
        /// </summary>
        static readonly string[] lastNames;

        /// <summary>
        /// Pseudorandom Number Generator.
        /// </summary>
        static Random randomize;

        /// <summary>
        /// Static constructor where data about first and last names are initialized.
        /// </summary>
        static Repository()
        {
            randomize = new Random();

            // Initializing first names in the first name database.
            firstNames = new string[]
            {
                "Agatha",
                "Agnes",
                "Adelaide",
                "Adelina",
                "Aldona",
                "Alima",
                "Amanda",
            };

            // Initializing last names in the last name database.
            lastNames = new string[]
            {
                "Ivanova",
                "Petrova",
                "Vasilieva",
                "Kuznetsova",
                "Kovaleva",
                "Popova",
                "Ponomareva",
                "Dyachkova",
                "Konovalova",
                "Sokolova",
                "Lebedeva",
                "Solovyova",
                "Kozlova",
                "Volkova",
                "Zaitseva",
                "Yershova",
                "Karpova",
                "Shchukina",
                "Vinogradova",
                "Tsvetkova",
                "Kalinina"
            };
        }

        /// <summary>
        /// Database of workers containing information about each worker's name, surname, age, and salary.
        /// </summary>
        public List<Worker> Workers { get; set; }

        /// <summary>
        /// Constructor that populates the Workers database.
        /// </summary>
        /// <param name="Count">Number of workers to be created.</param>
        public Repository(int Count)
        {
            // Allocating memory for storing the Workers database.
            this.Workers = new List<Worker>();

            // Filling in the Workers database. Executed Count times.
            for (int i = 0; i < Count; i++)
            {
                // Adding a new worker to the Workers database.
                this.Workers.Add(
                    new Worker(
                        firstNames[Repository.randomize.Next(Repository.firstNames.Length)],

                        lastNames[Repository.randomize.Next(Repository.lastNames.Length)],

                        randomize.Next(19, 60),

                        randomize.Next(10000, 80000)
                        ));
            }
        }

        /// <summary>
        /// Method for outputting the Workers database to the console.
        /// </summary>
        /// <param name="Text">Auxiliary text that will be printed before the output of the database.</param>
        public void Print(string Text)
        {
            Console.WriteLine(Text);

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($"{"Name",15} {"Lastname",15} {"Age",10} {"Salary",15}");

            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var worker in this.Workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine($"\nTotal: {this.Workers.Count}\n");
        }

        /// <summary>
        /// Method that dismisses workers with a salary greater than the specified one.
        /// </summary>
        /// <param name="MaxSalary">The salary level of the worker who needs to be fired.</param>
        public void DeleteWorkerBySalary(int MaxSalary)
        {
            this.Workers.RemoveAll(e => e.Salary > MaxSalary);
        }

        /// <summary>
        /// Method that dismisses workers with a given name.
        /// </summary>
        /// <param name="CurrentName">Name of the workers to be fired.</param>
        public void DeleteWorkerByName(string CurrentName)
        {
            this.Workers.RemoveAll(e => e.FirstName == CurrentName);
        }

        /// <summary>
        /// Editing worker names.
        /// </summary>
        /// <param name="Index">Index of the worker to be edited.</param>
        /// <param name="NewFirstName">New first name for the worker.</param>
        public void ChangeFirstName(int Index, string NewFirstName)
        {
            this.Workers[Index].FirstName = NewFirstName;
        }

        /// <summary>
        /// ICloneable interface implementation for creating a deep copy of the repository.
        /// </summary>
        /// <returns>A deep copy of the repository.</returns>
        /// <returns>A cloned Repository instance with copied Worker objects.</returns>
        public object Clone()
        {
            var clonedRepository = new Repository(0);

            foreach (var worker in this.Workers)
            {
                clonedRepository.Workers.Add(new Worker(worker.FirstName, worker.LastName, worker.Age, worker.Salary));
            }

            return clonedRepository;
        }

        /// <summary>
        /// Implementation of the IEnumerable interface to allow iteration over the Workers collection.
        /// </summary>
        /// <returns>An enumerator that iterates through the Workers collection.</returns>
        public IEnumerator GetEnumerator()
        {
            // Yields the elements in the Workers collection.
            //yield return this.Workers[0];
            //yield return this.Workers[1];
            //yield return this.Workers[2];

            // Iterates through each element in the Workers collection using a for loop.
            for (int i = 0; i < this.Workers.Count; i++)
            {
                // Returns the current worker at index i, but using 'return' here would terminate the iteration prematurely.
                // return this.Workers[i];

                // Yields the current worker at index i, allowing the iteration to continue smoothly.
                yield return this.Workers[i];
            }



            //// Iterates through each worker in the Workers collection using a foreach loop.
            //foreach (var e in this.Workers)
            //{
            //    // Yields the current worker, allowing the iteration to continue smoothly.
            //    yield return e;
            //}



            // `yield` is used to lazily generate and return values one at a time in a sequence,
            // allowing the method to maintain its state between calls and optimizing memory usage for large datasets.
        }
    }
}
