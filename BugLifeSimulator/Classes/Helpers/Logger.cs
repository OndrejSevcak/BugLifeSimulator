using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes
{
    public class Logger : ILogger
    {
        public void EmptyLine()
        {
            Console.WriteLine();
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
