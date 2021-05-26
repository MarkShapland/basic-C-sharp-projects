using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() //use override in method when inheriting abstract class
        {
            Dealer = new TwentyOneDealer(); //new method
            foreach (Player player in Players) //Players is a property of game class
            {
                player.Hand = new List<Card>();// each new game, players hand is discarded
                player.Stay = false;
            }

            Dealer.Hand = new List<Card>();// dealer hand is discarded
            Dealer.Stay = false;
            Dealer.Deck = new Deck();//each new game a new deck will be created to insured there is 52 cards, otherwise there is a partial deck for the next game
            Dealer.Deck.Shuffle(); //shuffles deck for each game

            foreach (Player player in Players)//loops through each player placing a bet
            {
                bool validAnswer = false;
                    int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)  //cards are face up, loops through twice giving each player 2 cards
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);//player wins
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]); //player wins 1/2 times the amount bet + player's bet
                            Bets.Remove(player);//removes player from game if dealer bust so player doesn't get paid twice
                            return; //round is over when player wins blackjack
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!"); //dealer gains all bets from player when dealer wins
                        foreach (KeyValuePair<Player, int> entry in Bets)//iterates through dictionary
                        {
                            Dealer.Balance += entry.Value;//assigns balance to everything
                        }
                        return;
                    }
                }

            }
            foreach (Player player in Players) //goes through each player to check if they want to stay or hit 
            {
                while (!player.Stay)//while not staying
                {
                    Console.WriteLine("Your cards are:");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break; //stops while loop
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);//prints card to console to player
                    }
                    bool busted = TwentyOneRules.Isbusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];// all bets from players goes to dealer balance
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");//if player bust, ask to play again
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return; //ends void function
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return; //ends void function
                        }

                    }


                }
            }
            //dealer doesn't get any card until all the players get their cards and if they bust before the dealer they lose
            Dealer.isBusted = TwentyOneRules.Isbusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)//continue to keep giving cards to the dealer
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.Isbusted(Dealer.Hand);//checks if busted then breaks
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);// checks if staying then breaks
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)//if dealer is busted, all player is given their winnings
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance = +(entry.Value * 2);// where(word) produces a list
                    //list of players . where (their name == the name in the dictionary ). grabs the balance of the person() and += what they bet * 2 //takes their balance and add what they get * 2
                    //loops through each key value pair and finds the player in the player's list that matches that key value pair 
                    Dealer.Balance -= entry.Value; //subtracts the bet from the dealer
                }
                return;
            }
            //compares player hand to dealer's hand
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //bool now can take the value null
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];//player gets their bets back if null(tie)
                    Bets.Remove(player);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);//prints player name and the amount they won
                    player.Balance += (Bets[player] * 2);//player gets their bet back *(times) 2 
                    Dealer.Balance -= Bets[player];//subtract from dealer balance
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];//dealer wins all player bets and adds to balance
                }
                Console.WriteLine("Play again?");//loops through if player won and ask for a new game 
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                   player.isActivelyPlaying =true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }   
        public override void ListPlayers() //instatiate a new dealer
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
