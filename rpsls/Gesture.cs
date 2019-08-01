using System;
using System.Collections.Generic;

namespace rpsls
{
    public class Gestures
    {
        // member variables (Has A)
        List<string> AvailableGestures;

        //Constructor (Spawner)
        public Gestures()
        {
            AvailableGestures = new List<string>();
            AvailableGestures.Add("rock");
            AvailableGestures.Add("paper");
            AvailableGestures.Add("scissors");
            AvailableGestures.Add("lizard");
            AvailableGestures.Add("spock");
     
        }

        //member methods (Can Do)
        public string ChooseGesture()
        {

           Console.WriteLine("Make your decision: ");
            foreach (string el in AvailableGestures)
                Console.WriteLine(el);
            string PlayerChoice = Console.ReadLine().ToLower();
                return PlayerChoice;
            
        }
       

    }
}
