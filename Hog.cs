using System;

static void Main(string[] args){

    string player1_name = "";
    string player2_name = "";

    //get name input
    Console.WriteLine("Enter a name for player 1");
    player1_name = Console.ReadLine(); //#TODO: need to error check

    Console.WriteLine("Enter a name for player 2");
    player2_name = Console.ReadLine();

    Player player1 = new Player(player1_name, 0);
    Player player2 = new Player(player2_name, 0);
}