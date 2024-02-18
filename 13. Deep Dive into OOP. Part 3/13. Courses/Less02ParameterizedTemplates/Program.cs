namespace Less02ParameterizedTemplates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            // Create an instance of Temporary with double type and initialize it with a double value.
            Temporary<double> template1 = new Temporary<double>(28.99);
            template1.GetPropertyInformation();

            // Create an instance of Temporary with string type and initialize it with a string value.
            Temporary<string> template2 = new Temporary<string>("Value");
            template2.GetPropertyInformation();

            // Create an instance of Temporary with bool type and initialize it with a bool value.
            Temporary<bool> template3 = new Temporary<bool>(false);
            template3.GetPropertyInformation();
        }
    }
}
