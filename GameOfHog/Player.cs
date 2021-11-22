using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    public class Player
    {
        private string Name { get; set; }
        private int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }


        public string GetPlayerName()
        {
            return Name; 
        }

        public int GetScore(Player player)
        {
            return player.Score;
        }
       public void UpdateScore(int score)
        {
            Score += score;      
        }

    }
}
