using System;
using System.Collections.Generic;
using System.Text;

namespace RACE
{
    sealed class User 
    {
        private static User instance;
        private static User user = new User();

        public static User Player
        {
            get { return user; }
        }

        public string name = Console.ReadLine();
  
        public static User getInstance()
        {
            if (instance == null)
                instance = new User();
            return instance;
        }
    }

  
}
