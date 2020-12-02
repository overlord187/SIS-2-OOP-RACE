using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic.DifficultyLevel
{
    class Easy : DifficultyLevel
    {
        public Easy(string level) : base(level) { }

        internal MiddleBots MiddleBots
        {
            get => default;
            set
            {
            }
        }

        public override Bots Create()
        {
            return new EasyBots();
        }
    }
}
