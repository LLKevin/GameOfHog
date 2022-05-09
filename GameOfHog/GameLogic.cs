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
            int numberOfDiceToRoll = 0;

            Player[] players = new Player[2] { new Player(playerName), new Player("AiBot") };
            Menu menu = new Menu();

            while (!playerWins)
            {
                numberOfDiceToRoll = 0;
                foreach(Player player in players)
                {
                   if(player.GetScore() >= 100)
                    {
                        playerWins = true;
                        Console.WriteLine("{0} has won with a score of {1}", player.GetPlayerName(), player.GetScore());
                       
                    }
                }
                menu.ScoreBoard(players);
                switch (humanPlayerTurn)
                {
                    case true:
                        do
                        {
                            try
                            {
                                Console.WriteLine("Enter the amount of dice you would like to roll between 1 - 10\n");
                                numberOfDiceToRoll = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine("You must enter a number between 1 - 10\n");
                            }
                        }
                        while (numberOfDiceToRoll <= 0 || numberOfDiceToRoll > 10);
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

        public void PlayGameAgainstPlayer(string player1, string player2)
        {
            Player[] players = new Player[2] {new Player(player1),new Player(player2)};
            Dice gameDices = new Dice();

            Console.WriteLine("{0} has won with a score of {1}", players[0].GetPlayerName(), players[0].GetScore()); 
            Console.WriteLine("{0} has won with a score of {1}", players[1].GetPlayerName(), players[1].GetScore());


            bool playerWins = false;
            bool humanPlayerTurn = true;
            int numberOfDiceToRoll = 0;
            while (!playerWins)
            {

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
           
            Console.WriteLine("{0} rolled {1} dice(s) was: {2} with a Score of {3}\n", player.GetPlayerName(),numberOfDice, rollResult, pointCounter);
        }


        public void ScorePoints(Player player, int pointsScored)
        {
            player.UpdateScore(pointsScored);

        }
    }
}
