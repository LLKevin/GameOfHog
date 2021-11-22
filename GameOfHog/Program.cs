using GameOfHog;
using System;

namespace Company.ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            while (selection < 3)
            {

                Console.WriteLine("----Selection----\n" +
                    " Press 1 to play game aganist ai \n" +
                    " Press 2 to play game aganist human \n" +
                    " Press 3 to exit the game\n");
                selection = int.Parse(Console.ReadLine()); //TODO validation &&  Gui with a library

                switch (selection)
                {
                    case 1:
                        GameLogic newGame = new GameLogic();

                        // ass for a player name
                        Console.WriteLine("What do you want your player to be named?\n");
                        string playerName = Console.ReadLine();
                        newGame.PlayGameAgainstAi(playerName);
                        break;
                }

                //Todo: separate the menus into their own class.
            }
        }
    }
}

