using System.Collections;
using System.Diagnostics;
using System.IO.Compression;

namespace DivisibleNumberPartition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Task
             Having written all numbers from 1 to N on the board, where N is 50, the teacher divided the numbers into several groups in such a way that if one number is 
             divisible by another, then these numbers belong to different groups. As a result of this division, M groups were formed, where for N=50, M=6.

             N = 50
             The groups are as follows:

             Group 1: 1
             Group 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
             Group 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
             Group 4: 8 12 18 20 27 28 30 42 44 45 50
             Group 5: 16 24 36 40
             Group 6: 32 48

             M = 6

             ===================

             For N = 10, the groups are as follows:

             Group 1: 1
             Group 2: 2 7 9
             Group 3: 3 4 10
             Group 4: 5 6 8

             M = 4

             Adding the following capabilities to it:

             1. The program reads from a file (the path to which can be specified) some N, for which the number of groups needs to be calculated. The program works with numbers N not exceeding 1_000_000_000.
             2. It has two operation modes:
             2.1. The first - only the number of groups, i.e., the value of M, is displayed in the console.
             2.2. The second - the program receives the filled groups and writes them to a file using one of the file handling options.
             3. After performing steps 2.1 or 2.2, the console displays the time taken to generate the result in seconds and milliseconds.
             4. After completing step 2.2, the program offers to archive the data, and if the user agrees, it does so.
             When completing the current task, it is necessary to document the code, both with comments and XML documentation. 
             It is mandatory to create several custom methods.  */

            string inputFile = @"inputNumber.txt";
            InputFileExists(inputFile);
            Console.WriteLine("Loading a specified number from the file...");
            int number = ReadInputFile(inputFile);                     // Read txt file
            int[][] result = new int[NumberOfGroups(number)][];        // Jagged array for storing sequences of numbers
            result[0] = new int[] { 1 };                               // The first sequence is 1
            Stopwatch sv = new Stopwatch();                            // Timer for measuring the task execution time

            Console.WriteLine("Number in the file = " + number);
            Console.WriteLine();
            Console.WriteLine("Choose a mode of operation: \n" +
            "1 (First ) - Only the number of groups (M) is shown in the console\n" +
            "2 (Second) - Will not handle a billion!! The program receives filled groups and writes them to a file using one of the file handling methods\n" +
            "3 (Third ) - Will handle a billion values!! The program receives filled groups using the Sieve of Eratosthenes method and writes them to a file.");

            switch (Console.ReadLine())
            {
                // Show only the number of groups, i.e. the value of M
                case "1":
                    int[] range = new int[number - 2];
                    sv.Start();
                    Console.WriteLine("Number of groups: " + NumberOfGroups(number));
                    sv.Stop();
                    PrintTime(sv);
                    break;
                // Execute the algorithm for counting groups of numbers by brute force and write them to a file
                case "2":
                    sv.Start();
                    Console.WriteLine("Array of numbers from 1 to the given number");
                    range = new int[number - 2];
                    range = Enumerable.Range(2, number).ToArray();

                    for (int i = 1; i < result.Length; i++)
                    {
                        result[i] = GetSequence(range);                     // Find the required sequence
                        range = range.Except<int>(result[i]).ToArray();     // Subtract the obtained sequence from our sequence
                    }
                    sv.Stop();
                    PrintTime(sv);

                    Console.WriteLine("Writing results in the file \"outputNumber.txt\"");
                    string outfile = @"outputNumber.txt";
                    SaveToFile(outfile, result);

                    Console.WriteLine("Saving to the file completed! Look for it in the folder\n");
                    Console.WriteLine("Compress the obtained file? \n" + "1 - Yes\n" + "0 - No, just exit the program");
                    
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Compress(outfile, "archiveOutputNumber.zip");
                            Console.WriteLine("File compressed. Look for it in the folder with the zip file");
                            break;
                        case "0":
                            break;
                    }
                    break;

                // The Sieve of Eratosthenes is an algorithm for finding all prime numbers up to a given integer n, 
                // attributed to the ancient Greek mathematician Eratosthenes of Cyrene.
                case "3":
                    Console.WriteLine("Array of numbers from 1 to the given number");
                    sv.Start();
                    BitArray numbers = new BitArray(number);
                    numbers[0] = true;
                    sv.Stop();
                    PrintTime(sv);
                    Console.WriteLine();
                    Console.WriteLine("Starting calculation of number sequences...\n");
                    sv = new Stopwatch();
                    sv.Start();
                    for (int i = 0; i < result.Length; i++)
                    {
                        Stopwatch s = new Stopwatch();
                        s.Start();
                        BitArray buffer = SieveOfEratosthenes(numbers);
                        numbers = ReversBool(numbers, buffer);
                        result[i] = FromBitToInt(buffer).Where(x => x >= 2).ToArray();
                        s.Stop();
                        Console.WriteLine($"Sequence № {i,3} formed in {s.Elapsed.TotalSeconds,15} sec and {s.Elapsed.TotalMilliseconds,15} ms.");
                    }
                    sv.Stop();
                    PrintTime(sv);

                    Console.WriteLine("\nWriting results in the file \"outputNumber2.txt\"");
                    string outfile2 = @"outputNumber2.txt";
                    SaveToFile(outfile2, result);

                    Console.WriteLine("Saving to file completed! Look for it in the folder\n");
                    Console.WriteLine("Compress the obtained file? \n" + "1 - Yes\n" + "0 - No, just exit the program");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Compress(outfile2, "archiveOutputNumber2.zip");
                            Console.WriteLine("File compressed. Look for it in the folder with the zip file");
                            break;
                        case "0":
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Check if input file exists at the given path 
        /// Checking the existence of an input file.
        /// </summary>
        /// <param name="path">Path to file</param>
        static void InputFileExists(string path)
        {
            // If file does not exist at the given path
            if (!File.Exists(path))
            {
                // Print message indicating file was not found and a default file will be created
                Console.WriteLine($"File inputNumber.txt not found. Creating a default file.");
                // Create a default file named inputNumber.txt with write permission
                using (StreamWriter sw = new StreamWriter(new FileStream(@"inputNumber.txt", FileMode.Create)))
                {
                    // Write a default value of 100 to the file
                    sw.WriteLine("100");
                }
            }
        }

        /// <summary>
        /// This method reads an integer from a file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static int ReadInputFile(string path)
        {
            // Open a stream reader to read the file at the specified path
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                // Read a single line from the file and parse it to an integer
                return int.Parse(sr.ReadLine());
            }
        }

        /// <summary>
        /// This method calculates the number of groups of numbers that are not divisible by each other
        /// </summary>
        /// <param name="number"> It takes an integer parameter "number" which represents the number of integers in the sequence starting from zero</param>
        /// <returns> It returns an integer value which represents the number of groups of numbers that are not divisible by each other</returns>
        static int NumberOfGroups(int number)
        {
            int count = 1;
            while (number > 1)
            {
                number /= 2;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Method to print the time taken by the algorithm in seconds and milliseconds
        /// </summary>
        /// <param name="sv">Stopwatch</param>
        static void PrintTime(Stopwatch sv)
        {
            Console.WriteLine("\nTime taken by the algorithm in seconds: " + sv.Elapsed.TotalSeconds + 
                " seconds." + " And in milliseconds: " + sv.Elapsed.TotalMilliseconds + " milliseconds.");
        }

        /// <summary>
        /// This method returns a sequence of numbers that are not divisible by each other
        /// </summary>
        /// <param name="array">Array of numbers</param>
        /// <returns>Sequence of numbers that are not divisible by each other</returns>
        static int[] GetSequence(int[] array)
        {
            // Create a new array with the same length as the input array and copy its values
            int[] buffArray = new int[array.Length];
            array.CopyTo(buffArray, 0);
            bool flag = true;

            // Iterate over the array
            for (int i = 0; i * 2 < buffArray.Length; i++)
            {
                // Check if the current element is not zero
                if (buffArray[i] != 0)
                {
                    // Iterate over the remaining elements in the array
                    for (int j = i; j < buffArray.Length; j++)
                    {
                        // If the current element is divisible by the previous element and the quotient is greater than 1, set it to zero
                        // This means that any element that is a multiple of a previous element will be removed from the sequence.
                        if (buffArray[j] % buffArray[i] == 0 && buffArray[j] / buffArray[i] > 1)
                        {
                            buffArray[j] = 0;
                            flag = false;
                        }
                    }
                }
            }
            // If some elements were set to zero, recursively call this method on the modified array
            if (!flag) 
                return GetSequence(buffArray);
            // Otherwise, return the sequence as an array, skipping the zeros
            else
                return buffArray.Where(x => x != 0).ToArray(); // Store the sequence in an array, skipping zeros
        }

        /// <summary>
        /// Compresses a file
        /// </summary>
        /// <param name="source">Source file</param>
        /// <param name="compressed">Output compressed file</param>
        static void Compress(string source, string compressed)
        {
            if (!File.Exists(source))
                Console.WriteLine("File does not exist! Create a file for compression or check the path for correctness");
            else
            {
                using (FileStream sourcefile = new FileStream(source, FileMode.OpenOrCreate))
                {
                    // stream for writing compressed file
                    using (FileStream compressedfile = File.Create(compressed)) 
                    {
                        // compression stream
                        using (GZipStream archivefile = new GZipStream(compressedfile, CompressionMode.Compress))
                        {
                            // copy bytes from one stream to another
                            sourcefile.CopyTo(archivefile); 
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method for saving a two-dimensional array of integers to a file
        /// Saving the calculation result to a file
        /// </summary>
        /// <param name="name">Path to the file</param>
        /// <param name="array">Array to be saved</param>
        static void SaveToFile(string name, int[][] array)
        {
            // Get the filename
            string fileName = name;
            // Check if the file already exists and delete it if it does
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            // Open a stream to write to the file
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write)))
            {
                // Iterate over each row in the array
                for (int i = 0; i < array.Length; i++)
                {
                    // Write the row to the file as a string using the PrintArray method
                    sw.WriteLine(PrintArray(array[i]));
                    // Flush the buffer to ensure that all data is written to the file
                    sw.Flush();
                }
            }
        }

        /// <summary>
        /// Method that receives an integer array and returns a string representation of it
        /// Converts a one-dimensional array to a string
        /// </summary>
        /// <param name="array">One-dimensional array of numbers</param>
        /// <returns>Returns a string</returns>
        static string PrintArray(int[] array)
        {
            // Create a string variable to hold the result
            string result = null;
            // Iterate over each element of the input array
            foreach (int item in array)
            {
                // Append each element to the result string, followed by a space
                result += item + " ";
            }
            // Return the result string
            return result;
        }

        /// <summary>
        /// This method compares two BitArrays and replaces the elements in the first BitArray that are contained in the second BitArray with zeros
        /// it means that any elements in the first array that have the same index as an element in the second array that is also non-zero will be replaced with zero.
        /// For example, if the first array has the elements [1, 2, 3, 4] and the second array has the elements [0, 2, 0, 5], 
        /// the method will return a new BitArray with the elements [0, 2, 0, 0].
        /// </summary>
        /// <param name="arr1">The first BitArray to be modified.</param>
        /// <param name="arr2">The second BitArray to compare with.</param>
        /// <returns>Returns the first BitArray with elements from the second BitArray replaced with zeros.</returns>
        static BitArray ReversBool(BitArray arr1, BitArray arr2)
        {
            BitArray result = new BitArray(arr1);
            // Loop through all elements of the result array
            for (int i = 0; i < result.Length; i++)
            {
                // Check if the corresponding elements in both arrays are equal to false
                if (arr1[i] == arr2[i] && !arr1[i])
                    // If they are, replace the element in the result array with true
                    result[i] = !arr1[i];
            }
            return result;
        }

        /// <summary>
        /// This method calculates the sequence of prime numbers using the "Sieve of Eratosthenes" algorithm
        /// The Sieve of Eratosthenes is an algorithm for finding all prime numbers up to a given integer n, attributed to the ancient Greek mathematician Eratosthenes of Cyrene.
        /// </summary>
        /// <param name="list">The input parameter is an initial bit array, where unnecessary elements are replaced with true</param>
        /// <returns>The method returns an array, where false represents prime numbers</returns>
        static BitArray SieveOfEratosthenes(BitArray list)
        {
            // Create a new bit array from the input array
            BitArray arr = new BitArray(list);
            // Loop through the array to find prime numbers
            for (int i = 2; i * 2 < arr.Length; i++)
            {
                // If the current number is not marked as composite (not true in the input array). If the number is not marked as composite, it means that it is a prime number.
                if (!list[i])
                {
                    for (int j = i * 2; j < arr.Length; j += i)
                    {
                        // Mark all multiples of the current number as composite (true in the output array)
                        arr[j] = true;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Converts a BitArray to an int array where each number corresponds to the index of the bit in the original array
        /// </summary>
        /// <param name="array">The BitArray to convert</param>
        /// <returns>An array where each number represents the index of the corresponding bit in the input array</returns>
        static int[] FromBitToInt(BitArray array)
        {
            int[] result = new int[array.Length];
            for (int j = 1; j < array.Length; j++)
            {
                // If the bit is not true, set the corresponding element in the result array to its index
                if (!array[j])
                    result[j] = j;
                // Otherwise, set the corresponding element in the result array to 0
                else
                    result[j] = 0;
            }
            return result;
        }

    }
}