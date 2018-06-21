using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class OnePlayerGame
    {
        //Member Variables (HAS A)
        public string playerName;
        public string playerMove;
        //Constructor
        public OnePlayerGame()
        {
            Console.WriteLine("\r\n" + "This is A One Player Game.");
            Console.WriteLine("\r\n" + "Please Enter Your Name:");
            playerName = Console.ReadLine();
            PlayerOne playerOne = new PlayerOne(playerName);
            ScoreBoardSingle scoreBoard = new ScoreBoardSingle();
            Console.WriteLine("\r\n" + "Hello, " + playerOne.name + "!");
            scoreBoard.DisplayScore(playerOne.name);
            Console.WriteLine("\r\n" + "The Scores Are Set To 0. Let's Begin!");
            playerMove = playerOne.MakeMove();

            
            Console.ReadLine();
        }
        //Member Methods (CAN DO)
    }
}
