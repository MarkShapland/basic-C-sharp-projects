using System;
using Casino;
using Casino.TwentyOne;
using System.IO;

namespace TwentyOne
{
    class Program
    {

        static void Main(string[] args)// string array 

        {
            const string casinoName = "Grand Hotel and Casino";

            

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");// if the user inputs a string
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //similar to convert 
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }


            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); //players name will be place in placeholder {0}
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); // new player object and initialize him with name and how much money he brought
                player.Id = Guid.NewGuid();// creates nuw GUID and saves their name to a file
                using (StreamWriter file = new StreamWriter(@"C:\Users\mark_\logs\logs.txt", true))// logs user id
                {
                    file.WriteLine(player.Id);
                }

                    Game game = new TwentyOneGame();  // polymorphism exposes overloaded operators
                game += player;// adds player
                player.isActivelyPlaying = true; //creates new GUID for each player so we can track player
                while (player.isActivelyPlaying && player.Balance >0) // keeps player in the while loop
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)

                    {
                        Console.WriteLine("An error occured please contact your system administrator.");
                        Console.ReadLine();
                        return; 
                    }
                }
                game -= player; //exits player from loop
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}

