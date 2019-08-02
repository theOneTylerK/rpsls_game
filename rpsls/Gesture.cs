using System;
using System.Collections.Generic;

namespace rpsls
{
    public class Gesture
    {
        // member variables (Has A)
        public string name;
        public List<Gesture> GestureOptions;
        

        //Constructor (Spawner)
        public Gesture(string name)
        {
            this.name = name;
            GestureOptions = new List<Gesture>();
            Gesture rock = new Gesture("rock");
            GestureOptions.Add(rock);
            Gesture paper = new Gesture("paper");
            GestureOptions.Add(paper);
            Gesture scissors = new Gesture("scissors");
            GestureOptions.Add(scissors);

     
        }

        //member methods (Can Do)
        
       

    }
}
