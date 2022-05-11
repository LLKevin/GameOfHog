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
            Console.Clear();
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
        public void RuleMenu()
        {
            Console.Clear();
            Console.WriteLine("In Hog, two players alternate turns trying to be the first to end a turn with at least 100 points.");
            Console.WriteLine("On each turn, the current player can select a number of dice to roll, up to 10.");
            Console.WriteLine("The player's score is the sum of the dice outcome.However, the dices rolled risks:");
            Console.WriteLine("\t\t --Pig out: if any of the dice outcomes is a 1, the current player's score for the turn is 1");
        }
        public void ScoreBoard(Player[] players)
        {
            Console.WriteLine("--------------Scoreboard------------------\n");
            Console.WriteLine("Player's Name\t\tScore");
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("{0}\t\t\t{1}", players[0].GetPlayerName(), players[0].GetScore()); 
            Console.WriteLine("{0}\t\t\t{1}", players[1].GetPlayerName(), players[1].GetScore());
            Console.WriteLine("");
        }
        public void DiceRollMenu(string playerName)
        {
            Console.WriteLine("{0}'s turn", playerName);
            Console.WriteLine("Enter the amount of dice you would like to roll between 1 - 10");
        }
    }
}
