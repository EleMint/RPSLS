using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ScoreBoardMulti
    {
        //Member Variables (HAS A)
        public int playerOneScore;
        public int playerTwoScore;
        public string roundWinner;

        //Constructor
        public ScoreBoardMulti()
        {
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
        }

        //Member Methods (CAN DO)

        public void DisplayScore(string playerOne, string playerTwo)
        {
            Console.WriteLine("\r\n" + "--Scores--" + "\r\n" + playerOne + ": " + this.playerOneScore + "\r\n" + "Computer: " + playerTwoScore);
            if (playerOneScore == 2)
            {
                this.DisplayWinner("\r\n" + playerOne + "Is The Winner!");
            }
            else if (playerTwoScore == 2)
            {
                this.DisplayWinner("\r\n" + playerTwo + "Is The Winner!");
            }
        }

        public void DecideRound(string playerOneMove, string playerTwoMove)
        {
            switch (playerOneMove)
            {
                case "rock":
                    switch (playerTwoMove)
                    {
                        case "rock":
                            roundWinner = null;
                            break;
                        case "paper":
                            roundWinner = "playerTwo";
                            break;
                        case "scissors":
                            roundWinner = "playerOne";
                            break;
                        case "lizard":
                            roundWinner = "playerOne";
                            break;
                        case "spock":
                            roundWinner = "playerTwo";
                            break;
                    }
                    break;
                case "paper":
                    switch (playerTwoMove)
                    {
                        case "rock":
                            roundWinner = "playerOne";
                            break;
                        case "paper":
                            roundWinner = null;
                            break;
                        case "scissors":
                            roundWinner = "playerTwo";
                            break;
                        case "lizard":
                            roundWinner = "playerTwo";
                            break;
                        case "spock":
                            roundWinner = "playerOne";
                            break;
                    }
                    break;
                case "scissors":
                    switch (playerTwoMove)
                    {
                        case "rock":
                            roundWinner = "playerTwo";
                            break;
                        case "paper":
                            roundWinner = "playerOne";
                            break;
                        case "scissors":
                            roundWinner = null;
                            break;
                        case "lizard":
                            roundWinner = "playerOne";
                            break;
                        case "spock":
                            roundWinner = "playerTwo";
                            break;
                    }
                    break;
                case "lizard":
                    switch (playerTwoMove)
                    {
                        case "rock":
                            roundWinner = "playerTwo";
                            break;
                        case "paper":
                            roundWinner = "playerOne";
                            break;
                        case "scissors":
                            roundWinner = "playerTwo";
                            break;
                        case "lizard":
                            roundWinner = null;
                            break;
                        case "spock":
                            roundWinner = "playerOne";
                            break;
                    }
                    break;
                case "spock":
                    switch (playerTwoMove)
                    {
                        case "rock":
                            roundWinner = "playerOne";
                            break;
                        case "paper":
                            roundWinner = "playerTwo";
                            break;
                        case "scissors":
                            roundWinner = "playerOne";
                            break;
                        case "lizard":
                            roundWinner = "playerTwo";
                            break;
                        case "spock":
                            roundWinner = null;
                            break;
                    }
                    break;
            }

            if (roundWinner == "playerOne")
            {
                this.AddPointPlayerOne();
            }
            else if (roundWinner == "playerTwo")
            {
                this.AddPointPlayerTwo();
            }
            else
            {
                Console.WriteLine("\r\n" + "The Round Ended In A Tie");
            }
        }

        public void AddPointPlayerOne()
        {
            playerOneScore += 1;
        }

        public void AddPointPlayerTwo()
        {
            playerTwoScore += 1;
        }

        public void DisplayWinner(string winner)
        {
            if (winner == "playerOne")
            {
                Console.WriteLine("\r\n" + "Congratulations, " + PlayerOne + ", You've Beat The Computer!");
            }
            else
            {
                Console.WriteLine("\r\n" + "Congratulations, " + PlayerTwo + ", You've Beat The Computer!");
            }
        }
    }
}
