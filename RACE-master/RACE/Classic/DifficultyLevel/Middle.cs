using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic.DifficultyLevel
{
    class Middle : DifficultyLevel
    {
        public Middle(string level) : base(level) { }

        internal HardBots HardBots
        {
            get => default;
            set
            {
            }
        }

        public override Bots Create()
        {
            return new MiddleBots();
        }
    }
}
