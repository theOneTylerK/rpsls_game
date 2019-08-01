using System;
namespace rpsls
{
    public class Human : Player
    {
        //Member Variables (Has A)



        //Construcor (Spawner)
        public Human()
        {
            this.name = name;
        }

        //Member Methods (Can Do)
        public override string MakeChoice()
        {

            Console.WriteLine(name + ", make your decision: Rock, Paper, Scissors, Lizard, or Spock.");
            string playerInput = Console.ReadLine().ToLower();
            switch (playerInput)
            {
                case "rock":
                    Console.WriteLine("Your choice has been logged");
                    gesture = playerInput;
                    break;
                case "paper":
                    Console.WriteLine("Your choice has been logged");
                    gesture = playerInput;
                    break;
                case "scissors":
                    Console.WriteLine("Your choice has been logged");
                    gesture = playerInput;
                    break;
                case "lizard":
                    Console.WriteLine("Your choice has been logged");
                    gesture = playerInput;
                    break;
                case "spock":
                    Console.WriteLine("Your choice has been logged");
                    gesture = playerInput;
                    break;
                default:
                    Console.WriteLine("You can't win this game with bananas or flamingos.");
                    MakeChoice();
                    break;
            }
            return gesture;
        }
        public override void ChooseName()
        {
            Console.WriteLine("Please Enter your name");
            name = Console.ReadLine();
            

        }
            
    }
}

