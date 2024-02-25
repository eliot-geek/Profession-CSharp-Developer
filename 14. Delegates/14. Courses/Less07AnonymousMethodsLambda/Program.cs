namespace Less07AnonymousMethodsLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = ApiService.GetData();

            DataProcessing processing = new DataProcessing(data);

            processing.SetProcess(TestMethod);
            processing.ActionProcessing();
            Console.ReadLine();


            // Set process using an anonymous method (delegate keyword - no name)
            processing.SetProcess(delegate (string Message)
            {
                Console.WriteLine(Message);
                File.WriteAllText("test.txt", Message);
            });
            processing.ActionProcessing();
            Console.ReadLine();


            // Set process using a lambda expression
            processing.SetProcess((string Message) =>
            {
                Console.WriteLine(Message);
                File.WriteAllText("test.txt", Message);
            });
            processing.ActionProcessing();
            Console.ReadLine();


            // Set process using a lambda expression without parentheses if only one parameter
            processing.SetProcess(Message =>
            {
                Console.WriteLine(Message);
                File.WriteAllText("test.txt", Message);
            });
            processing.ActionProcessing();
            Console.ReadLine();


            // Set process using a lambda expression with single parameter and no curly braces (implicit body)
            processing.SetProcess(e =>
            {
                Console.WriteLine(e);
                File.WriteAllText("test.txt", e);
            });
            processing.ActionProcessing();
            Console.ReadLine();


            // Set process using a lambda expression with single parameter and implicit body (single statement)
            processing.SetProcess(e => Console.WriteLine(e));
            processing.ActionProcessing();
            Console.ReadLine();


            // Set process using a lambda expression to write to a different file
            processing.SetProcess(e => File.WriteAllText("test12345.txt", e));
            processing.ActionProcessing();
            Console.ReadLine();
        }

        static void TestMethod(string Message)
        {
            Console.WriteLine(Message);
            File.WriteAllText("test.txt", Message);
        }
    }
}
