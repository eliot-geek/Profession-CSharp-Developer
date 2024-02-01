namespace Less01Encapsulation
{
    /// <summary>
    /// Class A representing an example class
    /// </summary>
    class A
    {
        /// <summary>
        /// Public property MyProperty
        /// </summary>
        public int MyProperty { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A instanceA = new A();

            instanceA.MyProperty = 42;

            Console.WriteLine($"MyProperty value: {instanceA.MyProperty}");
        }
    }
}
