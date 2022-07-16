using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Interfaces
{
    public interface ILogger
    {
        void Log(string message);
        void EmptyLine();
    }    
}
