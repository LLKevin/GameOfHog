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

            /**
             * While the no player has a score of >= 100
             * Continue to swap player (Take turns) 
             * 
             * **/
            while (!playerWins)
            {
                foreach(Player player in players)
                {
                   if(CheckScore(player) == 100)
                    {
                        playerWins = true;
                    }
                }

                // take a turn
                switch (humanPlayerTurn)
                {
                    case true:
                        //player
                        int pointsScored = 0;

                        Console.WriteLine("Enter the amount of dice you would like to roll between 1 - 10");
                       int numberOfDiceToRoll = int.Parse(Console.ReadLine());//TODO: Validation --- possible create a utility class to deal with validation of input. --- minimum is 1 dice  &  maximum is 10 dice 
                        Turn(gameDices, numberOfDiceToRoll,players[0].GetPlayerName());
                        // score points

                        //update player score
                        ScorePoints(players[0], pointsScored);
                        humanPlayerTurn = false;
                        break;
                    case false:

                        //ai 
                         pointsScored = 0;
                        var randomDiceSelector = new Random();
                        Turn(gameDices, randomDiceSelector.Next(1,10), players[1].GetPlayerName());
                        

                        //update player score
                        ScorePoints(players[1], pointsScored);
                        humanPlayerTurn = true;
                        break;
                }

            }
         

            // Display the winner with both player's score 

        }


        public void Turn(Dice dice, int numberOfDice, string playerName)
        {
            StringBuilder rollResult = new StringBuilder();
           int[] rolls =  dice.Roll(numberOfDice);



            //1. check if any of the dice(s) have rolled a 1
                //1.1 if so, the player scores only 1 point  --- Sow Sad
                //1.2 else, the player scores the sum of the roll dices
            //2. The player that gets to at least 100 points first, wins. 

            //Stretch goal : To allow the player to customized rule sets
            

            // display what was rolled
            foreach(int roll in rolls)
            {
                rollResult.Append(" " + roll + " ");
            }

            Console.WriteLine("{0} rolled was: {1}", playerName, rollResult);
        }


        public void ScorePoints(Player player, int pointsScored)
        {
        }
        public int CheckScore(Player player)
        {
            return 0;
        }
    }
}
