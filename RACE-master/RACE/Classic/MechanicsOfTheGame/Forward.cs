using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class Forward : IRaceOnTheTrack
    {
        public void Move()
        {
            Console.WriteLine("Movement to forward");
        }
    }
}
