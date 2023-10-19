namespace Less04Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region db1

            Repository1 db1 = new Repository1(
                new Worker("Position_1", 20000, "FirstName_1"),
                new Worker("Position_2", 20000, "FirstName_2"),
                new Worker("Position_3", 20000, "FirstName_3"),
                new Worker("Position_4", 20000, "FirstName_4"),
                new Worker("Position_5", 20000, "FirstName_5"),
                new Worker("Position_6", 20000, "FirstName_6")
                );
            Console.WriteLine(db1.Workers[0].Print());
            Console.WriteLine();

            #endregion

            #region db2

            Repository2 db2 = new Repository2(
                new Worker("Position_1", 20000, "FirstName_1"),
                new Worker("Position_2", 20000, "FirstName_2"),
                new Worker("Position_3", 20000, "FirstName_3"),
                new Worker("Position_4", 20000, "FirstName_4"),
                new Worker("Position_5", 20000, "FirstName_5"),
                new Worker("Position_6", 20000, "FirstName_6")
                );
            Console.WriteLine(db2[0].Print());
            db2[0] = new Worker("Position_9", 20000, "FirstName_9");
            Console.WriteLine(db2[0].Print());
            Console.WriteLine();

            #endregion

            #region db3

            Repository3 db3 = new Repository3(
                new Worker("Position_0", 20000, "FirstName_0"),
                new Worker("Position_2", 20000, "FirstName_2"),
                new Worker("Position_3", 20000, "FirstName_3"),
                new Worker("Position_4", 20000, "FirstName_4"),
                new Worker("Position_5", 20000, "FirstName_5"),
                new Worker("Position_6", 20000, "FirstName_6")
                );
            Console.WriteLine(db3[0]);
            Console.WriteLine();

            #endregion

            #region db4

            Repository4 db4 = new Repository4(
                new Worker("Position_1", 20000, "FirstName_1"),
                new Worker("Position_2", 20000, "FirstName_2"),
                new Worker("Position_3", 20000, "FirstName_3"),
                new Worker("Position_4", 20000, "FirstName_4"),
                new Worker("Position_5", 20000, "FirstName_5"),
                new Worker("Position_6", 20000, "FirstName_6")
                );

            Console.WriteLine(db4[0]);
            Console.WriteLine(db4[1]);
            Console.WriteLine(db4[2]);
            Console.WriteLine(db4[3]);
            Console.WriteLine(db4[4]);
            Console.WriteLine(db4[5]);
            Console.WriteLine();

            Console.WriteLine(db4["+"]);
            Console.WriteLine(db4["-"]);
            Console.WriteLine(db4["*"]);
            Console.WriteLine(db4["/"]);
            Console.WriteLine(db4["9"]);

            #endregion

            Console.ReadKey();
        }
    }
}