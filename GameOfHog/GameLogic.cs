using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    public class GameLogic
    {
        public void PlayGameAgainstAi(string playerName, Dice gameDices, Menu menu)
        { 
            bool playerWins = false;
            bool humanPlayerTurn = true;
            int numberOfDiceToRoll = 0;

            Player[] players = new Player[2] { new Player(playerName), new Player("AiBot") };
            while (!playerWins)
            {
                playerWins = WinCheck(players);
                menu.ScoreBoard(players);
                switch (humanPlayerTurn)
                {
                    case true:
                        numberOfDiceToRoll = DiceRoll(players[0].GetPlayerName(),menu);
                        Turn(gameDices, numberOfDiceToRoll,players[0]);
                        humanPlayerTurn = false;
                        break;
                    case false:

                        //ai 
                        var randomDiceSelector = new Random();
                        Turn(gameDices, randomDiceSelector.Next(1,10), players[1]);
                        humanPlayerTurn = true;
                        break;
                }
            }
        }

        public void PlayGameAgainstPlayer(string player1, string player2, Dice gameDices, Menu menu)
        {

            Player[] players = new Player[2] {new Player(player1),new Player(player2)};

            bool playerWins = false;
            bool playerTurn = true;
            int numberOfDiceToRoll = 0;
            while (!playerWins)
            {
                playerWins = WinCheck(players);
                menu.ScoreBoard(players);
                switch (playerTurn)
                {
                    case true:
                        numberOfDiceToRoll = DiceRoll(players[0].GetPlayerName(), menu);
                        Turn(gameDices, numberOfDiceToRoll, players[0]);
                        playerTurn = !playerTurn;
                        break;
                    case false:
                        numberOfDiceToRoll = DiceRoll(players[1].GetPlayerName(), menu);
                        Turn(gameDices, numberOfDiceToRoll, players[1]);
                        playerTurn = !playerTurn;
                        break;
                }
            }
        }
        public bool WinCheck(Player [] players)
        {
            bool playerWins = false;
            foreach (Player player in players)
            {
                if (player.GetScore() >= 100)
                {
                    playerWins = true;
                    Console.Clear();
                    Console.WriteLine("{0} has won with a score of {1}", player.GetPlayerName(), player.GetScore());
                    Console.WriteLine("Press any key to Continue...");
                    Console.ReadKey();
                }
            }
            return playerWins;
        }
        public int DiceRoll(string playerName, Menu menu)
        {
            int numberOfDiceToRoll = 0;
            do
            {
                try
                {
                    menu.DiceRollMenu(playerName);
                    numberOfDiceToRoll = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You must enter a number between 1 - 10");
                }
            }
            while (numberOfDiceToRoll <= 0 || numberOfDiceToRoll > 10);
            return numberOfDiceToRoll;
        }
        public void Turn(Dice dice, int numberOfDice, Player player)
        {
           StringBuilder rollResult = new StringBuilder();
           int[] rolls =  dice.Roll(numberOfDice);
           int pointCounter = 0;

            // display what was rolled
            foreach(int roll in rolls)
            {
                rollResult.Append(" " + roll + " ");
                pointCounter += roll;
            }

            if (rolls.Contains<int>(1))
            {
                ScorePoints(player, 1);
                pointCounter = 1;
            }
            else
            {
                ScorePoints(player,pointCounter);
            }
           
            Console.WriteLine("{0} rolled {1} dice(s) was: {2} with a Score of {3}\n", player.GetPlayerName(),numberOfDice, rollResult, pointCounter);
        }
        public void ScorePoints(Player player, int pointsScored)
        {
            player.UpdateScore(pointsScored);

        }
    }
}
