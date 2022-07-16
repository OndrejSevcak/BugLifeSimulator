using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes.Food
{
    public class Strawberry : Food
    {
        public Strawberry(int fieldWidth, int fieldHeight) : base(fieldWidth, fieldHeight)
        {
            _lifePoints = 3;
        }
    }
}
