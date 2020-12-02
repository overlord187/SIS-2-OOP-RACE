using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class ClassicRacing : IGame
    {
        public void Start()
        {
            Console.WriteLine("The game begins in Classic race mode...");
        }
             
        public void Finish()
        {
            Console.WriteLine("The race is over");
        }
    }
}
