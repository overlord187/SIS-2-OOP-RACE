using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class HeavinlyRacing : IGame
    {
       

        public void Start()
        {
            Console.WriteLine("Get ready to fly up... Game start in Heavenly mode...");
        }
        public void Finish()
        {
            Console.WriteLine("The race is over");
        }
    }
}
