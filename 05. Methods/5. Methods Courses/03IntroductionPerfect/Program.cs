namespace _03IntroductionPerfect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int N = r.Next(10, 20);
            int M = r.Next(10, 20);

            int[] arr = new int[N];
            int[] brr = new int[M];

            //Fill(arr);
            //Print(arr);

            //Fill(brr);
            //Print(brr, N);
            //Fill(brr, N, 10, 20);

            //Print(brr);

            //int maxArr = Max(arr);
            //int maxBrr = Max(brr);
            //int minArr = Min(arr);
            //int minBrr = Min(brr);

            #region TODO

            //int maxArr = arr.Max();
            //int maxBrr = brr.Max();
            //int minArr = arr.Min();
            //int minBrr = brr.Min();

            #endregion
        }
    }
}