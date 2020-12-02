using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class Raket : Car
    {
        public Raket(string name) : base(name) { }

        public override int MaxSpeed()
        {
            return 600;
        }
        public override int EPower()
        {
            return 450;
        }
        public override int Cost()
        {
            return 2670;
        }
    }
}