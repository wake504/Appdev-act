class Program {

    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator (Supports '-' '+' 'x' '%')");
        while (true)
        {

            Console.Write("Enter first number (input 'q' to quit)\n");
            var aInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(aInput)) continue;
            if (aInput.Trim().ToLower() == "q") break;
            if (!double.TryParse(aInput, out double a)) { Console.WriteLine("Invalid number"); continue; }

            Console.Write("Choose operation ('-' '+' 'x' '%')\n");
            var op = Console.ReadLine()?.Trim();


            Console.Write("Enter second Number\n");
            var bInput = Console.ReadLine();
            if (!double.TryParse(bInput, out double b)) { Console.WriteLine("Invalid number"); continue; }

            double result = 0;
            if (op == "+") result = a + b;
            else if(op == "-") result = a - b;
            else if (op == "x") result = a * b;
            else if (op == "%") result = a / b;
            else { Console.WriteLine("Invalid operation"); continue; }

            Console.WriteLine($"Result: {result}\n");


        }

    }
}
