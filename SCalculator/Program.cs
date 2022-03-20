using System;

namespace SCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            var command = "";
            while (command != "quit")
            {
                command = Console.ReadLine().ToLower();
                if (command == "quit")
                    break;
                calculator.SetInput(command);
                calculator.Action();
            }
        }
    }
}
