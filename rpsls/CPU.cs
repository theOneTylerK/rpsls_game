using System;
using System.Collections.Generic;

namespace rpsls
{
    public class CPU : Player
    { //Member Variables (Has A)
        


        //Construcor (Spawner)
        public CPU()
        {
            this.name = name;

           
        }

        //Member Methods (Can Do)
        public override string MakeChoice()
        {
            Random rnd = new Random();
            int CpuChoice = rnd.Next(AvailableGestures.Count);
            gesture = AvailableGestures[CpuChoice];
            return gesture;
        }

        public override void ChooseName()
        {
            Console.WriteLine("You are playing the CPU");
         

        }
        public override void HideText()
        {
            
            
          
        }
    }
}
