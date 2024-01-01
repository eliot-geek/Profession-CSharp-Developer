# Job Opening: C# Intern - Game Development

## Job Details
**Company**: Micarosppoftle (Startup specializing in multiplayer game development)  
**Experience Required**: No experience necessary  
**Job Type**: Part-time, remote work  

## Job Description
Micarosppoftle, a startup specializing in the development of multiplayer games, is seeking developers to join their team. The company is open to considering C# programmers with no prior experience in game development who are eager to learn and develop their skills in game development on the .NET platform.

**Position**: C# Intern

### Key Requirements:
- C#
- Input/Output operators
- Control structures

**Knowledge of procedural programming would be a competitive advantage.**

### Non-Technical Requirements:
- English proficiency at the level of understanding documentation and reference materials

## Test Task: Multiplayer Game Development
As a test task, you are asked to solve the following problem:

**Write a game that can be played by two players.**
- At the start, players are prompted to enter their nicknames.
- Nicknames are stored until the end of the game.
- The program randomly generates a number, `gameNumber`, from 12 to 120 and informs the players about this number.
- Players take turns (the game announces the current player's turn).
- The player whose turn it is inputs a number, `userTry`, which can take values of 1, 2, 3, or 4. The entered number is subtracted from `gameNumber`.
- The new value of `gameNumber` is displayed on the screen for the players.
- The player who makes `gameNumber` turn zero wins.
- The game congratulates the winner and offers to play a rematch.

### Additional Conditions to Implement
- Add a condition if players have not entered a number from the given interval (1 to 4).
- If a player decides to lose intentionally (inputs a number that makes `gameNumber` less than zero), the game ends.

### Bonus Challenges
- Think about implementing different levels of difficulty (adjustable `userTry` values, changing the range of `gameNumber`, or specifying a larger number of players).
- Think about the possibility of implementing a single-player game, where the player competes against the computer.

### Demonstration:  
Number: 12,
User1's move: 3

Number: 9
User2's move: 4

Number: 5
User1's move: 2

Number: 3
User2's move: 3

User2 won!
