using System;

namespace SCalculator
{
    public abstract class Check
    {
        public bool IfAdd(string input)
        {
            if (input.Contains("arg"))
                return true;
            else 
                return false;
        }
        public bool IfCalc(string input)
        {
            if ((input.Contains("calc"))||(input.Contains("=")))
                return true;
            else
                return false;
        }
        public bool IfHelp(string input)
        {
            if (input.Contains("help"))
                return true;
            else
                return false;
        }
        public bool IfClear(string input)
        {
            if (input.Contains("clear"))
                return true;
            else
                return false;
        }
        public void NotCommand()
        {
            Console.WriteLine("Niepoprawna komenda! Użyj 'help' by zobaczyć dostępne komendy!");
        }
    }
}
