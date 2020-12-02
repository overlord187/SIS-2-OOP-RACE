using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic.DifficultyLevel
{
    class Hard : DifficultyLevel
    {
        public Hard(string level): base(level) { }

 

        public override Bots Create()
        {
            return new HardBots();
        }
    }
}
