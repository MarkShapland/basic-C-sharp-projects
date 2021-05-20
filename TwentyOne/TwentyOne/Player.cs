using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public class Player
    {
        public List<Card> Hand { get; set; } //properties of the class Player
        public int  Balance { get; set; }   
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; } 
        // overloading an operator
        public static Game operator+ (Game game, Player player)// adding a game and a player and returning a game.
        {
            game.Players.Add(player); //takes game and adds player
            return game; // returns game
        }

        public static Game operator- ( Game game, Player player)
        {
            game.Players.Remove(player); // takes game and removes player
            return game; // return game
        }

    }
}
