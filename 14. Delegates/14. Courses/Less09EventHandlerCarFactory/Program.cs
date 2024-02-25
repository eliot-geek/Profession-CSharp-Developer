namespace Less09EventHandlerCarFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory(10);

            var cars = factory.ToProduce(); 

            foreach (var item in cars) 
                Console.WriteLine(item);

            
            #region _Book

            // Events - they are used to define methods that are automatically called when a specific situation occurs, such as when a button is clicked.
            // Events are often described as actions that happen with an object.
            // Events can also be characterized as a way of exchanging messages between two objects.

            // Note. Delegates and events are some of the most advanced features of the C# language
            // and learning them may take some time, so don't worry if you don't understand their principles immediately!
            // Source: Mark J. Price.
            // C# 7 and .NET Core. Cross-platform development for professionals.
            // 3rd ed. - St. Petersburg: Peter, 2018. - 640 p.: Ill. - (Series "Programmer's Library"). p. 219

            #endregion

        }
    }
}
