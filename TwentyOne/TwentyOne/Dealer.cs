﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
     public   class Dealer 
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }  
        public int Balance { get; set; }

        public void Deal (List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // .First is a method to take first item from list
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); // removeAt is a method to pass in an index of where you want to remove.
        }


    }
}