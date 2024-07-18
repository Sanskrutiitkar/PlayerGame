using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerGame
{
    class Player
    {
        private int playerId;
        private string playerName;
        private int playerAge;

        public Player(int id, string name) : this(id, name, 0)
        {
        }
        public Player(int id, string name, int age)
        {
            this.playerId = id;
            this.playerName = name;
            this.playerAge = age;
        }

        public int GetId()
        {
            return playerId;
        }

        public string GetName()
        {
            return playerName;
        }

        public int GetAge()
        {
            return playerAge;
        }
        public static Player WhoIsElder(Player[] players)
        {

            Player elder = players[0];
            for (int i = 1; i < players.Length; i++)
            {
                if (players[i].playerAge > elder.playerAge)
                    elder = players[i];
            }

            return elder;
        }
    }
}
