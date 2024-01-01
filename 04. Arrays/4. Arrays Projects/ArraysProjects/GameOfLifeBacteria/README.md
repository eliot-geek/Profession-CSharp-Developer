Task 6.Game of Life

Implement your own version of the Game of Life.Your task is to emulate the life of bacteria in a Petri dish.

The Petri dish is a bool array of size m by n.A bacterium is a visible symbol in this array.

Detailed algorithm of the application:

Create a bool array in which there is either a bacterium or not.Randomly place bacteria in this array.
Come up with rules for the development of life.For example, a bacterium dies if there are more than three cells nearby, as it lacks food.
And it dies if there are less than three cells(out of boredom).
In the main loop, on each iteration, check the rules that govern the life of the bacterium and redraw the resulting new state.

Tips and recommendations:

You can hide the cursor using the command Console.CursorVisible = false;


Reference - https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life
