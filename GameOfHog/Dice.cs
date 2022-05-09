using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    public class Dice
    { 
       public int[] Roll(int numberOfDices)
        {
            // randomly will select a number fom 1 to 6
            // TODO: eventually would like to replace this function with my own implementation of a random number generator.

            int[] diceRolls = new int[numberOfDices];

            for (int i = 0; i < numberOfDices; i++)
            {
                var rand = new Random();
                int diceRoll = rand.Next(1, 6);
                diceRolls[i] = diceRoll;
            }

            return diceRolls;
        }
    }
}
