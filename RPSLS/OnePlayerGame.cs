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

        //Constructor
        public OnePlayerGame()
        {
            Console.WriteLine("One Player Game");
            Console.WriteLine("Please Enter Your Name:");
            PlayerOne playerOne = new PlayerOne(Console.ReadLine());
            Console.WriteLine("Hello, " + playerOne.name + "!");
            Console.ReadLine();
        }
        //Member Methods (CAN DO)
    }
}
