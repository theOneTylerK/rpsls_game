using System;
namespace rpsls
{
    public class GameFactory
    {
        public GameFactory()
        {
        }

        //Member Methods (Can Do)
        public Game SelectGameMode()
        {
            Console.WriteLine("Choose a game mode" + Environment.NewLine +
                         "For Rock, Paper, Scissors, Lizard, Spock press 1" + Environment.NewLine +
                         "For Rock, Paper, Scissors press 2");
            string UserChoice = Console.ReadLine().ToLower();
            Game game;
            switch (UserChoice)
            {
                case "1":
                case "one":
                    game = new GameRPSLS();
                   
                    break;
                case "2":
                case "two":
                    game = new GameRPS();
                
                    break;
                case "flamingo":
                    Console.WriteLine("These aren't the flamingos you're looking for.");
                    game = SelectGameMode();
                    break;
                case "banana":
                    Console.WriteLine("These aren't the bananas you're looking for.");
                    game = SelectGameMode();
                    break;
                default:
                    Console.WriteLine("Please select an option from the list");
                    game = SelectGameMode();
                    break;
            }
            return game;

        }
    }
}