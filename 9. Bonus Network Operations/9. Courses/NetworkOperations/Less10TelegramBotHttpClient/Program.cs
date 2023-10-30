namespace Less10TelegramBotHttpClient
{
    internal class Program
    {
        HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync(
                "https://jsonplaceholder.typicode.com/todos");

            Console.WriteLine(response);
        }
    }
}