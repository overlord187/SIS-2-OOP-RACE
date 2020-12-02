using RACE.Classic.MechanicsOfTheGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{ 
    abstract class CarDecorator : Car
    {
        protected Car car;
        public CarDecorator(string name, Car car) : base(name)
        {
            this.car = car;
        }
       

    }
}
