using PlayerGame;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Player player1 = new Player(1, "Seema", 25);
        //Player player2 = new Player(2, "Rina", 30);
        //Player player3 = new Player(3, "Sham");

        Player[] players = new Player[3]
        { new Player(1, "Seema", 25),
        new Player(2, "Rina", 30),
        new Player(3, "Sham")};

    
        Player elder = Player.WhoIsElder(players);

        
        Console.WriteLine($"Elder player: ID={elder.GetId()}, Name={elder.GetName()}, Age={elder.GetAge()}");
    }
}