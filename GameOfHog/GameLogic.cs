using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    internal class GameLogic
    {

        //game rule set 
        // each player 
        public void PlayGameAgainstAi(string playerName)
        { 
            //create a dice for the game.
            //
            Dice gameDices = new Dice();

            bool playerWins = false;
            bool humanPlayerTurn = true;

            Player[] players = new Player[2] { new Player(playerName), new Player("AiBot") };

            while (!playerWins)
            {
                foreach(Player player in players)
                {
                   if(player.GetScore() >= 100)
                    {
                        playerWins = true;
                        Console.WriteLine("{0} has won with a score of {1}", player.GetPlayerName(), player.GetScore());
                       
                    }
                    else
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("{0} Score is: {1}", player.GetPlayerName(), player.GetScore());
                        Console.WriteLine("--------------------------------\n");
                    }
                }
                switch (humanPlayerTurn)
                {
                    case true:
                        //player

                        Console.WriteLine("Enter the amount of dice you would like to roll between 1 - 10\n");
                       int numberOfDiceToRoll = int.Parse(Console.ReadLine());
                        //TODO: Validation --- possible create a utility class to deal with validation of input. --- minimum is 1 dice  &  maximum is 10 dice 
                        Turn(gameDices, numberOfDiceToRoll,players[0]);
                        // score points

                      
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
        //1. check if any of the dice(s) have rolled a 1
        //1.1 if so, the player scores only 1 point  --- Sow Sad
        //1.2 else, the player scores the sum of the roll dices
        //2. The player that gets to at least 100 points first, wins. 

        //Stretch goal : To allow the player to customized rule sets


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
           
            Console.WriteLine("{0} rolled was: {1} with a Score of {2}\n", player.GetPlayerName(), rollResult, pointCounter);
        }


        public void ScorePoints(Player player, int pointsScored)
        {
            player.UpdateScore(pointsScored);

        }
    }
}
