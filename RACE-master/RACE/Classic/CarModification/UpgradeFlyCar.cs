using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class UpgradedFlyCar : CarDecorator
    {

        public UpgradedFlyCar(Car c) : base(c.NameOfCar, c)
        {

        }
        public override int PutNewEngine()
        {
            return car.EPower() + 150;
        }
        public override int Cost()
        {
            return car.Cost() + 920;
        }

    }
}
