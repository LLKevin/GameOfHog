using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    public class Player
    {
        private string name { get; set; }
        private int score { get; set; }

        public Player(string name)
        {
            this.name = name;
            score = 0;
        }

        public string GetPlayerName()
        {
            return name; 
        }

        public int GetScore()
        {
            return score;
        }
       public void UpdateScore(int score)
        {
            this.score += score;      
        }

    }
}
