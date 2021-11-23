using GameOfHog;
using System;

namespace Company.ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            string playerName = "";
            bool validMenuSelection = false;

            while (selection != 3)
            {

                Console.WriteLine("----Selection----\n" +
                    " Press 1 to play game aganist ai \n" +
                    " Press 2 to play game aganist human \n" +
                    " Press 3 to exit the game\n");

                  validMenuSelection = int.TryParse(Console.ReadLine(), out selection);

                if (validMenuSelection == false)
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a number to select from the menu\n");
                }

                switch (selection)
                {
                    case 1:
                        GameLogic newGame = new GameLogic();

                        // ask for a player name
                        Console.WriteLine("What do you want your player to be named?\n");
                        playerName = Console.ReadLine();

                        while (string.IsNullOrEmpty(playerName)) {
                            Console.Clear();
                            Console.WriteLine("You must enter a name\n");
                            Console.WriteLine("What do you want your player to be named?\n");
                            playerName = Console.ReadLine();
                        }


                        newGame.PlayGameAgainstAi(playerName);
                        break;
                }

                //Todo: separate the menus into their own class.
            }
        }
    }
}

