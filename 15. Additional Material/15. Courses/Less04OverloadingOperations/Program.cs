namespace Less04OverloadingOperations
{
    internal class Program
    {
        /// <summary>
        /// Represents a class with a single integer property.
        /// </summary>
        class MyClass
        {
            /// <summary>
            /// Gets or sets the integer property of the class.
            /// </summary>
            public int MyProperty { get; set; }

            /// <summary>
            /// Overloads the addition operator (+) to add the properties of two instances of MyClass.
            /// </summary>
            /// <param name="x">The first instance of MyClass.</param>
            /// <param name="y">The second instance of MyClass.</param>
            /// <returns>A new instance of MyClass with the sum of the properties of x and y.</returns>
            public static MyClass operator +(MyClass x, MyClass y)
            {
                return new MyClass() { MyProperty = x.MyProperty + y.MyProperty };
            }

            /// <summary>
            /// Overloads the subtraction operator (-) to subtract the properties of two instances of MyClass.
            /// </summary>
            /// <param name="x">The first instance of MyClass.</param>
            /// <param name="y">The second instance of MyClass.</param>
            /// <returns>A new instance of MyClass with the difference of the properties of x and y.</returns>
            public static MyClass operator -(MyClass x, MyClass y)
            {
                return new MyClass() { MyProperty = x.MyProperty - y.MyProperty };
            }

        }

        class MyClass1
        {
            /// <summary>
            /// Gets or sets the integer property of the class.
            /// </summary>
            public int MyProperty { get; set; }

            /// <summary>
            /// Overloads the subtraction operator (-) to return a string "Minus".
            /// </summary>
            /// <param name="x">The first instance of MyClass.</param>
            /// <param name="y">The second instance of MyClass.</param>
            /// <returns>A string "Minus".</returns>
            public static string operator -(MyClass1 x, MyClass1 y)
            {
                return "Minus";
            }

            /// <summary>
            /// Overloads the multiplication operator (*) to return a string "Minus".
            /// </summary>
            /// <param name="x">An instance of MyClass.</param>
            /// <param name="y">An instance of Complex.</param>
            /// <returns>A string "Minus".</returns>
            public static string operator *(MyClass1 x, Complex y)
            {
                return "Minus";
            }
        }

        static void Main(string[] args)
        {
            MyClass a = new MyClass() { MyProperty = 10 }; 
            Console.WriteLine(a.MyProperty);
            
            MyClass b = new MyClass() { MyProperty = 20 }; 
            Console.WriteLine(b.MyProperty);
            
            MyClass res = a + b; 
            Console.WriteLine(res.MyProperty);
            
            res = a - b;
            Console.WriteLine(res.MyProperty);

            // a = a + b;
            // a += b;
            Console.ReadLine();


            Complex k = new Complex() { A = 1, B = 2 };
            Console.WriteLine(k);
            Complex l = new Complex() { A = 3, B = 4 };
            Console.WriteLine(l);

            Console.ReadLine();
            Complex r = k + l;
            Console.WriteLine(r);

            Console.ReadLine();
            Console.WriteLine(k > l);

            //int a = 123;
            //int b = +a;


            MyClass1 a1 = new MyClass1() { MyProperty = 10 };
            MyClass1 b1 = new MyClass1() { MyProperty = 20 };

            string s = a1 * k;
            Console.WriteLine(s);       // but k * a is not goint to work
        }
    }
}
