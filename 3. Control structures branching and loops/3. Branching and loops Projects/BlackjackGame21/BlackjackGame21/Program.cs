namespace BlackjackGame21
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to the card game '21'!");
            Console.Write("How many cards do you have in your hand? ");
            int numCards = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            // loop through the cards
            for (int i = 1; i <= numCards; i++) 
            {
                Console.Write("Enter the value of card {0}: ", i);
                string cardValue = Console.ReadLine();

                switch (cardValue.ToUpper()) 
                {
                    case "J": // Jack
                    case "Q": // Queen
                    case "K": // King
                    case "T": // Ace
                        sum += 10; // add 10 to the sum
                        break;
                    default: // for numeric cards
                        sum += int.Parse(cardValue); // convert the input string to integer and add it to the sum
                        break;
                }
            }
            Console.WriteLine("The total value of your cards is: {0}", sum);
            Console.ReadKey();
        }
    }
}
