using System;
using System.Collections.Generic;

namespace rpsls
{
    public abstract class Game
    {
        //Member Variables (Has A)
        public bool isRunning;
        public string Rules;
        public Player PlayerOne;
        public Player PlayerTwo;




        //Construcor (Spawner)
        public Game()
        {
            


        }

        //Member Methods (Can Do)




        public abstract void EstablishPlayers();
        

        public abstract void DisplayRules();
        

        public abstract void CompareGestures(string PlayerOneChoice, string PlayerTwoChoice);
       
        public abstract void RestartGame();
        

        public abstract void StartGame();

        public abstract void TryAgain();
        
    }
}
