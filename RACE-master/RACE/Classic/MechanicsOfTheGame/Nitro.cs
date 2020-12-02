using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class Nitro : IRaceOnTheTrack
    {
        public void Move()
        {
            Console.WriteLine("Nitro turned on, you are flying at the speed of light 10 km straight");
        }
    }
}
