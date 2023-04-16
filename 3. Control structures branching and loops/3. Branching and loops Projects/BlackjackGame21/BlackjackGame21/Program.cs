namespace BlackjackGame21
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // greeting message to the user
            Console.WriteLine("Welcome to the card game '21'!");
            // asking the user how many cards they have
            Console.Write("How many cards do you have in your hand? ");
            // reading user input and converting it to integer
            int numCards = Convert.ToInt32(Console.ReadLine());
            // variable to hold the sum of the card values
            int sum = 0;

            // loop through the cards
            for (int i = 1; i <= numCards; i++) 
            {
                // ask the user to enter the value of each card
                Console.Write("Enter the value of card {0}: ", i);
                // read user input as string
                string cardValue = Console.ReadLine();

                // use a switch statement to determine the value of the card
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
            // display the sum of card values to the user
            Console.WriteLine("The total value of your cards is: {0}", sum);
            Console.ReadKey();
        }
    }
}