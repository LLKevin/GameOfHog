using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    internal class Player
    {
        internal string Name { get; set; }
        internal int Score { get; set; }

        Player(string name)
        {
            Name = name;
            Score = 0;
        }

       void updateScore(int score)
        {
            Score = score;      
        }

    }
}
