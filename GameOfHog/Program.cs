using GameOfHog;
using System;

namespace Company.ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            while (selection < 3)
            {

                Console.WriteLine("----Selection----\n Press 1 to start game" +
                    " \n Press 3 to exit ");
                selection = Console.Read(); //TODO validation.
               
            }
        }
    }
}

