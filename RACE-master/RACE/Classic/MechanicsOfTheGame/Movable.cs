using System;
using System.Collections.Generic;
using System.Text;

namespace RACE.Classic.MechanicsOfTheGame
{
    class Movable :IRaceOnTheTrack, IObservable
    {
        public Movable(IRaceOnTheTrack m)
        {
            RaceOnTheTrack = m;
        }
        public IRaceOnTheTrack RaceOnTheTrack { private get; set; }
        public void Move()
        {
            RaceOnTheTrack.Move();
        }
        //====================================================================//
        //Observer//

        Obstacle obstacle;

        List<IObserver> observers;

        public Movable()
        {
            observers = new List<IObserver>();
            obstacle = new Obstacle();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        } 
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        
        public void NotifyObservers()
        {
            foreach(IObserver o in observers)
            {
                o.Warning(obstacle);
            }
        }

        public void RoadHazards() 
        {
            Random random = new Random();
            obstacle.Big = random.Next(3, 9);
            obstacle.Little = random.Next(10, 30);
            NotifyObservers();
        }
    }
    
}
