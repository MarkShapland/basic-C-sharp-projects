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
            Cards = new List<Card>();  // instantiates card as an empty list of Cards, constructor
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

        public void Shuffle(int times = 1)  //public makes it accessable everywhere, static so we don't have to create an object, deck type of data returning,//shuffle is name of function
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count); // creates randomIndex to get a card from 0 to the last index
                    TempList.Add(Cards[randomIndex]);  //added to temporary list
                    Cards.RemoveAt(randomIndex);       // removed it from cards
                }
               this.Cards = TempList;
            }
            
        }
    }
}
