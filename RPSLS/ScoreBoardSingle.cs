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
        public int playerOneScore;
        public int computerScore;

        //Constructor
        public ScoreBoardSingle()
        {
            this.playerOneScore = 0;
            this.computerScore = 0;
        }

        //Member Methods (CAN DO)
        public void DisplayScore(string playerOne)
        {
            Console.WriteLine("\r\n" + "--Scores--" + "\r\n" + playerOne + ": " + this.playerOneScore + "\r\n" + "Computer: " + computerScore);
        }
        public void AddPointPlayer()
        {
            playerOneScore += 1;
        }

        public void AddPointComputer()
        {
            computerScore += 1;
        }
    }
}
