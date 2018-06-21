using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ScoreBoardSingle
    {
        //Member Variables (HAS A)
        public int playerScore;
        public int computerScore;
        public string roundWinner;

        //Constructor
        public ScoreBoardSingle()
        {
            this.playerScore = 0;
            this.computerScore = 0;
        }

        //Member Methods (CAN DO)

        public void DisplayScore(string playerOne)
        {
            Console.WriteLine("\r\n" + "--Scores--" + "\r\n" + playerOne + ": " + this.playerScore + "\r\n" + "Computer: " + computerScore);
            if (computerScore == 2)
            {
                this.DisplayWinner("computer");
            }
            else if(playerScore == 2)
            {
                this.DisplayWinner("player");
            }
        }

        public void DecideRound(string playerMove, string computerMove)
        {
            switch(playerMove)
            {
                case "rock":
                    switch(computerMove)
                    {
                        case "rock":
                            roundWinner = null;
                            break;
                        case "paper":
                            roundWinner = "computer";
                            break;
                        case "scissors":
                            roundWinner = "player";
                            break;
                        case "lizard":
                            roundWinner = "player";
                            break;
                        case "spock":
                            roundWinner = "computer";
                            break;
                    }
                    break;
                case "paper":
                    switch (computerMove)
                    {
                        case "rock":
                            roundWinner = "player";
                            break;
                        case "paper":
                            roundWinner = null;
                            break;
                        case "scissors":
                            roundWinner = "computer";
                            break;
                        case "lizard":
                            roundWinner = "computer";
                            break;
                        case "spock":
                            roundWinner = "player";
                            break;
                    }
                    break;
                case "scissors":
                    switch (computerMove)
                    {
                        case "rock":
                            roundWinner = "computer";
                            break;
                        case "paper":
                            roundWinner = "player";
                            break;
                        case "scissors":
                            roundWinner = null;
                            break;
                        case "lizard":
                            roundWinner = "player";
                            break;
                        case "spock":
                            roundWinner = "computer";
                            break;
                    }
                    break;
                case "lizard":
                    switch (computerMove)
                    {
                        case "rock":
                            roundWinner = "computer";
                            break;
                        case "paper":
                            roundWinner = "player";
                            break;
                        case "scissors":
                            roundWinner = "computer";
                            break;
                        case "lizard":
                            roundWinner = null;
                            break;
                        case "spock":
                            roundWinner = "player";
                            break;
                    }
                    break;
                case "spock":
                    switch (computerMove)
                    {
                        case "rock":
                            roundWinner = "player";
                            break;
                        case "paper":
                            roundWinner = "computer";
                            break;
                        case "scissors":
                            roundWinner = "player";
                            break;
                        case "lizard":
                            roundWinner = "computer";
                            break;
                        case "spock":
                            roundWinner = null;
                            break;
                    }
                    break;
            }

            if(roundWinner == "player")
            {
                this.AddPointPlayer();
            }
            else if(roundWinner == "computer")
            {
                this.AddPointComputer();
            }
            else
            {
                Console.WriteLine("\r\n" + "The Round Ended In A Tie");
            }
        }

        public void AddPointPlayer()
        {
            playerScore += 1;
        }

        public void AddPointComputer()
        {
            computerScore += 1;            
        }

        public void DisplayWinner(string winner)
        {
            if(winner == "player")
            {
                Console.WriteLine("\r\n" + "Congratulations, You've Beat The Computer!");
            }
            else
            {
                Console.WriteLine("\r\n" + "You've Lost To The Computer.");
            }
        }
    }
}
