using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)// string array 
        {
            Deck deck = new Deck();
            deck = Shuffle(deck); //call the method/Function, shuffling deck and returning value to variable deck

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)  //public makes it accesable everywhere, static so we don't have to create an object, deck type of data returning,//shuffle is name of function
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0 )
            {
                int randomIndex = random.Next(0, deck.Cards.Count); // creates randomIndex to get a card from 0 to the last index
                TempList.Add(deck.Cards[randomIndex]);  //added to temporary list
                deck.Cards.RemoveAt(randomIndex);       // removed it from cards
            }
            deck.Cards = TempList;
            return deck;
        }
    }                               
}

