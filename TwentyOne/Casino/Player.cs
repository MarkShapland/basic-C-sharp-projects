using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
     public class Player
    {
        public Player(string name) : this(name, 100) //assign name to name and provide beginning balance
        {
        }
        public Player(string name, int beginningBalance) //constructor with two parameters name ,beginningBalance
        {
            Hand = new List<Card>(); // initialize list
            Balance = beginningBalance; //initiliaze the object
            Name = name;
        }
        // Properties in the class 
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } //properties of the class Player
        public int  Balance { get; set; }    
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; } 
        public bool Stay { get; set; }
        public Guid Id { get; set; }
        public bool Bet(int amount)//ask for player amount
        {
            if (Balance - amount < 0) //player balance is checked 
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator+ (Game game, Player player)//overloading the operator, game is the return type
        {
            game.Players.Add(player); //takes game and adds player-polymorphism
            return game; // returns game
        }

        public static Game operator- ( Game game, Player player) //overloading operator
        {
            game.Players.Remove(player); // takes game and removes player
            return game; // return game
        }

    }
}
