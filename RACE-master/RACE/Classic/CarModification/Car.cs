using RACE.Classic.MechanicsOfTheGame;
using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class Car : IObserver
    {
        public string NameOfCar { get; set; }
        //==========================================================================//
        IObservable mova;
        

        public Car(string name, IObservable obs)
        {
            this.NameOfCar = name;
            mova = obs;
            mova.RegisterObserver(this);
        }
        //==================================================================//
        public Car(string name)
        {
            this.NameOfCar = name;
        }

        public virtual int MaxSpeed()
        {
            return 220;
        }
        public virtual int EPower()
        {
            return 125;
        }
        public virtual int TimeToAccelerate()
        {
            return 13;
        }
        public virtual void ChooseColour() {}
        public virtual void Painting() { }
        public virtual int PutNewEngine() { return 0; }
        public virtual int Cost() { return 0; }
        public string Colour { get; set; }
        public virtual void PrintCharacteristics()
        {
            Console.WriteLine("Your car : " + NameOfCar);
            Console.WriteLine("Colour : " + Colour);
            Console.WriteLine("Max speed : " + MaxSpeed());
            Console.WriteLine("Power of engine : " + PutNewEngine());
            Console.WriteLine("Cost : " + Cost());
        }

        //=================================================================//
        //observer//
        
        public void Warning(object ob)
        {
            Obstacle obstacle = (Obstacle)ob;
            Console.WriteLine("Num of big obstacles : " + obstacle.Big);
            Console.WriteLine("Num of little obstacles : " + obstacle.Little);
        }

    }

}


