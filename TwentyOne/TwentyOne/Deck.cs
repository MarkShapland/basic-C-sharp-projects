using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {  
            Cards = new List<Card>();  // instantiates card as an empty list of Cards
            //creates two lists and instantiates with values
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamond", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); // variable card only exists in each loop
                    card.Suit = suit; //assigns suit property
                    card.Face = face; // assigns face property
                    Cards.Add(card); // adds card to Cards list
                }
            }
            
        }
        public List<Card> Cards { get; set; } 
    }
}
