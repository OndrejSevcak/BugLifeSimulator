using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Interfaces
{
    public interface IFood
    {
        void Grow();
        int HasBeenFound(int x, int y);
        int CurrentLifePoints();
    } 
}
