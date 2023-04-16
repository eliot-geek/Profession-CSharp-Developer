While browsing job search websites, you came across an interesting job opening:

Required work experience: no experience necessary
Part-time, remote work

Description:

Startup 'Micarosppoftle', which specializes in the development of multiplayer games, is looking for developers to join their team. The company is willing to consider C# programmers without any prior experience in game development, but who are eager to learn and develop their skills in game development on the .NET platform.

Position: C# Intern

Key requirements:
C#, input/output operators, control structures

Knowledge of procedural programming would be a competitive advantage.

Non-technical requirements:
English proficiency at the level of understanding documentation and reference materials

As a test task, you are asked to solve the following problem.

Write a game that can be played by two players.
At the start, players are prompted to enter their nicknames.
Nicknames are stored until the end of the game.
The program randomly generates a number, gameNumber, from 12 to 120 and informs the players about this number.
Players take turns (the game announces the current player's turn).
The player whose turn it is inputs a number, userTry, which can take values of 1, 2, 3, or 4. The entered number is subtracted from gameNumber.
The new value of gameNumber is displayed on the screen for the players.
The player who makes gameNumber turn zero wins.
The game congratulates the winner and offers to play a rematch
Add a condition if players have not entered from a given interval i.e not between 1 and 4
Add If the player himself decides to lose, the game will end with a number less than zero


Bonus:
Think about the possibility of implementing different levels of difficulty. As difficulty levels, you can consider adjustable userTry values at the beginning of the game, changing the range of gameNumber, or specifying a larger number of players (3, 4, 5...).

Advanced bonus:
Think about the possibility of implementing a single-player game, i.e., the player should play with the computer.

Demonstration:
Number: 12,
User1's move: 3

Number: 9
User2's move: 4

Number: 5
User1's move: 2

Number: 3
User2's move: 3

User2 won!