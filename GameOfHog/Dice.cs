using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfHog
{
    public class Dice
    { 
       public int roll()
        {

            //TODO: generate a utility class to generate the pseduo-random number without a library
            // randomly will select a number fom 1 to 6
            var rand  = new Random();
            return rand.Next(1, 6); ; 
        }
    }
}
