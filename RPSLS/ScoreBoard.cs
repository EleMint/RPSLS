using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ScoreBoard
    {
        //Member Variables (HAS A)
        public int playerOneScore;
        public int playerTwoScore;

        //Constructor
        public ScoreBoard()
        {
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
        }

        //Member Methods (CAN DO)
        public void DisplayScore()
        {
            Console.WriteLine("Player One Score: " + this.playerOneScore + "\r\n" + "Player Two Score: " + playerTwoScore + "\r\n");
        }
        public void AddPlayerOnePoint()
        {
            playerOneScore += 1;
        }

        public void AddPlayerTwoPoint()
        {
            playerTwoScore += 1;
        }
    }
}
