using System;

namespace TwoPlayerSubtractGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME! PLEASE SELECT THE GAME YOU WOULD LIKE TO PLAY: \n1- TWO-PLAYER GAME \n2- TWO-PLAYER GAME WITH VARYING LEVELS OF DIFFICULTY " +
                "\n3- THREE-PLAYER GAME  \n4- GAME AGAINST THE COMPUTER (ROBOT)");
            Console.Write("Enter your choice: ");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                #region TWO-PLAYER GAME
                case 1:
                    Console.WriteLine("Welcome to the Two-Player Game!");
                    // Prompt the players to enter their nicknames
                    Console.Write("Enter Player 1's nickname: ");
                    string player1Name = Console.ReadLine();
                    Console.Write("Enter Player 2's nickname: ");
                    string player2Name = Console.ReadLine();

                    // Initialize the gameNumber to a random number between 12 and 120
                    Random random = new Random();
                    int gameNumber = random.Next(12, 121);
                    Console.WriteLine($"The gameNumber is {gameNumber}");

                    // Initialize the current player as Player 1
                    string currentPlayer = player1Name;

                    // Start the game loop
                    while (gameNumber > 0)
                    {
                        // Prompt the current player to enter their move
                        Console.Write($"{currentPlayer}'s move: ");
                        int userTry = int.Parse(Console.ReadLine());

                        // Check if userTry is between 1 and 4
                        if (userTry < 1 || userTry > 4)
                        {
                            Console.WriteLine("Invalid move! You can only subtract 1, 2, 3, or 4 from the gameNumber.");
                            continue;
                        }

                        // Subtract userTry from gameNumber
                        gameNumber -= userTry;
                        Console.WriteLine($"Number: {gameNumber}");

                        // Check if gameNumber is less than zero
                        if (gameNumber < 0)
                        {
                            Console.WriteLine($"Game over! {currentPlayer} loses because the gameNumber is less than zero.");
                            break;
                        }

                        // Check if gameNumber is zero
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Game over! {currentPlayer} wins!");

                            // Prompt the players for a rematch
                            Console.Write("Do you want to play a rematch? (Y/N): ");
                            string rematch = Console.ReadLine();
                            if (rematch.ToLower() == "y")
                            {
                                // Reset the gameNumber to a random number between 12 and 120
                                gameNumber = random.Next(12, 121);
                                Console.WriteLine($"The new gameNumber is {gameNumber}");

                                // Switch the current player
                                if (currentPlayer == player1Name)
                                {
                                    currentPlayer = player2Name;
                                }
                                else
                                {
                                    currentPlayer = player1Name;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            // Switch the current player
                            if (currentPlayer == player1Name)
                            {
                                currentPlayer = player2Name;
                            }
                            else
                            {
                                currentPlayer = player1Name;
                            }
                        }
                    }
                    Console.WriteLine("Thank you for playing the Two Player Game!");
                    break;
                #endregion

                #region TWO-PLAYER GAME WITH VARYING LEVELS OF DIFFICULTY
                case 2:
                    Console.WriteLine("Welcome to the Two-Player Game with varying levels of difficulty!");
                    // Prompt players to enter their nicknames
                    Console.Write("Enter player 1 name: ");
                    string player1 = Console.ReadLine();
                    Console.Write("Enter player 2 name: ");
                    string player2 = Console.ReadLine();

                    // Prompt players to choose their userTry values
                    Console.Write("Enter userTry value for {0}: ", player1);
                    int userTry1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter userTry value for {0}: ", player2);
                    int userTry2 = int.Parse(Console.ReadLine());

                    // Prompt players to choose the level of difficulty
                    Console.WriteLine("Choose difficulty level: 1 = easy, 2 = medium, 3 = hard");
                    int difficultyLevel = int.Parse(Console.ReadLine());
                    int minGameNumber, maxGameNumber;
                    if (difficultyLevel == 1)
                    {
                        minGameNumber = 20;
                        maxGameNumber = 80;
                    }
                    else if (difficultyLevel == 2)
                    {
                        minGameNumber = 50;
                        maxGameNumber = 150;
                    }
                    else
                    {
                        minGameNumber = 100;
                        maxGameNumber = 300;
                    }

                    // Generate a random number between minGameNumber and maxGameNumber
                    Random random1 = new Random();
                    int gameNumber1 = random1.Next(minGameNumber, maxGameNumber + 1);
                    Console.WriteLine("The game number is: {0}", gameNumber1);

                    // Initialize variables for keeping track of turns and winner
                    int turn = 1;
                    string winner = "";

                    // Main game loop
                    while (gameNumber1 > 0)
                    {
                        // Announce current player's turn
                        string currentPlayer1 = turn % 2 == 1 ? player1 : player2;
                        Console.Write("{0}'s move: ", currentPlayer1);

                        // Prompt player to input userTry value
                        int userTry = currentPlayer1 == player1 ? userTry1 : userTry2;
                        int input = int.Parse(Console.ReadLine());

                        // Check if input is valid
                        if (input < 1 || input > userTry || input > gameNumber1)
                        {
                            Console.WriteLine("Invalid input! Enter a number between 1 and {0}", Math.Min(userTry, gameNumber1));
                            continue;
                        }

                        // Subtract input from gameNumber and display the new value
                        gameNumber1 -= input;
                        Console.WriteLine("Number: {0}", gameNumber1);

                        // Check if game is over
                        if (gameNumber1 == 0)
                        {
                            winner = currentPlayer1;
                            break;
                        }
                        // Increment turn counter
                        turn++;
                    }

                    // Announce winner and ask for rematch
                    Console.WriteLine("{0} won!", winner);
                    Console.Write("Do you want to play again? (y/n): ");
                    string rematch1 = Console.ReadLine();
                    if (rematch1 == "y")
                    {
                        Main(args);
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                    }
                    break;
                #endregion

                #region THREE-PLAYER GAME
                case 3:
                    // Prompt the players to enter their names
                    Console.WriteLine("Welcome to the Three-Player Game!");
                    Console.Write("Player 1, enter your name: ");
                    string player11 = Console.ReadLine();
                    Console.Write("Player 2, enter your name: ");
                    string player22 = Console.ReadLine();
                    Console.Write("Player 3, enter your name: ");
                    string player33 = Console.ReadLine();

                    // Initialize the game number based on the selected difficulty level
                    int gameNumber2 = 0;
                    Console.WriteLine("Select difficulty level: 5-easy 6-medium 7-hard");
                    int difficultyLevel1 = int.Parse(Console.ReadLine());
                    switch (difficultyLevel1)
                    {
                        case 5:
                            gameNumber2 = new Random().Next(12, 51);
                            Console.WriteLine($"The game number is between 12 and 50: {gameNumber2}");
                            break;
                        case 6:
                            gameNumber2 = new Random().Next(51, 101);
                            Console.WriteLine($"The game number is between 51 and 100: {gameNumber2}");
                            break;
                        case 7:
                            gameNumber2 = new Random().Next(101, 151);
                            Console.WriteLine($"The game number is between 101 and 150: {gameNumber2}");
                            break;
                        default:
                            Console.WriteLine("Invalid difficulty level. Game will exit.");
                            Environment.Exit(0);
                            break;
                    }

                    // Determine the first player randomly
                    int currentPlayer2 = new Random().Next(5, 8);
                    // Play the game until the game number is zero or less
                    while (gameNumber2 > 0)
                    {
                        int userTry4 = 0;
                        switch (currentPlayer2)
                        {
                            case 5:
                                Console.Write($"{player11}, enter your number (1-4): ");
                                userTry4 = int.Parse(Console.ReadLine());
                                break;
                            case 6:
                                Console.Write($"{player22}, enter your number (1-4): ");
                                userTry4 = int.Parse(Console.ReadLine());
                                break;
                            case 7:
                                Console.Write($"{player33}, enter your number (1-4): ");
                                userTry4 = int.Parse(Console.ReadLine());
                                break;
                        }
                        // Check if the user's input is within the valid range
                        if (userTry4 < 1 || userTry4 > 4)
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                            continue;
                        }
                        // Subtract the user's input from the game number and display the new game number
                        gameNumber2 -= userTry4;
                        Console.WriteLine($"New game number: {gameNumber2}");

                        // If the game number is less than zero, the current player loses the game
                        if (gameNumber2 < 0)
                        {
                            switch (currentPlayer2)
                            {
                                case 5:
                                    Console.WriteLine($"{player11} lost.");
                                    break;
                                case 6:
                                    Console.WriteLine($"{player22} lost.");
                                    break;
                                case 7:
                                    Console.WriteLine($"{player33} lost.");
                                    break;
                            }
                            break;
                        }

                        if (gameNumber2 == 0)
                        {
                            switch (currentPlayer2)
                            {
                                case 5:
                                    Console.WriteLine($"{player11} wins!");
                                    break;
                                case 6:
                                    Console.WriteLine($"{player22} wins!");
                                    break;
                                case 7:
                                    Console.WriteLine($"{player33} wins!");
                                    break;
                            }
                            break;
                        }
                        // Switch to the next player
                        //currentPlayer2 = currentPlayer2 % 3 + 1;
                        currentPlayer2 = (currentPlayer2 == 5) ? 6 : currentPlayer2 == 6 ? 7 : 5;
                    }
                    // Display the end of the game message and offer a rematch
                    Console.WriteLine("Game over!");

                    Console.WriteLine("Do you want to play again? (y/n)");
                    string rematch2 = Console.ReadLine();
                    if (rematch2 == "y")
                    {
                        Main(args);
                    }
                    break;
                #endregion

                #region GAME AGAINST THE COMPUTER (ROBOT)
                case 4:
                    // Welcome message
                    Console.WriteLine("Welcome to the Game against the Computer!");

                    // Prompt for player names
                    Console.Write("Enter your name: ");
                    string player111 = Console.ReadLine();

                    // Set up game parameters
                    int gameNumber3 = new Random().Next(12, 121); // Generate random number from 12 to 120
                    int currentPlayer3 = 1; // Player 1 goes first
                    int userTry3 = 0; // Variable to store user input

                    // Game loop
                    while (gameNumber3 > 0)
                    {
                        // Display game number and current player
                        Console.WriteLine($"Number: {gameNumber3}");
                        Console.WriteLine($"Player {currentPlayer3}'s turn.");

                        if (currentPlayer3 == 1) // Human player's turn
                        {
                            Console.Write("Enter a number (1-4): ");
                            userTry3 = int.Parse(Console.ReadLine());

                            if (userTry3 < 1 || userTry3 > 4)
                            {
                                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                                continue;
                            }
                        }
                        else if (currentPlayer3 == 2) // Computer player's turn
                        {
                            // Generate computer's move
                            if (gameNumber3 % 5 == 0) // If gameNumber is a multiple of 5, subtract 4
                            {
                                userTry3 = 4;
                            }
                            else // Otherwise, subtract the remainder
                            {
                                userTry3 = gameNumber3 % 5;
                            }
                            Console.WriteLine($"Computer's move: {userTry3}");
                        }
                        // Subtract user input from gameNumber
                        gameNumber3 -= userTry3;

                        // Check for winner
                        if (gameNumber3 == 0)
                        {
                            Console.WriteLine($"Player {currentPlayer3} won!");
                            break;
                        }
                        // Switch to next player
                        currentPlayer3 = currentPlayer3 == 1 ? 2 : 1;
                    }

                    // Prompt for rematch
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string rematch3 = Console.ReadLine();
                    if (rematch3 == "y")
                    {
                        Main(args);
                    }
                    break;
                #endregion

                default:
                    Console.WriteLine("Invalid choice. You choose between 1 and 4. Game will exit.");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}