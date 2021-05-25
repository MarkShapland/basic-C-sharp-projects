using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() // constructor has the default values
        {  
            Cards = new List<Card>();  // instantiates card as an empty list of Cards, constructor
                                        //creates two lists and instantiates with values
          for (int i = 0; i<13; i++)
            {
                for(int j = 0; j< 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //casting to face 
                    card.Suit = (Suit)j; //casting to suit
                    Cards.Add(card); //add new card to Cards list
                }
            }
            
        }
        public List<Card> Cards { get; set; } //class with data type card with property get set

        public void Shuffle(int times = 1)  //shuffle Method now belongs to the object created above
        {                                      //Deck is no longer needed because it is doing everything internally
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count); // creates randomIndex to get a card from 0 to 52
                    TempList.Add(Cards[randomIndex]);  //added to temporary list
                    Cards.RemoveAt(randomIndex);      //delete cards from the list of cards until there is no cards list
                }
               this.Cards = TempList; //"this" is referring to itself, it's own object
            }
            
        }
    }
   
}
