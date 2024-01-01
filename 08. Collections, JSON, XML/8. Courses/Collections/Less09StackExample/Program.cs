namespace Less09StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operation

             string expression = " ( ( 2 + 2 ) * 2 )";            Console.WriteLine($"Expected result: {((2 + 2) * 2)}");
            // string expression = " ( ( 9 + ( 4 * 6 ) ) / 10 )";   Console.WriteLine($"Expected result: {((9.0 + (4 * 6)) / 10)}");
            // string expression = " ( ( 1 + ( 2 * 3 ) ) ^ 4 )";    Console.WriteLine($"Expected result: {Math.Pow(1 + (2 * 3), 4)}");

            var expressionArray = expression.Replace('(', ' ').Trim().Split(' ');
            Console.Write("Expression: ");
            foreach (var e in expressionArray)
            {
                Console.Write(e);
            }

            Stack<double> numbers = new Stack<double>();        // Stack for numbers
            Stack<string> operations = new Stack<string>();     // Stack for operations (+,-,*,/,etc...)

            foreach (var e in expressionArray)
            {
                double n;
                if (String.IsNullOrEmpty(e))
                {
                    continue;
                }
                if (double.TryParse(e, out n))
                {
                    numbers.Push(n);
                    continue;
                }
                if (@"+/*-^".IndexOf(e) > -1)
                {
                    operations.Push(e);
                    continue;
                }

                if (e == ")")
                {
                    double n1 = numbers.Pop();
                    double n2 = numbers.Pop();
                    string operation = operations.Pop();

                    switch (operation)
                    {
                        case "+":
                            numbers.Push(n2 + n1);
                            break;
                        case "-":
                            numbers.Push(n2 - n1);
                            break;
                        case "/":
                            numbers.Push(n2 / n1);
                            break;
                        case "*":
                            numbers.Push(n2 * n1);
                            break;
                        case "^":
                            numbers.Push(Math.Pow(n2, n1));
                            break;
                    }
                }
            }

            Console.Write("\nNumbers ");
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.Write("\nOperations ");
            foreach (var item in operations)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nActual result: {numbers.Pop()}");
        }
    }
}