using System.Globalization;

namespace DailyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the file's name: ");
            //String file = Console.ReadLine();

            string file = @"file.txt";
            List<Worker> list = Repository.readFromFile(file);
            string str = "";
            while (str != "0")
            {
                //Console.WriteLine("1_Print the list\n2_Print by ID\n3_Add\n4_Loading records in the selected date range\n5_Sort by Ascending (dates)" +
                  //  "\n6_Sort by Descending (dates)\n7_Sort by field\n8_Edit\n9_Delete\n0_Save and Exit\n");

                Console.WriteLine("======== Worker Management System ========");
                Console.WriteLine("1. Print the list");
                Console.WriteLine("2. Print by ID");
                Console.WriteLine("3. Add a new worker");
                Console.WriteLine("4. Load records in the selected date range");
                Console.WriteLine("5. Sort by Ascending (dates)");
                Console.WriteLine("6. Sort by Descending (dates)");
                Console.WriteLine("7. Sort by a specific field");
                Console.WriteLine("8. Edit a worker's details");
                Console.WriteLine("9. Delete a worker");
                Console.WriteLine("0. Save and Exit");

                str = Console.ReadLine();
                if (str == "0")
                    break;
                switch (str)
                {
                    case "1":
                        {
                            Repository.Print(list);
                        }
                        break;
                    case "2":
                        {
                            int ID;
                            bool validInput = false;
                            do
                            {
                                Console.Write("Enter the element's ID you want to print: ");
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out ID))
                                {
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid integer ID.");
                                }
                            } while (!validInput);
                            Repository.Print(ID, list);
                        }
                        break;
                    case "3":
                        {
                            Repository.Add(list);
                            Repository.Print(list);
                        }
                        break;
                    case "4":
                        {
                            DateTime start;
                            DateTime end;
                            bool validInput = false;
                            do
                            {
                                Console.Write("Enter the start date in this format [dd.MM.yyyy HH:mm]: ");
                                string startInput = Console.ReadLine();
                                if (DateTime.TryParseExact(startInput, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out start))
                                {
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date format. Please enter a date in the format [dd.MM.yyyy HH:mm].");
                                }
                            } while (!validInput);

                            validInput = false;
                            do
                            {
                                Console.Write("Enter the end date in this format [dd.MM.yyyy HH:mm]: ");
                                string endInput = Console.ReadLine();
                                if (DateTime.TryParseExact(endInput, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out end))
                                {
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date format. Please enter a date in the format [dd.MM.yyyy HH:mm].");
                                }
                            } while (!validInput);
                            Repository.byDate(list, start, end);
                        }
                        break;
                    case "5":
                        {
                            Repository.SortByAscending(list);
                            Repository.Print(list);
                        }
                        break;
                    case "6":
                        {
                            Repository.SortByDescending(list);
                            Repository.Print(list);
                        }
                        break;
                    case "7":
                        {
                            Repository.sortByField(ref list);
                            Repository.Print(list);
                        }
                        break;
                    case "8":
                        {
                            int ID;
                            bool validInput = false;
                            do
                            {
                                Console.Write("Enter the element's ID you want to edit: ");
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out ID))
                                {
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid integer ID.");
                                }
                            } while (!validInput);
                            Repository.Edit(list, ID);
                            Repository.Print(list);
                        }
                        break;
                    case "9":
                        {
                            int ID;
                            bool validInput = false;
                            do
                            {
                                Console.Write("Enter the element's ID you want to delete: ");
                                string input = Console.ReadLine();
                                if (int.TryParse(input, out ID))
                                {
                                    validInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid integer ID.");
                                }
                            } while (!validInput);
                            Repository.Delete(list, ID);
                            Repository.Print(list);
                        }
                        break;
                    default:
                        Console.WriteLine("You entered a wrong number");
                        break;

                }
            }
            Repository.writeToFile(file, list);
            Console.ReadKey();
        }
    }
}