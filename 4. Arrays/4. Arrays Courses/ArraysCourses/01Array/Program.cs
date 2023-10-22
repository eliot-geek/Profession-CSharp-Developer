namespace _01Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an array of integers
            int[] x;

            // The array is declared with the 'new' keyword, followed by information about the data type and the number of elements in the array.
            // This is a fixed number of elements that the array can contain. 
            // When the array is created, the elements will automatically be assigned default data for that type. (numbers - zeros, bool - false, etc.)

            x = new int[3];                 // an int array of 3 elements
            double[] array = new double[5]; // a double array of 5 elements

            // To fill the elements of the array, you need to specify its number in square brackets. Note that the index of the first element starts at zero.

            // Assigning values to the elements of the integer array 'x'
            x[0] = 1;       // assigning 1 to the first element
            x[1] = 12;      // assigning 12 to the second element
            x[2] = 223;     // assigning 223 to the third element

            // Assigning values to the elements of the double array 'array'
            array[0] = 3;       // assigning 03 to the first element
            array[1] = 5;       // assigning 05 to the second element
            array[2] = 8;       // assigning 08 to the third element
            array[3] = 13;      // assigning 13 to the fourth element
            array[4] = 21;      // assigning 21 to the fifth element

            int[] birthdayCollection = new int[8] { 2, 8, 0, 9, 1, 9, 9, 0 };   // Declaring and initializing an integer array 'birthdayCollection' with 8 elements
            int[] newYearCollection = new int[] { 31, 12, 2319 };               // Declaring and initializing an integer array 'newYearCollection' with 3 elements
            string[] dateCollection = { "01", "01", "1771" };                   // Declaring and initializing a string array 'dateCollection' with 3 elements


            // ┌───────────────────────────────────────────┐
            // │    ┌────────┐   ┌────────┐   ┌────────┐   │
            // │    │   31   │   │   12   │   │  1771  │   │
            // │    └────────┘   └────────┘   └────────┘   │
            // │         0            1           2        │
            // └───────────────────────────────────────────┘
            //               newYearCollection              


            // birthdayCollection[0]
            // birthdayCollection[1]
            // birthdayCollection[2]
            // Индексы меняются от 0 до 2                               
        }
    }
}