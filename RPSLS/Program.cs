using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Would You Like To Play Again?");
            switch(Console.ReadLine().ToLower())
            {
                case "yes":
                    // TODO: Restart Game
                    break;
                case "no":
                    Console.WriteLine("\r\n" + "Thanks For Playing!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
