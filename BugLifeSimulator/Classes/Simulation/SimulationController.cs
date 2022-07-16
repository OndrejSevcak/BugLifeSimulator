using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BugLifeSimulator.Classes.Simulation
{
    public class SimulationController : ISimulation
    {
        private readonly IField _field;
        private readonly ILogger _logger;

        //constructor
        public SimulationController(IField field, ILogger logger)
        {
            _field = field;
            _logger = logger;
        }

        public void Run()
        {
            var bugs = _field.CreateBerryBugs(3);
            var grass = _field.CreateGrassFood(10);

            while (bugs.Any(bug => bug.IsAlive()))
            {
                foreach (var bug in bugs.Where(b => b.IsAlive()))
                {
                    try
                    {
                        bug.Move();
                        bool foodFound = false;
                        int grassLifePoints = 0;
                        foreach (var gras in grass)
                        {
                            if (gras.HasBeenFound(bug.X, bug.Y) > 0)
                            {
                                foodFound = true;
                                grassLifePoints = gras.CurrentLifePoints();
                            }
                        }
                        if (foodFound)
                        {
                            bug.Eat(grassLifePoints);
                        }
                        else
                        {
                            bug.Starve();
                            if (!bug.IsAlive())
                            {
                                _logger.Log($"Bug: {bug._bugNumber} !!!!!  JUST DIED !!!!!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        //can move outside of field
                    }
                }
            }
        }
    }
}
