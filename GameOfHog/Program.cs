using GameOfHog;
using System;

namespace Company.ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLogic newGame = new GameLogic();
            Menu menu = new Menu();
            Dice gameDices = new Dice();

            int selection = 0;
            bool validMenuSelection = false;
            bool isNameValid = false;
            string player1Name = "";
            string player2Name = "";

            while (selection != 4)
            {
                menu.MainMenu();
                validMenuSelection = int.TryParse(Console.ReadLine(), out selection);
                if (validMenuSelection == false)
                {
                    Console.Clear();
                    Console.WriteLine("You must enter a number to select from the menu\n");
                }
                switch (selection)
                {
                    case 1:
                        newGame = new GameLogic();
                        Console.WriteLine("What do you want your player to be named?");
                        do
                        {
                            player1Name = Console.ReadLine();
                            isNameValid = menu.playerNameErrorMenu(player1Name);
                        }
                        while (!isNameValid);
                        newGame.PlayGameAgainstAi(player1Name, gameDices, menu);
                        break;
                    case 2:
                        newGame = new GameLogic();                      
                        Console.WriteLine("What enter the number for the first player?");
                        do
                        {
                           player1Name = Console.ReadLine();
                           isNameValid = menu.playerNameErrorMenu(player1Name);

                        } while (!isNameValid);

                        Console.Clear();
                        Console.WriteLine("What enter the number for the second player?");
                        do
                        {
                          player2Name = Console.ReadLine();
                          isNameValid = menu.playerNameErrorMenu(player2Name);

                        } while (!isNameValid);
                        newGame.PlayGameAgainstPlayer(player1Name, player2Name,gameDices, menu);
                        break;
                    case 3:
                        menu.RuleMenu();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

