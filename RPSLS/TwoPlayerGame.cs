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
        public string playerOneMove;
        public string playerTwoMove;
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
            scoreBoard.DisplayScore(playerOne.name, playerTwo.name);
            Console.WriteLine("\r\n" + "The Scores Are Set To 0. Let's Begin!");
            do
            {
                Console.WriteLine("\r\n" + playerOne.name + ", It's Your Move");
                playerOneMove = playerOne.MakeMove();
                Console.Clear();
                Console.WriteLine("\r\n" + playerTwo.name + ", It's Your Move");
                playerTwoMove = playerTwo.MakeMove();
                Console.Clear();
                scoreBoard.ShowMoves(playerOneMove, playerTwoMove, playerOne.name, playerTwo.name);
                scoreBoard.DecideRound(playerOneMove, playerTwoMove);
                scoreBoard.DisplayScore(playerOne.name, playerTwo.name);
                Console.ReadLine();
            }
            while (scoreBoard.playerOneScore < 2 && scoreBoard.playerTwoScore < 2);
        }
    }
}
