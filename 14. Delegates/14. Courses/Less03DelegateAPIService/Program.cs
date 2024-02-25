namespace Less03DelegateAPIService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get data from the API service
            var data = ApiService.GetData();

            DataProcessing processing = new DataProcessing(data);

            OptionDataProcessing option = new OptionDataProcessing(Handlers.SaveToTextFile);
            processing.SetProcess(option);
            processing.ActionProcessing();
            Console.WriteLine("SaveToTextFile Done!");
            Console.ReadKey();

            processing.SetProcess(Handlers.SaveToXmlFile);
            Console.WriteLine("SaveToXmlFile Done!");
            processing.ActionProcessing();
            Console.ReadKey();

            processing.SetProcess(Handlers.WriteToConsole);
            processing.ActionProcessing();
            Console.WriteLine("WriteToConsole Done!");
            Console.ReadKey();
        }
    }
}
