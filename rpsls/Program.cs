using System;
using System.Collections.Generic;

namespace rpsls
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            GameFactory factory = new GameFactory();
            Game game = factory.SelectGameMode();
            game.StartGame();

            
            
        }
    }
}
