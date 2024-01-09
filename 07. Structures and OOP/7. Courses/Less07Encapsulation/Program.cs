namespace Less07Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Computer1 (Not suitable)
            // Because, for instance, we could deactivate a computer five times, which is already off (That's not normal).
            // The user must explicitly configure the program. But what about individuals who aren't familiar with the field? How would they understand? So not suitable

            Console.WriteLine("Computer 1");
            Computer1 computer1 = new Computer1("Computer 1");
            computer1.ActivationBIOS();
            computer1.ActivationOS();
            computer1.Greeting();

            computer1.Calculation();

            computer1.Parting();
            computer1.DeactivationOS();
            computer1.DeactivationBIOS();
            Console.ReadKey();

            #endregion

            #region Computer2 (Not suitable)

            Console.WriteLine("\nComputer 2");
            Computer2 computer2 = new Computer2("Computer 2");
            computer2.PowerOn();
            computer2.PowerOff();
            Console.ReadKey();

            #endregion

            #region Computer3 (Suitable)

            Console.WriteLine("\nComputer 3");
            Computer3 computer3 = new Computer3("Computer 3");
            for (int i = 0; i < 2; i++)
            {
                computer3.Power();
                Console.WriteLine(computer3.Indicator);
            }
            Console.ReadKey();

            #endregion
        }
    }
}