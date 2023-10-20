using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManagement
{
    /// <summary>
    /// Structure 
    /// </summary>
    struct Repository
    {
        /// <summary>
        /// Print
        /// </summary>
        /// <param name="array"></param>
        public static void Print(List<Worker> list)
        {
            var stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(String.Format("{0,5}  {1,18}  {2,23}  {3,5}  {4,7}  {5,12}  {6,15}\n", "ID", "DateAndTime", "FullName", "Age", "Height", "DateOfBirth", "PlaceOfBirth"));
            
            for (int i = 0; i < list.Count; i++)
            {
                Worker worker = list.ElementAt(i);
                String line = worker.iD.ToString() + " " + worker.dateAndTime.ToString("dd.MM.yyyy HH:mm") + " " + worker.fullName + " " + worker.age.ToString()
                    + " " + worker.height.ToString() + " " + worker.dateOfBirth.ToString("dd.MM.yyyy") + " " + worker.placeOfBirth;

                stringBuilder.Append(String.Format("{0,5}  {1,18}  {2,23}  {3,5}  {4,7}  {5,12}  {6,15}\n", worker.iD.ToString(), worker.dateAndTime.ToString("dd.MM.yyyy HH:mm"),
                    worker.fullName, worker.age.ToString(), worker.height.ToString(), worker.dateOfBirth.ToString("dd.MM.yyyy"), worker.placeOfBirth));
            }
            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        /// Print by ID
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="list"></param>
        public static void Print(int ID, List<Worker> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).iD == ID)
                {
                    Worker worker = list.ElementAt(i);
                    String line = worker.iD.ToString() + " " + worker.dateAndTime.ToString("dd.MM.yyyy HH:mm") + " " + worker.fullName + " " + worker.age.ToString()
                    + " " + worker.height.ToString() + " " + worker.dateOfBirth.ToString("dd.MM.yyyy") + " " + worker.placeOfBirth;

                    var stringBuilder = new System.Text.StringBuilder();
                    stringBuilder.Append(String.Format("{0,5}  {1,18}  {2,23}  {3,5}  {4,7}  {5,12}  {6,15}\n", "ID", "DateAndTime", "FullName", "Age", "Height", "DateOfBirth", "PlaceOfBirth"));

                    stringBuilder.Append(String.Format("{0,5}  {1,18}  {2,23}  {3,5}  {4,7}  {5,12}  {6,15}\n", worker.iD.ToString(), worker.dateAndTime.ToString("dd.MM.yyyy HH:mm"),
                        worker.fullName, worker.age.ToString(), worker.height.ToString(), worker.dateOfBirth.ToString("dd.MM.yyyy"), worker.placeOfBirth));

                    Console.WriteLine(stringBuilder);
                    return;
                }
            }
            Console.WriteLine("Nothing found");
        }

        /// <summary>
        /// Add method
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ID"></param>
        /// <param name="DateAndTime"></param>
        /// <param name="FullName"></param>
        /// <param name="Age"></param>
        /// <param name="Height"></param>
        /// <param name="DateOfBirth"></param>
        /// <param name="PlaceOfBirth"></param>
        public static void Add(List<Worker> list, int ID, DateTime DateAndTime, String FullName, int Age, float Height, DateTime DateOfBirth, String PlaceOfBirth)
        {
            Worker worker = new Worker(ID, DateAndTime, FullName, Age, Height, DateOfBirth, PlaceOfBirth);
            list.Add(worker);
        }

        /// <summary>
        /// Delete by ID
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ID"></param>
        public static void Delete(List<Worker> list, int ID)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).iD == ID)
                {
                    list.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("Nothing found");
        }

        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ID"></param>
        public static void Edit(List<Worker> list, int ID)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).iD == ID)
                {
                    Console.Write("Let see DateAndTime: ");
                    DateTime DateAndTime = list.ElementAt(i).dateAndTime;
                    Console.WriteLine(DateAndTime);
                    Console.Write("Enter FullName: ");
                    String FullName = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int Age = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    float Height = float.Parse(Console.ReadLine());
                    Console.Write("Enter DateOfBirth: ");
                    DateTime DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.Write("Enter PlaceOfBirth: ");
                    String PlaceOfBirth = Console.ReadLine();

                    Worker worker = new Worker(ID, DateAndTime, FullName, Age, Height, DateOfBirth, PlaceOfBirth);
                    list[i] = worker;
                    return;
                }
            }
            Console.WriteLine("Nothing found");
        }

        /// <summary>
        /// Add from keyword
        /// </summary>
        /// <param name="list"></param>
        public static void Add(List<Worker> list)
        {
            Console.Write("Enter FullName: ");
            String FullName = Console.ReadLine();
            Console.Write("Enter Age: ");
            int Age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            float Height = float.Parse(Console.ReadLine());
            Console.Write("Enter DateOfBirth: ");
            DateTime DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter PlaceOfBirth: ");
            String PlaceOfBirth = Console.ReadLine();
            int iD = list.ElementAt(0).iD;
            for (int i = 1; i < list.Count; i++)
            {
                if (list.ElementAt(i).iD > iD)
                    iD = list.ElementAt(i).iD;
            }
            iD++;
            Console.Write("Let see DateAndTime: ");
            DateTime DateAndTime = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateAndTime);

            Worker worker = new Worker(iD, DateAndTime, FullName, Age, Height, DateOfBirth, PlaceOfBirth);
            list.Add(worker);
        }

        /// <summary>
        /// Loading records in the selected date range.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public static void byDate(List<Worker> list, DateTime start, DateTime end)
        {
            var stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(String.Format("\n{0,5}  {1,18}  {2,23}  {3,5}  {4,7}  {5,12}  {6,15}\n", "ID", "DateAndTime", "FullName", "Age", "Height", "DateOfBirth", "PlaceOfBirth"));

            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).dateAndTime >= start && list.ElementAt(i).dateAndTime <= end)
                {
                    Worker worker = list.ElementAt(i);

                    stringBuilder.Append(String.Format("{0,5}  {1,18}  {2,23}  {3,5}  {4,7}  {5,12}  {6,15}\n", worker.iD.ToString(), worker.dateAndTime.ToString("dd.MM.yyyy HH:mm"),
                        worker.fullName, worker.age.ToString(), worker.height.ToString(), worker.dateOfBirth.ToString("dd.MM.yyyy"), worker.placeOfBirth));
                }
            }
            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        /// Sort by descending
        /// </summary>
        /// <param name="list"></param>
        public static void SortByDescending(List<Worker> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list.ElementAt(i).dateAndTime < list.ElementAt(j).dateAndTime)
                    {
                        Worker temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Sort by Ascending
        /// </summary>
        /// <param name="list"></param>
        public static void SortByAscending(List<Worker> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list.ElementAt(i).dateAndTime > list.ElementAt(j).dateAndTime)
                    {
                        Worker temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Overwriting the changed data to a file
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="list"></param>
        public static void writeToFile(String filename, List<Worker> list)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Worker worker = list.ElementAt(i);
                        String line = worker.iD.ToString() + "#" + worker.dateAndTime.ToString("dd.MM.yyyy HH:mm") + "#" + worker.fullName + "#" + worker.age.ToString()
                        + "#" + worker.height.ToString() + "#" + worker.dateOfBirth.ToString("dd.MM.yyyy") + "#" + worker.placeOfBirth;

                        streamWriter.WriteLine(line);
                    }
                    Console.WriteLine("The data was successfully written to the file");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not open file for writing");
            }
        }

        /// <summary>
        /// Read From File
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static List<Worker> readFromFile(String filename)
        {
            List<Worker> list = new List<Worker>();
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] words = line.Split('#');

                        int ID = Int32.Parse(words[0]);
                        DateTime DateAndTime = DateTime.ParseExact(words[1], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
                        String FullName = words[2];
                        int Age = Int32.Parse(words[3]);
                        float Height = float.Parse(words[4]);
                        DateTime DateOfBirth = DateTime.ParseExact(words[5], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        String PlaceOfBirth = words[6];

                        Add(list, ID, DateAndTime, FullName, Age, Height, DateOfBirth, PlaceOfBirth);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Could not open file for writing or the format is wrong!!");
            }
            return list;
        }

        /// <summary>
        /// Sort by field
        /// </summary>
        /// <param name="list"></param>
        public static void sortByField(ref List<Worker> list)
        {
            Console.WriteLine("1-ID\t2-DateAndTime\t3-FullName\t4-Age\t5-Heigth\t6-DateOfBirth\t7-PlaceOfBirth");
            int choseSort = Int32.Parse(Console.ReadLine());
            if (choseSort < 1 || choseSort > 7)
            {
                Console.WriteLine("Wrong choice, Choose from 1 to 7.");
                return;
            }
            bool ascend = true;
            Console.WriteLine("1-AscendingSort\t2-DescendingSort");
            int chose = Int32.Parse(Console.ReadLine());
            if (chose == 1)
                ascend = true;
            else if (chose == 2)
                ascend = false;
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            switch (choseSort)
            {
                case 1:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).iD > list.ElementAt(j).iD)
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).iD < list.ElementAt(j).iD)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).dateAndTime.ToUniversalTime() > list.ElementAt(j).dateAndTime.ToUniversalTime())
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).dateAndTime.CompareTo(list.ElementAt(j).dateAndTime) < 0)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).fullName.CompareTo(list.ElementAt(j).fullName) > 0)
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).fullName.CompareTo(list.ElementAt(j).fullName) < 0)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
                case 4:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).age > list.ElementAt(j).age)
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).age < list.ElementAt(j).age)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
                case 5:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).height > list.ElementAt(j).height)
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).height < list.ElementAt(j).height)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).dateOfBirth.CompareTo(list.ElementAt(j).dateOfBirth) > 0)
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).dateOfBirth.CompareTo(list.ElementAt(j).dateOfBirth) < 0)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
                case 7:
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (ascend)
                                {
                                    if (list.ElementAt(i).placeOfBirth.CompareTo(list.ElementAt(j).placeOfBirth) > 0)
                                    {
                                        Worker temp = list[i];
                                        list[i] = list[j];
                                        list[j] = temp;
                                    }
                                }
                                else if (list.ElementAt(i).placeOfBirth.CompareTo(list.ElementAt(j).placeOfBirth) < 0)
                                {
                                    Worker temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                    }
                    break;
            }
        }

    }
}
