# **Life Game**

## **What to do**
Implement your own version of the game "Life." Your task is to emulate the life of bacteria in a Petri dish. The Petri dish is represented by a boolean array of size m by n. A bacterium is a visible symbol in this array.

## **Detailed application algorithm:**

1. Create a boolean array in which there may be a bacterium (true) or not (false).
2. Place bacteria randomly in this array.
3. Define rules for the development of life. For example, a bacterium dies if there are more than three cells nearby, as it lacks food. It also dies if there are fewer than three cells (out of boredom).
4. In the main loop, on each iteration, check if the rules governing the life of bacteria are met, and redraw the resulting new state.

## **Tips and Recommendations:**

- You can hide the cursor using the command: `Console.CursorVisible = false;`
- Use the provided program template as a starting point to further develop life according to your rules. The program text is functional, so you can copy it in its entirety and run it.

## **Additional Resources:**
- [Conway's Game of Life on Wikipedia](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)
- [Program Template (Google Docs)](https://docs.google.com/document/d/1y7IwBmkcBa3pb6eAc-ur0sgFwhjJb1No_R6NkRyUxHI/edit)

## **What is being assessed:**

- The program displays the life of bacteria on the screen.
- Several rules for the life of bacteria are implemented.
