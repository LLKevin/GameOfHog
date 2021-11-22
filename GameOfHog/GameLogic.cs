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



            // Display the winner with both player's score 

        }


    }
}
