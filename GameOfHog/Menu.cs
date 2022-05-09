using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    public class Menu
    {

       public void MainMenu()
        {
            Console.WriteLine("----------------------Main Menu------------------------");
            Console.WriteLine("Press 1 to play game aganist ai");
            Console.WriteLine("Press 2 to play game aganist human");
            Console.WriteLine("Press 3 to display the rules of the game");
            Console.WriteLine("Press 4 to exit the game");
        }

        public bool playerNameErrorMenu(string playerName)
        {
            if (string.IsNullOrEmpty(playerName))
            {
                Console.Clear();
                Console.WriteLine("You must enter a name");
                Console.WriteLine("What is the name for this player?");
                return false;
            }
            return true;
        }
    }
}
