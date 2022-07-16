using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes.Food
{
    public class Food : IFood  //Base class
    {
        protected int _lifePoints;      //protected members can be changed in derived classes
        private Random _random;

        public int X { get; }            //publicly available X filed, cant be set, just read
        public int Y { get; }

        public Food(int fieldWidth, int fieldHeight)   //constructor
        {
            _random = new Random();
            X = _random.Next(1, fieldWidth);        //set X and Y coordinates randomly within width and height of a Field
            Y = _random.Next(1, fieldHeight);
            _lifePoints = 1;
        }

        public void Grow()              //Interface implemented method
        {
            _lifePoints++;
        }

        public int HasBeenFound(int x, int y) //Return 0 if not found, or number of LifePoints if found
        {
            if (x == X && y == Y)
            {
                var value = _lifePoints;
                _lifePoints = 0;
                return value;
            }
            else
            {
                return 0;
            }
        }

        public int CurrentLifePoints()
        {
            return _lifePoints;
        }
    }
}
