﻿using System.Xml.Linq;

namespace HandbookEmployees
{
    internal class Program
    {
        /// <summary>
        /// Checking the existence of a file
        /// </summary>
        /// <param name="path"></param>
        static void InputFileExists(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"File worker.txt not found. Creating a default file");
                InputFile(path);
            }
        }

        /// <summary>
        /// Input in the File
        /// </summary>
        /// <param name="path"></param>
        static void InputFile(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter("worker.csv", true))
            {
                char key = 'y';
                do
                {
                    string note = string.Empty;
                    Console.Write("\nEnter ID: ");
                    note += $"{Console.ReadLine()}#";

                    string now = DateTime.Now.ToShortDateString();
                    string now1 = DateTime.Now.ToShortTimeString();
                    Console.Write($"Date and Time : {now} {now1} ");
                    note += $"{now} {now1}#";

                    Console.Write($"\nEnter fullname: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write($"Enter age: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write($"Enter height: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write($"Enter DateOfBirth (dd.mm.yyyy) : ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write($"Enter PlaceOfBirth: ");
                    note += $"{Console.ReadLine()}";

                    // create a string with the new employee's data
                    // string newEmployee = $"{id}#{DateTime.Now.ToString()}#{name}#{age}#{height}#{dateOfBirth}#{placeOfBirth}";

                    streamWriter.WriteLine(note);

                    Console.Write("Add a new worker y/n");
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'y');
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Read From The File
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static void ReadInputFile(string path)
        {
            using (StreamReader streamReader = new StreamReader("worker.csv"))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line.Replace("#", "\t")); // replace # delimiter with tab for better display
                }
            }
        }

        static void Main(string[] args)
        {
            string worker = @"worker.csv";

            Console.WriteLine("Choose an option: \n" +
            "Enter 1 to display the data on the screen\n" +
            "Enter 2 to fill out the data and add a new record to the end of the file");

            switch (Console.ReadLine())
            {
                case "1":
                    InputFileExists(worker);
                    ReadInputFile(worker);
                    break;
                case "2":
                    InputFileExists(worker);
                    InputFile(worker);
                    ReadInputFile(worker);
                    break;
                default:
                    Console.WriteLine("You picked up the wrong number. Pick 1 or 2");
                    break;
            }
        }
    }
}