using System;
namespace rpsls
{
    public class Player
    {
        //Member Variables (Has A)
        public int WinCounter;
        public int PlayerNumber;

        //Constructor (Spawner)
        public Player(int PlayerNumber)
        {
            WinCounter = 0;
            this.PlayerNumber = PlayerNumber;

        }

        //member Methods (Can Do)
        public string MakeChoice(string ChooseGesture)
        {
            switch (ChooseGesture)
            {
                case "rock":
                    Console.WriteLine("You Chose rock");
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
            Console.ReadLine();
            return " ";
        }
    }
}
