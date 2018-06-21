using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class TwoPlayerGame
    {
        //Member Variables (HAS A)
        public string playerOneName;
        public string playerTwoName;
        public string playerMove;
        public string computerMove;
        //Constructor
        public TwoPlayerGame()
        {
            Console.WriteLine("\r\n" + "This is A Two Player Game.");
            Console.WriteLine("\r\n" + "Player One, Please Enter Your Name:");
            playerOneName = Console.ReadLine();
            Console.WriteLine("\r\n" + "Player Two, Please Enter Your Name:");
            playerTwoName = Console.ReadLine();
            PlayerOne playerOne = new PlayerOne(playerOneName);
            PlayerTwo playerTwo = new PlayerTwo(playerTwoName);
            ScoreBoardMulti scoreBoard = new ScoreBoardMulti();
            Console.WriteLine("\r\n" + "Hello, " + playerOne.name + "!");
            scoreBoard.DisplayScore(playerOne.name);
            Console.WriteLine("\r\n" + "The Scores Are Set To 0. Let's Begin!");
            do
            {
                playerMove = playerOne.MakeMove();
                computerMove = computer.MakeMove();
                computer.ShowMove(computerMove);
                scoreBoard.DecideRound(playerMove, computerMove);
                scoreBoard.DisplayScore(playerOne.name);
                Console.ReadLine();
            }
            while (scoreBoard.playerScore < 2 && scoreBoard.computerScore < 2);
        }
    }
}
