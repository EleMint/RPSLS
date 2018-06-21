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

        //Constructor
        public ScoreBoardMulti()
        {
            this.playerOneScore = 0;
            this.playerTwoScore = 0;
        }

        //Member Methods (CAN DO)
        public void DisplayScore(string playerOne)
        {
            Console.WriteLine(playerOne + ": " + this.playerOneScore + "\r\n" + "Player Two Score: " + playerTwoScore + "\r\n");
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
