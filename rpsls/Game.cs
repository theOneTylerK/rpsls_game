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




        //Construcor (Spawner)
        public Game()
        {
            


        }

        //Member Methods (Can Do)
        //private int GetNumberOfPlayers()
        //{

        //}
        private void EstablishPlayers()
        {
            Console.WriteLine("How many number of players?");
            string NumberOfPlayers = Console.ReadLine().ToLower();

            switch (NumberOfPlayers)
            {
                case "1":
                    PlayerOne = new Human();
                    PlayerTwo = new CPU();
                    PlayerTwo.name = "cpuPlayer";
                    break;
                case "one":
                    PlayerOne = new Human();
                    PlayerTwo = new CPU();
                    PlayerTwo.name = "cpuPlayer";
                    break;
                case "2":
                    PlayerOne = new Human();
                    PlayerTwo = new Human();
                    break;
                case "two":
                    PlayerOne = new Human();
                    PlayerTwo = new Human();
                    break;
                case "banana":
                    Console.WriteLine("No bananas here");
                    EstablishPlayers();
                    break;
                case "flamingo":
                    Console.WriteLine("No flamingos present at this time");
                    EstablishPlayers();
                    break;
                default:
                    Console.WriteLine("Please select an appropriate number of players");
                    EstablishPlayers();
                    break;
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

        private void CompareGestures(string PlayerOneChoice, string PlayerTwoChoice)
        {
            if ((PlayerOneChoice == "rock" && PlayerTwoChoice == "scissors") || (PlayerOneChoice == "rock" && PlayerTwoChoice == "lizard"))
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            else if (PlayerOneChoice == "rock" & PlayerTwoChoice == "paper")
            {
                Console.WriteLine(PlayerTwoChoice + " beats " + PlayerOneChoice + " " + PlayerTwo.name + " wins the round");
                PlayerTwo.WinCounter += 1;
            }
            else if((PlayerOneChoice == "paper" && PlayerTwoChoice == "rock") || (PlayerOneChoice == "paper" && PlayerTwoChoice == "Spock"))
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            else if((PlayerOneChoice == "scissors" && PlayerTwoChoice == "paper") || (PlayerOneChoice == "scissors" && PlayerTwoChoice == "lizard"))
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            else if((PlayerOneChoice == "lizard" && PlayerTwoChoice == "spock") || (PlayerOneChoice == "lizard" && PlayerTwoChoice == "paper"))
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            else if((PlayerOneChoice == "spock" && PlayerTwoChoice == "scissors") || (PlayerTwoChoice == "rock" && PlayerOneChoice =="spock"))
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            else if (PlayerOneChoice == PlayerTwoChoice)
            {
                Console.WriteLine(PlayerOneChoice + " ties " + PlayerTwoChoice + "." + " It's a Draw.");
                PlayerOne.WinCounter += 0;
                PlayerTwo.WinCounter += 0;

            }
            else
            {
                //Console.WriteLine("Not a valid answer.");
                Console.WriteLine(PlayerTwoChoice + " beats " + PlayerOneChoice + " " + PlayerTwo.name + " wins the round");
                PlayerTwo.WinCounter += 1;

            }

        }
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

        public void HideText()
        {
            int ChosenGesture = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write("...", Console.WindowWidth);
            Console.SetCursorPosition(0, ChosenGesture);
        }
        public void StartGame()
        {
            DisplayRules();
            Console.WriteLine("Please enter the length of series you would like to play. Avalable lengths: Do or Die, Best of 3, Best of 5, and Best of 7");
            string SeriesLength = Console.ReadLine().ToLower();
            switch (SeriesLength)
            {
                case "do or die":
                    
                    EstablishPlayers();
                    PlayerOne.ChooseName();
                    PlayerTwo.ChooseName();
                    PlayerOne.WinCounter = 0;
                    PlayerTwo.WinCounter = 0;
                    while (PlayerOne.WinCounter < 1 && PlayerTwo.WinCounter < 1)
                    {
                        Console.WriteLine("The score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                        CompareGestures(PlayerOne.MakeChoice(), PlayerTwo.MakeChoice());
                        if (PlayerOne.WinCounter == 1)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerOne.name + " Wins!");
                            break;
                        }
                        else if (PlayerTwo.WinCounter == 1)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerTwo.name + " Wins!");
                            break;
                        }
                    }
                    RestartGame();
                    break;
                case "best of 3":
                    
                    EstablishPlayers();
                    PlayerOne.ChooseName();
                    PlayerTwo.ChooseName();
                    PlayerOne.WinCounter = 0;
                    PlayerTwo.WinCounter = 0;
                    while (PlayerOne.WinCounter < 2 && PlayerTwo.WinCounter < 2)
                    {
                        Console.WriteLine("The score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                        CompareGestures(PlayerOne.MakeChoice(), PlayerTwo.MakeChoice());
                        if (PlayerOne.WinCounter == 2)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerOne.name + " Wins!");
                            break;
                        }
                        else if (PlayerTwo.WinCounter == 2)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerTwo.name + " Wins!");
                            break;
                        }
                    }
                    RestartGame();
                    break;
                case "best of 5":
                    
                    EstablishPlayers();
                    PlayerOne.ChooseName();
                    PlayerTwo.ChooseName();
                    PlayerOne.WinCounter = 0;
                    PlayerTwo.WinCounter = 0;
                    while (PlayerOne.WinCounter < 3 && PlayerTwo.WinCounter < 3)
                    {
                        Console.WriteLine("The score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                        CompareGestures(PlayerOne.MakeChoice(), PlayerTwo.MakeChoice());
                        if (PlayerOne.WinCounter == 3)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerOne.name + " Wins!");
                            break;
                        }
                        else if (PlayerTwo.WinCounter == 3)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerTwo.name + " Wins!");
                            break;
                        }
                    }
                    RestartGame();
                    break;
                case "best of 7":
                    
                    EstablishPlayers();
                    PlayerOne.ChooseName();
                    PlayerTwo.ChooseName();
                    PlayerOne.WinCounter = 0;
                    PlayerTwo.WinCounter = 0;
                    while (PlayerOne.WinCounter < 4 && PlayerTwo.WinCounter < 4)
                    {
                        Console.WriteLine("The score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                        CompareGestures(PlayerOne.MakeChoice(), PlayerTwo.MakeChoice());
                        if (PlayerOne.WinCounter == 4)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerOne.name + " Wins!");
                            break;
                        }
                        else if (PlayerTwo.WinCounter == 4)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": " + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerTwo.name + " Wins!");
                            break;
                        }
                    }
                    RestartGame();
                    break;
                default:
                    Console.WriteLine("Please enter your choice as you see it listed on the screen");
                    StartGame();
                    break;

            }
            
           
        }
    }
}
