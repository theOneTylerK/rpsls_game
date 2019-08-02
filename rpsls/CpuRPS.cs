using System;
namespace rpsls
{
    
    public class CpuRPS : Player
    { //Member Variables (Has A)



        //Construcor (Spawner)
        public CpuRPS()
        {
            this.name = name;


        }

        //Member Methods (Can Do)
        public override string MakeChoice()
        {
            Random rnd = new Random();
            int CpuChoice = rnd.Next(AvailableGestures.Count -2);
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
