using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class SportCar : Car
    {
        public SportCar(string name): base(name) { }

        public override int MaxSpeed()
        {
            return 380;
        }
        public override int EPower()
        {
            return 250;
        }
        public override int Cost()
        {
            return 1000;
        }
    }
}
