using BugLifeSimulator.Classes;
using BugLifeSimulator.Classes.Field;
using BugLifeSimulator.Classes.Simulation;
using BugLifeSimulator.Interfaces;
using System;

namespace BugLifeSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IField field = new Field(5, 5);
            ILogger logger = new Logger();

            SimulationController controller = new SimulationController(field,logger);
            controller.Run();
        }
    }
}
