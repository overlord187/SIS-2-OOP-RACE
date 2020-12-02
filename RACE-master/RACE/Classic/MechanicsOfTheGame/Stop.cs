using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class Stop : IRaceOnTheTrack
    {
        public void Move()
        {
            Console.WriteLine("Stop!");
        }
    }
}
