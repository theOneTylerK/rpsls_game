using System;
using System.Collections.Generic;

namespace rpsls
{
    public class Game
    {
        //Member Variables (Has A)
        public bool isRunning;
        public string Rules;
        public Player PlayerOne;
        public Player PlayerTwo;
        List<string> AvailableGestures = new List<string>();




        //Construcor (Spawner)
        public Game()
        {

            AvailableGestures.Add("rock");
            AvailableGestures.Add("paper");
            AvailableGestures.Add("scissors");
            AvailableGestures.Add("lizard");
            AvailableGestures.Add("spock");

        }

        //Member Methods (Can Do)
        private int GetNumberOfPlayers()
        {
            Console.WriteLine("How many number of players?");
            int NumberOfPlayers = int.Parse(Console.ReadLine());
            return NumberOfPlayers;
        }
        private void EstablishPlayers(int NumberOfPlayers)
        {
            if(NumberOfPlayers == 1)
            {
                PlayerOne = new Human();
                PlayerTwo = new CPU();
            }
            else
            {
                PlayerOne = new Human();
                PlayerTwo = new Human();
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! The rules of the game are as follows: " +
                "Just like the classic game Rock, Paper, Scissors each player will decide which gesture they want to play. " +
                "The gestures will be compared and the player whose gesture beats the other player's gesture will win the round. " +
                "Best of 3 will win the game. " +
                "Gesture rules are as follows: " +
                "Rock > Scissors, " +
                "Rock > Lizard, " +
                "Paper > Rock, " +
                "Paper > Spock, " +
                "Scissors > Paper, " +
                "Scissors > Lizard, " +
                "Lizard > Spock, " +
                "Lizard > Paper, " +
                "Spock > Scissors, " +
                "Spock > Rock.");
        }
        public void StartGame()
        {
            DisplayRules();
            GetNumberOfPlayers();
            EstablishPlayers(GetNumberOfPlayers());
            PlayerOne.ChooseName();
            PlayerTwo.ChooseName();
        while(PlayerOne.WinCounter > 2 && PlayerTwo.WinCounter > 2)
            {
                PlayerOne.MakeChoice();
                PlayerTwo.MakeChoice();
                if(PlayerOne.WinCounter == 2)
                {
                    Console.WriteLine(PlayerOne.name + "Wins!");
                    break;
                }
                else if (PlayerTwo.WinCounter == 2)
                {
                    Console.WriteLine(PlayerTwo.name + "Wins!");
                    break;
                }
            }

        }
    }
}
