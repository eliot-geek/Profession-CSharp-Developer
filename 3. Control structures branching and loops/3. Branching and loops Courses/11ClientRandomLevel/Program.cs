namespace _11ClientRandomLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The customer asks to create a game emulator in which the player has the ability to choose the difficulty level, depending on which the different game world will be generated

            Console.WriteLine("Enter the difficulty level. 1 - Simple, 2 - Medium, 3 - Difficult");
            int level;      // 1 - Simple
                            // 2 - Medium
                            // 3 - Difficult
                            // Depending on the level, determine the number of the generated NPCs (Non-player character - is any character in a game that is not controlled by a player)
                            // Simple - Two NPCs
                            // Medium - Four NPCs
                            // Difficult - Five NPCs

            level = Convert.ToInt32(Console.ReadLine());

            #region if else
            // Not recommended
            if (level == 1)
            {
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
            }
            else if (level == 2)
            {
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
            }
            else if (level == 3)
            {
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
                Console.WriteLine("NPC generated");
            }
            else
            {
                Console.WriteLine("Wrong Choice!!");
            }
            #endregion

            #region switch
            // Recommended
            switch (level)
            {
                case 1:
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    break;
                case 2:
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    break;
                case 3:
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    Console.WriteLine("NPC generated");
                    break;
                default:
                    Console.WriteLine("An unknown difficulty level has been selected");
                    break;
            }

            #endregion
        }
    }
}