using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class JustCar : Car
    {
        public JustCar(string name): base(name) { }
        public override int Cost()
        {
            return 0;
        }
    }
}
