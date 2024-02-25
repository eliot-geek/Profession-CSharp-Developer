namespace Less11SocialNetworkTwitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwitterUser donald = new TwitterUser("Donald");
            donald.PublicMessage("All the best");

            TwitterUser vladimir = new TwitterUser("Vladmir");
            donald.Post += vladimir.Tape;

            donald.PublicMessage("Good luck to everyone!");

            TwitterUser elon = new TwitterUser("Elon");
            donald.Post += elon.Tape;

            donald.PublicMessage("Prosperity to all!");

            TwitterUser mark = new TwitterUser("Mark");
            donald.Post += mark.Tape;

            donald.PublicMessage("All C#!", new Image(), new Document(), new Audio());

            vladimir.Post += donald.Tape;
            vladimir.PublicMessage("Coucou");
        }
    }
}
