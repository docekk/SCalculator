using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;

namespace SCalculator
{
    public class Calculator : Check
    {
        private string command;
        private IList<Argument> arguments;
        public Calculator()
        {
            arguments = new List<Argument>();
        }
        public void SetInput(string value)
        {
            command = value;
        }
        public void Action()
        {
            if (IfAdd(command))
            {
                Declaration();
            }
            else if (IfCalc(command))
            {
                Calculate();
            }
            else if (IfClear(command))
            {
                Console.Clear();
            }
            else if (IfHelp(command))
            {
                Help();
            }
            else
            {
                NotCommand();
            }
        }
        void Declaration()
        {
            command = command.Replace("arg ", string.Empty);
            arguments.Add(new Argument(command));
        }
        void Calculate()
        {
            if (command.Contains("="))
                command = command.Replace("= ", string.Empty);
            else
                command = command.Replace("calc ", string.Empty);
            var exp = new Expression(command);
            foreach (var argument in arguments)
                exp.addArguments(argument);
            Console.WriteLine(exp.calculate());
        }
        void Help()
        {
            Console.Write("1. Przykład deklaracji:\narg x = 5\n2. Przykład obliczenia:\na) calc x + y\nb) = x + y\n3.Aby wyjść:\nquit\n");
        }

    }
}
