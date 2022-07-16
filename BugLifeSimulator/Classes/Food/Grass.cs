using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes.Food
{
    public class Grass : Food
    {
        // Everything from the base class is inherited to derived class.
        // Members marked private are not accessible to derived classes for integrity purpos
        // If you need to make them accessible in derived class, mark the members as protected.

        public Grass(int fieldWidth, int fieldHeight) : base(fieldWidth, fieldHeight)
        {
            _lifePoints = 2;
        }
    }
}
