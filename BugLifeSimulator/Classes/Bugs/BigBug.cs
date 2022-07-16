using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes
{
    public class BigBug : Bug
    {
        public BigBug(int fieldWidth, int fieldHeight, ILogger logger) : base(fieldWidth, fieldHeight, logger)
        {
            _type = BugType.BigBug;
        }

    }
}
