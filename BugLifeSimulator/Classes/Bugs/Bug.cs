using BugLifeSimulator.Classes.Bugs;
using BugLifeSimulator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace BugLifeSimulator.Classes
{
    public class Bug : IBug
    {
        protected int _lifePoints;
        protected int _moveSpeed;             //this is a field, private to this class storing actual data
        protected BugType _type;

        public int X;            //x,y are coordinates of the current bug position and therefore are private fields
        public int Y;
        public int _bugNumber;


        protected int _filedWidth;
        protected int _filedHeight;


        private Random _random;
        private readonly ILogger _logger;
        private BugConfig _bugConfig;

        private static int BugNumberSeed = 0;

        //constructor
        public Bug(int fieldWidth, int fieldHeight, ILogger logger)
        {
            _random = new Random();
            X = _random.Next(1, fieldWidth);
            Y = _random.Next(1, fieldHeight);

            _filedHeight = fieldHeight;
            _filedWidth = fieldWidth;
            _logger = logger;

            _bugNumber = BugNumberSeed;
            BugNumberSeed++;

            _type = BugType.bug;
            _bugConfig = LoadConfiguration();
            _lifePoints = _bugConfig.bugConfig.Where(c => c.type == _type.ToString()).FirstOrDefault().lifePoints;
            _moveSpeed = _bugConfig.bugConfig.Where(c => c.type == _type.ToString()).FirstOrDefault().moveSpeed;
        }

        private BugConfig LoadConfiguration()
        {
            var configFilePath = System.IO.Path.Combine(Environment.CurrentDirectory + @"\Classes\Bugs\BugConfig.json");
            var jsonString = System.IO.File.ReadAllText(configFilePath);
            var data = JsonSerializer.Deserialize<BugConfig>(jsonString);

            return data;
        }

        public void Move()
        {
            //Random move - change the x or y by a random number from 1 to 3
            int direction = _random.Next(1, 4);
            switch (direction)
            {
                case 1:
                    if (X++ <= _filedWidth)
                    {
                        X++;
                    }
                    else
                    {
                        throw new Exception("Can move outside the field");
                    };
                    break;
                case 2:
                    if (Y++ <= _filedHeight)
                    {
                        Y++;
                    }
                    else
                    {
                        throw new Exception("Can move outside the field");
                    };
                    break;
                case 3:
                    if (X-- >= 0)
                    {
                        X--;
                    }
                    else
                    {
                        throw new Exception("Can move outside the field");
                    };
                    break;
                case 4:
                    if (Y-- >= 0)
                    {
                        Y--;
                    }
                    else
                    {
                        throw new Exception("Can move outside the field");
                    };
                    break;
            }
            _logger.Log($"Bug number: {_bugNumber} just moved to position {X}, {Y}");
        }

        public void Eat(int lifePoints)
        {
            _lifePoints += lifePoints;
            _logger.Log($"Bug number: {_bugNumber} ****JUST FOUND FOOD****. His LifePoints are: {_lifePoints}");
        }

        public void Starve()
        {
            _lifePoints -= 1;
            _logger.Log($"Bug number: {_bugNumber} is staarving! His LifePoints are: {_lifePoints}");
        }

        public bool IsAlive()
        {
            return _lifePoints > 0 ? true : false;
        }
    }
}
