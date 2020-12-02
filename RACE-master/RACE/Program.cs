using System;
using RACE.Classic;
using RACE.Classic.DifficultyLevel;
using RACE.Classic.MechanicsOfTheGame;

namespace RACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Produced by Raufat and Diyaz for SIS 2");
            Console.WriteLine("WELCOME TO THE MOST EXTREME RACING EVER!!!");
            Console.WriteLine("Please select a game mode"); // Classic or Heavinly
            string choice=Console.ReadLine();
            if (choice.Equals("Classic"))
            {
                Console.WriteLine("Enter your name");
                Game game = new Game(User.Player.name, new ClassicRacing(), new ClassicRacing()) ;
                Console.WriteLine("Enter name of car");
                string NameOfCar = Console.ReadLine();
                Console.WriteLine("Do you want to mofidy the car?");
                string answer = Console.ReadLine();
                if (answer.Equals("Yes"))
                {
                    Console.WriteLine("Select a car"); //JustCar or SportCar
                    string answer2 = Console.ReadLine();
                    if (answer2.Equals("Just car"))
                    {
                       
                        Car car = new JustCar(NameOfCar);
                        Console.WriteLine("Do you want to change a color of car?");
                        string answer3 = Console.ReadLine();
                        if (answer3.Equals("No"))
                        {
    
                        }
                        if (answer3.Equals("Yes"))
                        {
                            
                            car = new TunedCar(car);
                            car.ChooseColour();
                            car.Painting();
                            
                        }
                        Console.WriteLine("Do you want to put a new engine?");
                        string answer4 = Console.ReadLine();
                        if (answer4.Equals("Yes"))
                        {
                            car = new UpgradedCar(car);
                            car.PutNewEngine();
                            car.PrintCharacteristics();
                        }
                        if (answer4.Equals("No"))
                        {
                            car.PrintCharacteristics();
                        }


                    }
                    if (answer2.Equals("Sport car"))
                    {
                        
                        
                        Car car = new SportCar(NameOfCar);
                        Console.WriteLine("Do you want to change a color of car?");
                        string answer3 = Console.ReadLine();
                        if (answer3.Equals("No"))
                        {
                        }
                        if (answer3.Equals("Yes"))
                        {
                            car = new TunedCar(car);
                            car.ChooseColour();
                            car.Painting();
                            car.PrintCharacteristics();
                        }
                        Console.WriteLine("Do you want to put a new engine?");
                        string answer4 = Console.ReadLine();
                        if (answer4.Equals("Yes"))
                        {
                            car = new UpgradedCar(car);
                            car.PutNewEngine();
                            car.PrintCharacteristics();
                        }
                        if (answer4.Equals("No"))
                        {
                            car.PrintCharacteristics();
                        }

                    }
                }
                else
                {
                    Car car = new JustCar(NameOfCar);
                    car.PrintCharacteristics();
                    
                   
                }

                Console.WriteLine("Select the difficulty level of the game");
                string level = Console.ReadLine(); // easy, middle, hard
                if (level.Equals("Easy"))
                {
                    DifficultyLevel dif = new Easy(level);
                    Bots bots = dif.Create();
                }
                if (level.Equals("Middle"))
                {
                    DifficultyLevel dif = new Middle(level);
                    Bots bots = dif.Create();
                }
                if (level.Equals("Hard"))
                {
                    DifficultyLevel dif = new Hard(level);
                    Bots bots = dif.Create();
                }

                Console.WriteLine("Please, wait, game is about to start");
                game.Start();
                Movable mova = new Movable(); // observer
                Car observer = new Car(NameOfCar, mova);
                mova.RoadHazards();
                    Movable mov = new Movable(new Forward());
                    mov.Move();
                while (true)
                {
                    string moving = Console.ReadLine();
                    if (moving.Equals("Left"))
                    {
                        Movable mov1 = new Movable(new ToTheLeft());
                        mov1.Move();
                    }
                    if (moving.Equals("Right"))
                    {
                        Movable mov2 = new Movable(new ToTheRight());
                        mov2.Move();
                    }
                    if (moving.Equals("Forward"))
                    {
                        Movable mov3 = new Movable(new Forward());
                        mov3.Move();
                    }
                    if (moving.Equals("Stop"))
                    {
                        Movable mov4 = new Movable(new Stop());
                        mov4.Move();
                        Console.WriteLine("Do you want to finish game?");
                        string finish = Console.ReadLine();
                        if (finish.Equals("Yes"))
                        {
                            game.Finish();
                        }                           
                    }
                }
            }
            if (choice.Equals("Heavenly")) // небесный режим
            {
                Console.WriteLine("Enter your name");
                Game game = new Game(User.Player.name, new HeavinlyRacing(), new HeavinlyRacing());
                Console.WriteLine("Enter name of Flycar");
                string NameOfCar = Console.ReadLine();
                Console.WriteLine("Do you want to mofidy your Flycar?");
                string answer = Console.ReadLine();
                if (answer.Equals("Yes"))
                {
                    Console.WriteLine("Select a car"); //FlyCar or Roket
                    string answer2 = Console.ReadLine();
                    if (answer2.Equals("FlyCar"))
                    {

                        Car car = new JustCar(NameOfCar);
                        Console.WriteLine("Do you want to change a color of yout Flycar?");
                        string answer3 = Console.ReadLine();
                        if (answer3.Equals("No"))
                        {

                        }
                        if (answer3.Equals("Yes"))
                        {

                            car = new TunedFlyCar(car);
                            car.ChooseColour();
                            car.Painting();

                        }
                        Console.WriteLine("Do you want to put a new engine?");
                        string answer4 = Console.ReadLine();
                        if (answer4.Equals("Yes"))
                        {
                            car = new UpgradedFlyCar(car);
                            car.PutNewEngine();
                            car.PrintCharacteristics();
                        }
                        if (answer4.Equals("No"))
                        {
                            car.PrintCharacteristics();
                        }


                    }
                    if (answer2.Equals("Rocket"))
                    {


                        Car car = new Raket(NameOfCar);
                        Console.WriteLine("Do you want to change a color of your Fly transport?");
                        string answer3 = Console.ReadLine();
                        if (answer3.Equals("No"))
                        {
                        }
                        if (answer3.Equals("Yes"))
                        {
                            car = new TunedFlyCar(car);
                            car.ChooseColour();
                            car.Painting();
                            car.PrintCharacteristics();
                        }
                        Console.WriteLine("Do you want to put a new engine?");
                        string answer4 = Console.ReadLine();
                        if (answer4.Equals("Yes"))
                        {
                            car = new UpgradedFlyCar(car);
                            car.PutNewEngine();
                            car.PrintCharacteristics();
                        }
                        if (answer4.Equals("No"))
                        {
                            car.PrintCharacteristics();
                        }

                    }
                }
                else
                {
                    Car car = new FlyCar(NameOfCar);
                    car.PrintCharacteristics();


                }

                Console.WriteLine("Select the difficulty level of the game");
                string level = Console.ReadLine(); // easy, middle, hard
                if (level.Equals("Easy"))
                {
                    DifficultyLevel dif = new Easy(level);
                    Bots bots = dif.Create();
                }
                if (level.Equals("Middle"))
                {
                    DifficultyLevel dif = new Middle(level);
                    Bots bots = dif.Create();
                }
                if (level.Equals("Hard"))
                {
                    DifficultyLevel dif = new Hard(level);
                    Bots bots = dif.Create();
                }

                Console.WriteLine("Please, wait, game is about to start");
                game.Start();
                Movable mova = new Movable(); // observer
                Car observer = new Car(NameOfCar, mova);
                mova.RoadHazards();
                Movable mov = new Movable(new Forward());
                mov.Move();
                while (true)
                {
                    string moving = Console.ReadLine();
                    if (moving.Equals("Left"))
                    {
                        Movable mov1 = new Movable(new ToTheLeft());
                        mov1.Move();
                    }
                    if (moving.Equals("Right"))
                    {
                        Movable mov2 = new Movable(new ToTheRight());
                        mov2.Move();
                    }
                    if (moving.Equals("Forward"))
                    {
                        Movable mov3 = new Movable(new Forward());
                        mov3.Move();
                    }
                    if (moving.Equals("Nitro"))
                    {
                        Movable mov4 = new Movable(new Nitro());
                        mov4.Move();
                    }
                    if (moving.Equals("Stop"))
                    {
                        Movable mov4 = new Movable(new Stop());
                        mov4.Move();
                        Console.WriteLine("Do you want to finish game?");
                        string finish = Console.ReadLine();
                        if (finish.Equals("Yes"))
                        {
                            game.Finish();
                        }
                    }
                }
            }

        }
    }
}
