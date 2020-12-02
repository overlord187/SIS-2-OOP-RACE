using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class FlyCar : Car
    {
        public FlyCar(string name) : base(name) { }
        public override int Cost()
        {
            return 0;
        }
    }
}
