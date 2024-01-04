namespace _08FormattedOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compound formatting
            string firstName = "Alexander";
            string lastName = "Pushkin";
            string specialization = "Writer";
            byte age = 37;
            ulong yearOfBirth = 1799;

            // AlexanderPushkinWriter371799
            Console.WriteLine(firstName + lastName + specialization + age + yearOfBirth);
            Console.ReadKey();


            // Alexander Pushkin Writer 37 1799.
            Console.WriteLine(firstName + " " + lastName + " " + specialization + " " + age + " " + yearOfBirth);
            Console.ReadKey();

            // First Name: Alexander Last Name: Pushkin Specialization: Writer Age: 37 Year of Birth:1799
            Console.WriteLine("First Name: " + firstName + " Last Name: " + lastName + " Specialization: " + specialization + " Age: " + age + " Year of birth: " + yearOfBirth);
            Console.ReadKey();

            // Name: Alexander Last Name: Pushkin Specialization: Writer Age: 37 Year of Birth:1799
            Console.WriteLine("First Name: {0} Last Name: {1} Specialization: {2} Age: {3} Year of birth: {4}",
                               firstName,
                               lastName,
                               specialization,
                               age,
                               yearOfBirth);
            Console.ReadKey();

            // First name: Alexander LastName: Pushkin Specialization: Writer Age: 37 YearOfBirth:1799
            string pattern = "First Name: {0} Last Name: {1} Specialization: {2} Age: {3} Year of birth: {4}";
            Console.WriteLine(pattern,
                              firstName,
                              lastName,
                              specialization,
                              age,
                              yearOfBirth);


            #region re-use pattern

            Console.ReadKey();

            string fName = "Anders";
            string lName = "Hejlsberg";
            string profession = "Programmer";
            byte years = 37;
            ulong birth = 1815;

            Console.WriteLine(pattern,
                              fName,
                              lName,
                              profession,
                              years,
                              birth);
            #endregion

        }
    }
}