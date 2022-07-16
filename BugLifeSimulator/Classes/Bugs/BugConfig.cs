using System;
using System.Collections.Generic;
using System.Text;

namespace BugLifeSimulator.Classes.Bugs
{
    public class BugConfig
    {
        public List<Config> bugConfig { get; set; }
    }

    public class Config
    {
        public string type { get; set; }
        public int lifePoints { get; set; }
        public int moveSpeed { get; set; }
    }
}
