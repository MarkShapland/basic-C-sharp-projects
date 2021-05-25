using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
     public   class Dealer 
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }  
        public int Balance { get; set; }

        public void Deal (List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); // .First is a method to take first item from list
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\mark_\logs\logs.txt", true))//takes argument true /memory gets cleaned up when done
            {
                file.WriteLine(DateTime.Now);// adds timestamp to file
                file.WriteLine(card); //writes this to the file
               
            }
                Deck.Cards.RemoveAt(0); // removeAt is a method to pass in an index of where you want to remove.
        }


    }
}
