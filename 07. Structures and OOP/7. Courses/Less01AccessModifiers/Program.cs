using Less00IntroToStructures;

namespace Less01AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I linked the previous project by adding the public modifier before the Cat Struct

            Cat cat = new Cat();
            cat.Nickname = "Boomer";
            Console.WriteLine("Cat: {0}", cat.Nickname);

            #region Access Modifiers

            // 1. public: Members can be accessed from anywhere, both within the current assembly and from other assemblies.
            // 2. private: Members can only be accessed within the containing class. They are not accessible from outside the class or its derived classes.
            // 3. protected: Members are accessible within the containing class and its derived classes. They are not accessible from outside the class or unrelated classes.
            // 4. internal: Members are accessible within the same assembly but not from outside the assembly.
            // 5. protected internal: This access modifier allows access within the same assembly and from derived classes, even if they are in a different assembly.
            // 6. private protected: This access modifier allows access within the same assembly and from derived classes within that assembly but not from outside the assembly.

            #endregion
        }
    }
}