using System;
namespace rpsls
{
    public abstract class Player
    {
        //Member Variables (Has A)
        public int WinCounter;
        public string name;
        public string gesture;

        //Constructor (Spawner)
        public Player()
        {
            WinCounter = 0;
            this.name = name;
            

        }

        //member Methods (Can Do)
        public abstract void ChooseName();


        public abstract string MakeChoice();
        
    }
}
