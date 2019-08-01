using System;
namespace rpsls
{
    public class Restart
    {
        public Restart()
        {
        }

        //Member Methods (Can Do)
        public void RestartGame()
        {
            Console.WriteLine("Would you like to play again? Yes or No?");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    Console.WriteLine("Thanks for playing. Goodbye.");
                    break;
                default:
                    Console.WriteLine("No bananas or flamingos here.");
                    RestartGame();
                    break;
            }

        }
    }
}
