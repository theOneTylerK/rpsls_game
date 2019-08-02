using System;
using System.Collections.Generic;

namespace rpsls
{
    public abstract class Player
    {
        //Member Variables (Has A)
        public int WinCounter;
        public string name;
        public string gesture;
        protected List<string> AvailableGestures;

        //Constructor (Spawner)
        public Player()
        {
            WinCounter = 0;
            this.name = name;
            AvailableGestures= new List<string>();

            AvailableGestures.Add("rock");
            AvailableGestures.Add("paper");
            AvailableGestures.Add("scissors");
            AvailableGestures.Add("lizard");
            AvailableGestures.Add("spock");

        }

        //member Methods (Can Do)
        public abstract void ChooseName();


        public abstract string MakeChoice();

        public abstract void HideText();
        
    }
}
