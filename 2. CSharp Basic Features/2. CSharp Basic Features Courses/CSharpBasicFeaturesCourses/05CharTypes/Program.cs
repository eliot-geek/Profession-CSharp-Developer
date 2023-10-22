namespace _05CharTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The char type can contain one Unicode character 
            char VarChar1 = 'a'; Console.WriteLine(VarChar1); // a
            char VarChar2 = 'ю'; Console.WriteLine(VarChar2); // ю
            char VarChar3 = '!'; Console.WriteLine(VarChar3); // !
            char VarChar4 = '&'; Console.WriteLine(VarChar4); // &
            char VarChar5 = '9'; Console.WriteLine(VarChar5); // 9
            char VarChar6 = '§'; Console.WriteLine(VarChar6); // 󠅒󠅒
        }
    }
}