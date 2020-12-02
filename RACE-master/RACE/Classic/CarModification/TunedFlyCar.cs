using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic
{
    class TunedFlyCar : CarDecorator
    {

        public TunedFlyCar(Car c) : base(c.NameOfCar, c)
        {

        }
        public override int Cost()
        {
            return car.Cost() + 500;
        }

        public override int PutNewEngine()
        {
            return car.PutNewEngine() + 125;
        }

        public override void ChooseColour()
        {
            Console.WriteLine("Select a colour");
            Colour = Console.ReadLine();



        }
        public override void Painting()
        {

            Console.WriteLine("Your car are painting...");
            Console.WriteLine("The car was painted");
        }
    }
}
