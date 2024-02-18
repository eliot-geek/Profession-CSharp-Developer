namespace Less01GeneralizationsConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // It's generally not considered a good practice to use object.
            // Use object type cautiously for handling heterogeneous collections or unknown types.


            MyClass object1 = new MyClass();
            object1.MyProperty = 1;                             // implicit conversion
            int i = Convert.ToInt32(object1.MyProperty);        // explicit conversion
            Console.WriteLine(i);

            MyClass object2 = new MyClass();
            object2.MyProperty = "One";
            string str = Convert.ToString(object2.MyProperty);
            Console.WriteLine(str);

            MyClass2 objectStr = new MyClass2();
            objectStr.MyProperty = "Two";
            string stri = Convert.ToString(objectStr.MyProperty);
            Console.WriteLine(stri);

            MyClass object3 = new MyClass();
            object3.MyProperty = 13.0;
            double dbl = Convert.ToDouble(object3.MyProperty);
            Console.WriteLine(dbl);
        }
    }
}
