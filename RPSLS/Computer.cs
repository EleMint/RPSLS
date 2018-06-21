using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer
    {
        // Member Variables (HAS A)
        
        // Constructor
        public Computer()
        {

        }
        // Member Variables
        public string MakeMove()
        {
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 5);
            switch(randomNumber)
            {
                case 1:
                    return "rock";
                case 2:
                    return "paper";
                case 3:
                    return "scissors";
                case 4:
                    return "lizard";
                case 5:
                    return "spock";
                default:
                    return "null";
            }
        }

        public void ShowMove(string computerMove)
        {
            Console.WriteLine("\r\n" + "The Computer Decided:" + "\r\n" + computerMove);
        }
    }
}
