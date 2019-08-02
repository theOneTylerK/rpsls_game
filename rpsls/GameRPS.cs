using System;
namespace rpsls
{
    public class GameRPS : Game
    {
        //Member Variables (Has A)
        public bool isRunning;
        public string Rules;
        public Player PlayerOne;
        public Player PlayerTwo;




        //Construcor (Spawner)
        public GameRPS()
        {



        }

        
        public override void EstablishPlayers()
        {
            Console.WriteLine("How many number of players?");
            string NumberOfPlayers = Console.ReadLine().ToLower();

            switch (NumberOfPlayers)
            {
                case "1":
                case "one":
                    PlayerOne = new HumanRPS();
                    PlayerTwo = new CpuRPS();
                    PlayerTwo.name = "cpuPlayer";
                    break;
                case "2":
                case "two":
                    PlayerOne = new HumanRPS();
                    PlayerTwo = new HumanRPS();
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

        public override void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!" + Environment.NewLine +
                "The rules of the game are as follows: " + Environment.NewLine +
                "Each player will decide which gesture they want to play. " + Environment.NewLine +
                "The gestures will be compared and the player whose gesture beats" + Environment.NewLine +
                "the other player's gesture will win the round. " +
                Environment.NewLine +
                "Gesture rules are as follows: " +
                Environment.NewLine +
                "Rock beats Scissors, " +
                Environment.NewLine +
                "Scissors beats Paper" +
                Environment.NewLine +
                "Paper beats Rock");
        }

        public override void CompareGestures(string PlayerOneChoice, string PlayerTwoChoice)
        {
            if (PlayerOneChoice == "rock" && PlayerTwoChoice == "scissors")
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            //else if (PlayerOneChoice == "rock" & PlayerTwoChoice == "paper")
            //{
            //    Console.WriteLine(PlayerTwoChoice + " beats " + PlayerOneChoice + " " + PlayerTwo.name + " wins the round");
            //    PlayerTwo.WinCounter += 1;
            //}
            else if (PlayerOneChoice == "paper" && PlayerTwoChoice == "rock")
            {
                Console.WriteLine(PlayerOneChoice + " beats " + PlayerTwoChoice + " " + PlayerOne.name + " wins the round");
                PlayerOne.WinCounter += 1;
            }
            else if (PlayerOneChoice == "scissors" && PlayerTwoChoice == "paper")
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
        public override void RestartGame()
        {
            Console.WriteLine("To play again type 'yes', to quit type 'no', or type 'exit' to choose a new game mode.");
            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "yes":
                    StartGame();
                    break;
                case "no":
                    Console.WriteLine("Thanks for playing. Goodbye.");
                    break;
                case "exit":
                    GameFactory factory = new GameFactory();
                    Game game = factory.SelectGameMode();
                    game.StartGame();
                    break;

                default:
                    Console.WriteLine("No bananas or flamingos here.");
                    RestartGame();
                    break;
            }
        }

       

        public override void TryAgain()
        {
            Console.WriteLine("Please enter the length of series you would like to play." + Environment.NewLine +
               "Avalable lengths:" + Environment.NewLine +
               "Do or Die" + Environment.NewLine +
               "Best of 3" + Environment.NewLine +
               "Best of 5" + Environment.NewLine +
               "Best of 7");
            string SeriesLength = Console.ReadLine().ToLower();
            switch (SeriesLength)
            {
                case "do or die":
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
                case "3":
                case "three":
                case "best of three":
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
                case "5":
                case "five":
                case "best of five":
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
                case "7":
                case "seven":
                case "best of seven":
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
                    TryAgain();
                    break;

            }


        }

        public override void StartGame()
        {
            //Console.WriteLine(" " + Environment.NewLine);
            DisplayRules();
            EstablishPlayers();
            PlayerOne.ChooseName();
            PlayerTwo.ChooseName();
            Console.WriteLine("Please enter the length of series you would like to play." + Environment.NewLine +
                "Avalable lengths:" + Environment.NewLine +
                "Do or Die" + Environment.NewLine +
                "Best of 3" + Environment.NewLine +
                "Best of 5" + Environment.NewLine +
                "Best of 7");
            string SeriesLength = Console.ReadLine().ToLower();
            switch (SeriesLength)
            {
                case "do or die":
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
                case "3":
                case "three":   
                case "best of three":
                    PlayerOne.WinCounter = 0;
                    PlayerTwo.WinCounter = 0;
                    while (PlayerOne.WinCounter < 2 && PlayerTwo.WinCounter < 2)
                    {
                        Console.WriteLine("The score is " + PlayerOne.name + ": "
                            + PlayerOne.WinCounter + " "
                            + PlayerTwo.name + ": "
                            + PlayerTwo.WinCounter);

                        CompareGestures(PlayerOne.MakeChoice(), PlayerTwo.MakeChoice());
                        if (PlayerOne.WinCounter == 2)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": "
                                + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerOne.name + " Wins!");
                            break;
                        }
                        else if (PlayerTwo.WinCounter == 2)
                        {
                            Console.WriteLine("The Final Score is " + PlayerOne.name + ": "
                                + PlayerOne.WinCounter + " " + PlayerTwo.name + ": " + PlayerTwo.WinCounter);
                            Console.WriteLine(PlayerTwo.name + " Wins!");
                            break;
                        }
                    }

                    RestartGame();
                    break;

                case "best of 5":
                case "5":
                case "best of five":   
                case "five":
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
                case "7":
                case "seven":
                case "best of seven":
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
                    TryAgain();
                    break;

            }


        }
    }
}
