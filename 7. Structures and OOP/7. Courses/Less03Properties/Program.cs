namespace Less03Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Cat1
            // Cat1: Allowing anyone to change the name without the author's permission is not a desirable practice.
            // Simply changing "public" to "private" would not solve this issue.

            Cat1 cat1 = new Cat1("Scottish Fold", "Barsik");
            Console.WriteLine(cat1.Breed);
            cat1.Breed = "Ragdoll";
            Console.WriteLine(cat1.Breed);

            Console.WriteLine(cat1.Nickname);
            cat1.Nickname = "Ryzhik";
            Console.WriteLine(cat1.Nickname);
            Console.ReadKey();

            #endregion

            #region Cat2
            // Cat2 allows reading but not editing or changing

            Cat2 cat2 = new Cat2("Scottish Fold", "Barsik");
            Console.WriteLine(cat2.GetBreed());

            // In struct Cat2 Breed is private that's why i can't modify
            // cat2.Breed = "Ragdoll";     
            // Console.WriteLine(cat2.Breed);
            Console.ReadKey();

            #endregion

            #region Account1

            Account1 account1 = new Account1("Admin", "qwerty");
            Console.WriteLine(account1.Password);
            Console.ReadKey();

            #endregion

            #region Account2

            Account2 account2 = new Account2("Admin", "qwerty");
            Console.WriteLine(account2.Login);

            account2.SetPassword("jroyce");
            // Console.WriteLine(account2.Password);
            Console.ReadKey();

            #endregion

            #region Cat4
            
            Cat4 cat4 = new Cat4();
            cat4.Nickname = "Leo";
            Console.WriteLine(cat4.Nickname);

            cat4.EyeColor = "Green";
            Console.WriteLine(cat4.EyeColor);
            cat4.EyeColor = "Blue";
            Console.WriteLine(cat4.EyeColor);

            #endregion
            
            Console.ReadKey();
        }
    }
}