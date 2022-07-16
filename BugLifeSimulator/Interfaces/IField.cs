using BugLifeSimulator.Classes;
using BugLifeSimulator.Classes.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Interfaces
{
    public interface IField
    {
        ICollection<Bug> CreateBerryBugs(int count); 
        ICollection<IFood> CreateGrassFood(int count);
    }
}
