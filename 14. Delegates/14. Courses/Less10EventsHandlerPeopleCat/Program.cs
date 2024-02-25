namespace Less10EventsHandlerPeopleCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat($"Barshik", $"Scottish Fold", 3);
            
            People robert = new People("Robert", cat);
            
            cat.ToMew();

            // Owner
            cat.Ownew = robert;

            robert.FeedTheCat();
        }
    }
}
