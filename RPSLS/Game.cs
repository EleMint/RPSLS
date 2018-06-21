using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member Variables (HAS A)

        //Constructor
        public Game()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Press '1' for Two-Player or '2' for Single-Player");
            switch (Console.ReadLine())
            {
                case "2":
                    OnePlayerGame onePlayerGame = new OnePlayerGame();
                    break;
                case "1":
                    TwoPlayerGame twoPlayerGame = new TwoPlayerGame();
                    break;
            }
        }

        //Member Method (CAN DO)
        
    }
}
