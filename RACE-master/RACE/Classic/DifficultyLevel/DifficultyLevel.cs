using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic.DifficultyLevel
{
    abstract  class DifficultyLevel
    {
        public string Level { get; set; }

        public DifficultyLevel(string level)
        {
            this.Level = level;
        }
        abstract public Bots Create();
    }

    
}
