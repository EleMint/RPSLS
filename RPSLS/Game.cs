using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Constructor
        public Game()
        {
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Press '1' for Single-Player or '2' for Multi-Player");
            switch (Console.ReadLine())
            {
                case "1":
                    OnePlayerGame onePlayerGame = new OnePlayerGame();
                    break;
                case "2":
                    TwoPlayerGame twoPlayerGame = new TwoPlayerGame();
                    break;
                default:
                    // TODO: Reinitiate Game()
                    break;
            }
        }
    }
}
