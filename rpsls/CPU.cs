using System;
namespace rpsls
{
    public class CPU : Player
    { //Member Variables (Has A)



        //Construcor (Spawner)
        public CPU()
        {
        }

        //Member Methods (Can Do)
        public override void MakeChoice()
        {
            Console.WriteLine("Make your decision: Rock, Paper, Scissors, Lizard, or Spock?");
            string playerInput = Console.ReadLine().ToLower();
            switch (playerInput)
            {
                case "rock":
                    Console.WriteLine("You Chose rock");
                    gesture = playerInput;
                    break;
                case "paper":
                    break;
                case "scisors":
                    break;
                case "lizard":
                    break;
                case "spock":
                    break;
            }
        }
        public override void ChooseName()
        {
            Console.WriteLine("Please Enter your name");
            name = Console.ReadLine();
            

        }
    }
}
