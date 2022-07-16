using BugLifeSimulator.Classes.Food;
using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes.Field
{
    public class Field : IField
    {
        protected int _width { get; }
        protected int _height { get; }

        public Field(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public ICollection<Bug> CreateBerryBugs(int count)
        {
            ICollection<Bug> bugColl = new List<Bug>();
            ILogger logger = new Logger();

            for (int i = 0; i < count; i++)
            {
                bugColl.Add(new BerryBug(_width, _height, logger));
            }

            return bugColl;
        }

        public ICollection<IFood> CreateGrassFood(int count)
        {
            ICollection<IFood> foodColl = new List<IFood>();

            for (int i = 0; i < count; i++)
            {
                foodColl.Add(new Grass(_width, _height));
            }

            return foodColl;
        }
    }
}
