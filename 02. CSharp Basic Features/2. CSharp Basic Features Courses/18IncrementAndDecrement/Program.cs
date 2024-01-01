namespace _18IncrementAndDecrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region +=
            //Console.WriteLine("\n+=");
            //int a = 12; int b = 13;

            //int c = a + b;
            //Console.WriteLine(c);  // 25
            ////a = a + b;
            //a += b;                 
            //Console.WriteLine(a); 
            #endregion

            #region -=
            //Console.ReadKey(); Console.WriteLine("\n-=");

            //int a = 12;
            //int b = 13;
            //int c = a - b;

            //Console.WriteLine(c);  // -1

            ////a = a - b;
            //a -= b;
            //Console.WriteLine(a);  // -1

            #endregion

            #region *=
            //Console.ReadKey(); Console.WriteLine("\n*=");

            //int a = 4;
            //int b = 5;
            //int c = a * b;

            //Console.WriteLine(c);  // 20

            ////a = a * b;
            //a *= b;
            //Console.WriteLine(a);  // 20

            #endregion

            #region /=
            //Console.ReadKey(); Console.WriteLine("\n/=");

            //int a = 33;
            //int b = 11;
            //int c = a / b;
            //Console.WriteLine(c);  // 3

            ////a = a / b;
            //a /= b;
            //Console.WriteLine(a);  // 3

            //a = 30;
            //b = 11;
            //c = a / b;
            //Console.WriteLine(c); //2

            //a /= b;
            //Console.WriteLine(a); //2

            //double d = 10;
            //double e = 4;
            //d /= e;
            //Console.WriteLine(d); //2.5
            #endregion

            #region %=
            Console.ReadKey(); Console.WriteLine("\n%=");

            int a = 14;
            int b = 5;
            int c = a % b;
            Console.WriteLine(c);  // 4

            //a = a % b;
            a %= b;
            Console.WriteLine(a);  // 4
            #endregion

            #region ++
            Console.ReadKey(); Console.WriteLine("\n++");

            a = 10;

            a += 20;
            Console.WriteLine(a); //30

            a += 1;
            Console.WriteLine(a); //31

            a++; // postfix increment
            Console.WriteLine(a); //32

            ++a;// prefix increment
            Console.WriteLine(a); //33
            #endregion

            #region --
            Console.ReadKey(); Console.WriteLine("\n--");
            a = 50;

            a -= 20;
            Console.WriteLine(a); //30

            a -= 1;
            Console.WriteLine(a); //29

            a--; // postfix increment
            Console.WriteLine(a); //28

            --a;// prefix increment
            Console.WriteLine(a); //27
            #endregion
        }
    }
}
