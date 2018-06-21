using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Players
    {
        // Member Variables (HAS A)
        public string name;
        public string move;
        // Constructor
        public Players()
        {

        }
        // Member Methods (CAN DO)
        
        public string MakeMove()
        {
            Console.WriteLine("\r\n" + "Please Pick A Weapon. (Rock, Paper, Scissors, Lizard, Spock");
            move = Console.ReadLine().ToLower();
            if(move == "rock" || move == "paper" || move == "scissors" || move == "lizard" || move == "spock")
            {
                return move;
            }
            else
            {
                return "null";
            }
        }
    }
}
