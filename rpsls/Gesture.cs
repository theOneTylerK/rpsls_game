using System;
using System.Collections.Generic;

namespace rpsls
{
    public class Gesture
    {
        // member variables (Has A)
        public string name;
        public bool didWin;
        

        //Constructor (Spawner)
        public Gesture(string name)
        {
            name = "rock";
            didWin = false;
     
        }

        //member methods (Can Do)
        public bool GestureWon()
        {
            didWin = true;
            return didWin;
        }
       

    }
}
