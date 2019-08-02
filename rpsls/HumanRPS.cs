using System;
namespace rpsls
{
  
        public class HumanRPS : Player
        {
            //Member Variables (Has A)



            //Construcor (Spawner)
            public HumanRPS()
            {
                this.name = name;
            }

            //Member Methods (Can Do)
            public override string MakeChoice()
            {

                Console.WriteLine(name + ", make your decision: Rock, Paper or Scissors");
                string playerInput = Console.ReadLine().ToLower();
                switch (playerInput)
                {
                    case "rock":
                        gesture = playerInput;
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        HideText();
                        break;
                    case "paper":
                        gesture = playerInput;
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        HideText();
                        break;
                    case "scissors":
                        gesture = playerInput;
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        HideText();
                        break;
                    default:
                        Console.WriteLine("You can't win this game with bananas or flamingos.");
                        MakeChoice();
                        break;
                }

                HideText();
                return gesture;
            }
            public override void ChooseName()
            {
                Console.WriteLine("Please Enter your name");
                name = Console.ReadLine();


            }
            public override void HideText()
            {
                int ChosenGesture = Console.CursorTop;
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(" ", Console.WindowWidth);
                Console.SetCursorPosition(0, ChosenGesture);
            }

        }
    


}
