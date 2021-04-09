using System;
using System.Threading;
using Technical_Test.Models;
using Technical_Test.Presentation;

namespace Technical_Test.Core
{
    public enum GameChoices
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2,
        Flamethrower = 3
    }
    public class Game
    {
        public Player PrincipalUser, SecendUser;
        public MenuGame Mode { get; set; }
        public string[] acceptedChoices { get; set; }

        public Game(MenuGame mode)
        {
            Mode = mode;
            acceptedChoices = new string[]{ "r", "p", "f", "s"  };
            PrincipalUser = new HumanPlayer("Player_1");
            PrincipalUser.acceptedChoices = acceptedChoices;
        }

        //Start the right game mode
        public void playTheGame()
        {
            switch (Mode)
            {
                case MenuGame.TwoPlayers:
                    SecendUser = new HumanPlayer("Player_2");
                    SecendUser.acceptedChoices = acceptedChoices;
                    startGame();
                    break;
                case MenuGame.Computer:
                    SecendUser = new ComputerPlayer("Computer", false);
                    SecendUser.acceptedChoices = acceptedChoices;
                    startGame();
                    break;
                case MenuGame.Random:
                    SecendUser = new ComputerPlayer("Random",true);
                    SecendUser.acceptedChoices = acceptedChoices;
                    startGame();
                    break;
                case MenuGame.Quit:
                    Console.WriteLine("||                                                                              ||");
                    Console.WriteLine("||                                 Bye !                                        ||");
                    Console.WriteLine("||                                                                              ||");
                    Thread.Sleep(4000);
                    break;
                default:
                    break;
            }
        }

        //Loop rounds until we have a winner
        private void startGame()
        {
            int round = 1;
            while (PrincipalUser.Score < 3 && SecendUser.Score < 3)
            {
                startRound(round);
                round++;
            }
            displayWinner();
        }

        //Dispaly the winner
        private void displayWinner()
        {
            Console.WriteLine(" ===============================================================================");
            if (PrincipalUser.Score > SecendUser.Score)
                Console.WriteLine("                       {0} is the Winner ! ", PrincipalUser.Name);
            else if (PrincipalUser.Score == SecendUser.Score)
                Console.WriteLine("                       Equal ! ", PrincipalUser.Name, PrincipalUser.Score, SecendUser.Name, SecendUser.Score);
            else
                Console.WriteLine("                       {0} is the Winner ! ", SecendUser.Name);
            Console.WriteLine(" ===============================================================================");
        }

        //Start and manage round
        private void startRound(int round)
        {
            var choicePrincipalUser = PrincipalUser.playRound(round);
            Console.WriteLine("{0} choose {1}", PrincipalUser.Name, choicePrincipalUser.ToUpper());
            var choiceSecendUser = SecendUser.playRound(round);
            Console.WriteLine("{0} choose {1}", SecendUser.Name, choiceSecendUser.ToUpper());

            if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Rock] && choiceSecendUser == acceptedChoices[(int)GameChoices.Scissors])
            {
                Console.WriteLine("{0} wins round {1}", PrincipalUser.Name, round);
                PrincipalUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Rock] && choiceSecendUser == acceptedChoices[(int)GameChoices.Paper])
            {
                Console.WriteLine("{0} wins round {1}", SecendUser.Name, round);
                SecendUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Rock] && choiceSecendUser == acceptedChoices[(int)GameChoices.Flamethrower])
            {
                Console.WriteLine("{0} wins round {1}", PrincipalUser.Name, round);
                PrincipalUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Paper] && choiceSecendUser == acceptedChoices[(int)GameChoices.Rock])
            {
                Console.WriteLine("{0} wins round {1}", PrincipalUser.Name, round);
                PrincipalUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Paper] && choiceSecendUser == acceptedChoices[(int)GameChoices.Scissors])
            {
                Console.WriteLine("{0} wins round {1}", SecendUser.Name, round);
                SecendUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Paper] && choiceSecendUser == acceptedChoices[(int)GameChoices.Flamethrower])
            {
                Console.WriteLine("{0} wins round {1}", SecendUser.Name, round);
                SecendUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Scissors] && choiceSecendUser == acceptedChoices[(int)GameChoices.Rock])
            {
                Console.WriteLine("{0} wins round {1}", SecendUser.Name, round);
                SecendUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Scissors] && choiceSecendUser == acceptedChoices[(int)GameChoices.Paper])
            {
                Console.WriteLine("{0} wins round {1}", PrincipalUser.Name, round);
                PrincipalUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Scissors] && choiceSecendUser == acceptedChoices[(int)GameChoices.Flamethrower])
            {
                Console.WriteLine("{0} wins round {1}", PrincipalUser.Name, round);
                PrincipalUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Flamethrower] && choiceSecendUser == acceptedChoices[(int)GameChoices.Rock])
            {
                Console.WriteLine("{0} wins round {1}", SecendUser.Name, round);
                SecendUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Flamethrower] && choiceSecendUser == acceptedChoices[(int)GameChoices.Paper])
            {
                Console.WriteLine("{0} wins round {1}", PrincipalUser.Name, round);
                PrincipalUser.Score += 1;
            }
            else if (choicePrincipalUser == acceptedChoices[(int)GameChoices.Flamethrower] && choiceSecendUser == acceptedChoices[(int)GameChoices.Scissors])
            {
                Console.WriteLine("{0} wins round {1}", SecendUser.Name, round);
                SecendUser.Score += 1;
            }
            else
            {
                Console.WriteLine("Same choices");
            }
            Console.WriteLine("                       {0} : {1} - {2} : {3} ", PrincipalUser.Name, PrincipalUser.Score, SecendUser.Name, SecendUser.Score);
            Console.WriteLine(" ===============================================================================");
        }
    }
}
