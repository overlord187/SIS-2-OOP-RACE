using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    class Game : IGame
    {
        public string Name { get; set; }
        public Game(string name, IGame start, IGame finish)
        {
            this.Name = name;
            StartGame = start;
            FinishGame = finish;
        }
        public IGame StartGame { private get; set; }
        public IGame FinishGame { private get; set; }
        public void Start()
        {
            StartGame.Start();
        }
        public void Finish()
        {
            FinishGame.Finish();
        }
    }
}
