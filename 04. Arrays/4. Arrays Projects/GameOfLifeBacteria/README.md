# **Game of Life**

## **Task Description**

Implement your own version of the Game of Life. Your task is to emulate the life of bacteria in a Petri dish.

## **Algorithm**

1. Create a boolean array (bool array) where each cell may contain a bacterium (true) or not (false).
2. Randomly place bacteria in this array.
3. Define rules for the development of life. For example, a bacterium dies if there are more than three neighboring cells, as it lacks food. It also dies if there are fewer than three neighboring cells (out of boredom).
4. In the main loop, on each iteration, check the rules that govern the life of the bacterium and redraw the resulting new state.

## **Tips and Recommendations**

- You can hide the cursor using the command: `Console.CursorVisible = false;`

## **Additional Resources**

- [Conway's Game of Life on Wikipedia](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)
