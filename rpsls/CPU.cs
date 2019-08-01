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

            string playerInput = CpuChoice.ToString();
            switch (playerInput)
            {
                case "0":
                    playerInput = "rock";
                    Console.WriteLine("CPU choice has been logged");
                    gesture = playerInput;
                    break;
                case "1":
                    playerInput = "paper";
                    Console.WriteLine("CPU choice has been logged");
                    gesture = playerInput;
                    break;
                case "2":
                    playerInput = "scissors";
                    Console.WriteLine("CPU choice has been logged");
                    gesture = playerInput;
                    break;
                case "3":
                    playerInput = "lizard";
                    Console.WriteLine("CPU choice has been logged");
                    gesture = playerInput;
                    break;
                case "4":
                    playerInput = "spock";
                    Console.WriteLine("CPU choice has been logged");
                    gesture = playerInput;
                    break;
                default:
                    Console.WriteLine("Please choose an available option.");
                    break;
            }
            return gesture;
        }

        public override void ChooseName()
        {
            Console.WriteLine("You are playing the CPU");
         

        }
    }
}
