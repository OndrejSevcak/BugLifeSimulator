using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Interfaces
{
    //Object orientated programming principles say that, the internal workings of a class should be hidden from the outside world.
    //If you expose a field you're in essence exposing the internal implementation of the class.
    //Therefore we wrap fields with Properties to give us the ability to change the implementation without breaking code depending on us.

    public interface IBug
    {
        void Move();
        void Eat(int lifePoints);
        void Starve();
        bool IsAlive();
    }
}
