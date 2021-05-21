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
            //Deck deck = new Deck();

            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();




            ////List<Card> newlist = deck.Cards.Where(x => x.Face == Face.King).ToList();

            ////int count = deck.Cards.Count(x => x.Face == Face.Ace);//cards is a list and Count is a Lamda function

            //List<int> numberlist = new List<int>() { 1, 2, 3, 535, 45, 90 };
            //int sum = numberlist.Where(x => x > 20).Sum(); 
            //Console.WriteLine(sum);


            //int counter = 0; //counts all the Ace Face card in deck
            //foreach (Card card in deck.Cards)
            //{
            //    if (card.Face == Face.Ace) //nested 
            //    {
            //        counter++;
            //    }
            //}
            //foreach (Card card in newlist)
            //{
            //    Console.WriteLine(card.Face);
            //}





        }



        //Game game = new TwentyOneGame(); //polymorphism
        //game.Players = new List<Player>(); //instantiated list  
        //Player player = new Player();
        //player.Name = "Jesse";
        //game = game + player; //method that returns a game and a player
        //game -= player;//game = game - player;

        //TwentyOneGame game = new TwentyOneGame();
        //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
        //game.ListPlayers();
        //Console.ReadLine();


        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;

        //}
        //Card card1 = new Card();
        //Card card2 = card1;
        //card1.Face = Face.Eight;
        //card2.Face = Face.King;
        //Console.WriteLine(card1.Face);

    }
}

