namespace _21MathLogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 30, x2 = 150, // Rectangle vertex coordinates
                y1 = 20, y2 = 90;

            int pA = 90, pB = 40; // Point coordinates

            // Check of the bounded area for the point
            bool check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);
            Console.ReadKey();

            #region _Primary_points.
            pA = 50; pB = 110;
            check = ((pA >= x1) && (pA <= x2)) && ((pB >= y1) && (pB <= y2));
            Console.WriteLine(check);
            #endregion
        }
    }
}