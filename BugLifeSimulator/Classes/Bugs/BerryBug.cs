using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes
{
    public class BerryBug : Bug
    {
        //all inherited from Bug
        public BerryBug(int fieldWidth, int fieldHeight, ILogger logger) : base(fieldWidth, fieldHeight, logger)
        {
            _type = BugType.berryBug;
        }
    }
}
