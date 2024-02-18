namespace Less03ParameterizedTwoTemplates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary of integers and strings.
            Dictionary<int, string> dictionary = new Dictionary<int, string>();


            // Create an instance of Temporary with double and int types and initialize it with values.
            Temporary<double, int> template1 = new Temporary<double, int>(28.99, 1990);
            template1.GetPropertyInformation();


            // Create an instance of Temporary with string and bool types and initialize it with values.
            Temporary<string, bool> template2 = new Temporary<string, bool>("Value", false);
            template2.GetPropertyInformation();


            // Create an instance of Temporary with bool and double types and initialize it with values.
            Temporary<bool, double> template3 = new Temporary<bool, double>(false, 22.33);
            template3.GetPropertyInformation();
        }
    }
}
