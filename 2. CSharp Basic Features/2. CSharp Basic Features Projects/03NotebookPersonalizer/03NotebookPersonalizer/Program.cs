namespace _03NotebookPersonalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Display a line in the center of the screen
            
            // Display a line in the center of the screen
            Console.ReadKey();
            string title = "NOTEBOOK";
            int centerX = (Console.WindowWidth / 2) - (title.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 16;
            Console.SetCursorPosition(centerX, centerY); // Set the cursor position to the calculated x and y coordinates
            Console.WriteLine(title); Console.ReadKey();

            // 1. Create several variables of different types to store data.
            string name = "Anders";
            int age = 25;
            double height = 1.75;
            int historyGrade = 90;
            int mathGrade = 85;
            int russianGrade = 95;

            // 2. Implement an automatic calculation of the average score for the three subjects.
            string averageGrade = ((double)(historyGrade + mathGrade + russianGrade) / 3.0).ToString("#.###");
            // Data output at the console center
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"Name: {name}".Length) / 2, (Console.WindowHeight / 2 - 12));
            Console.WriteLine($"Name: {name}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"Age: {age}".Length) / 2, (Console.WindowHeight / 2 - 11));
            Console.WriteLine($"Age: {age}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"Heigth: {height}".Length) / 2, (Console.WindowHeight / 2 - 10));
            Console.WriteLine($"Heigth: {height}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"HistoryGrade: {historyGrade}".Length) / 2, (Console.WindowHeight / 2 - 9));
            Console.WriteLine($"HistoryGrade: {historyGrade}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"RussianGrade: {russianGrade}".Length) / 2, (Console.WindowHeight / 2 - 8));
            Console.WriteLine($"RussianGrade: {russianGrade}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"MathGrade: {mathGrade}".Length) / 2, (Console.WindowHeight / 2 - 7));
            Console.WriteLine($"MathGrade: {mathGrade}");
            Console.SetCursorPosition(Console.WindowWidth / 2 - ($"Average: {averageGrade}".Length) / 2, (Console.WindowHeight / 2 - 6));
            Console.WriteLine($"Average: {averageGrade}");
            Console.ReadKey();
            #endregion

            #region Implement the possibility of printing information on the console using

            // Implement the possibility of printing information on the console using:
            // 1. Normal output
            Console.WriteLine("1. Normal output");
            Console.WriteLine(name + ". " + age + ". " + height + " cm. " + historyGrade + ". " + mathGrade + ". " + russianGrade + ". " + averageGrade + ".");
            // Escape sequences of normal output
            Console.WriteLine("\nEscape sequences of normal output");
            Console.WriteLine(name + "\n" + age + "\n" + height + " cm" + "\n" + historyGrade + "\n" + mathGrade + "\n" + russianGrade + "\n" + averageGrade);

            // 2. Formatted output
            Console.WriteLine("\n2. Formatted output");
            string pattern = "Name: {0} Age: {1} Height: {2} cm HistoryGrade: {3} MathGrade: {4} RussianGrade: {5} Average: {6}";
            Console.WriteLine(pattern,
                                name,
                                age,
                                height,
                                historyGrade,
                                mathGrade,
                                russianGrade,
                                averageGrade);
            // Escape sequences of formatted output
            Console.WriteLine("\nEscape sequences of formatted output");
            string newpattern = "Name: {0} \nAge: {1} \nHeight: {2} cm \nHistoryGrade: {3} \nMathGrade: {4} \nRussianGrade: {5} \nAverage: {6}";
            Console.WriteLine(newpattern,
                                name,
                                age,
                                height,
                                historyGrade,
                                mathGrade,
                                russianGrade,
                                averageGrade);

            // 3. String interpolation
            Console.WriteLine("\n3. String interpolation");
            Console.WriteLine($"Name: {name} Age: {age} Height: {height} {" см"} HistoryGrade: {historyGrade} MathGrade: {mathGrade} RussianGrade: {russianGrade} Average: {averageGrade}");
            // Escape sequences of String interpolation
            Console.WriteLine("\nEscape sequences of String interpolation");
            Console.WriteLine($"Name: {name} \nAge: {age} \nHeight: {height} {" см"} \nHistoryGrade: {historyGrade} \nMathGrade: {mathGrade} \nRussianGrade: {russianGrade} \nAverage: {averageGrade}");
            Console.ReadKey();
            #endregion

            #region Ability to change values of several variables

            Console.WriteLine("\nAnother user's data");
            // Creating several variables of different types
            string Aname = "Mr Robot";
            byte Aage = 22;
            float Aheight = 1.75F;
            double ApointHistory = 86.8;
            int ApointRussianLanguage = 90;
            double ApointMaths = 99.75;

            // Automatic calculation of the average score for subjects
            string Aaverage = ((double)(ApointHistory + ApointMaths + ApointRussianLanguage) / 3).ToString("#.###");

            // Formatted output;
            Console.WriteLine("\nFormatted output");
            string Apattern = "Name: {0} Age: {1} Height: {2} PointHistory: {3} PointRussianLanguage: {4} PointMaths: {5} Average: {6}";
            Console.WriteLine(Apattern,
                                Aname,
                                Aage,
                                Aheight + " cm",
                                ApointHistory,
                                ApointRussianLanguage,
                                ApointMaths,
                                Aaverage);
            // Escape sequences 
            Console.WriteLine("\nEscape sequences of formatted output");
            string Anewpattern = "Name: {0} \nAge: {1} \nHeight: {2} \nPointHistory: {3} \nPointRussianLanguage: {4} \nPointMaths: {5} \nAverage: {6}";
            Console.WriteLine(Anewpattern,
                                Aname,
                                Aage,
                                Aheight + " cm",
                                ApointHistory,
                                ApointRussianLanguage,
                                ApointMaths,
                                Aaverage);
            // Using string interpolation
            Console.WriteLine("\nUsing string interpolation");
            Console.WriteLine($"Name: {Aname} Age: {Aage} Height: {Aheight} {" см"} PointHistory: {ApointHistory} PointRussianLanguage: {ApointRussianLanguage} PointMaths: {ApointMaths} Average: {Aaverage}");
            Console.ReadKey();
            #endregion
        }
    }
}
