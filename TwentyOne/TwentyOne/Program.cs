using System;
using Casino;
using Casino.TwentyOne;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {

        static void Main(string[] args)// string array 

        {
            const string casinoName = "Grand Hotel and Casino";

            

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions(); // this method going to read is going to read all the exceptions from the database
                 foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | '");
                    Console.WriteLine();
                }
                Console.Read();
                return; // void class will end application when using return
            }
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
                    catch (FraudException ex)//ex is object
                    {
                        Console.WriteLine(ex.Message);
                        UpDateDbWithException(ex);//"ex"  pass in as an exception object to this method
                        Console.ReadLine();
                        return; 
                    }
                    catch (Exception ex)

                    {
                        Console.WriteLine("An error occured please contact your system administrator.");
                        UpDateDbWithException(ex);
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
        private static void UpDateDbWithException(Exception ex) //updates database, ex is object
        {       //connection string
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
                                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) Values
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))//opening sql connection once we exit last curly brace it will shut off connection and wont use memory
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);//adding parameter and datatype to command
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);//adding parameter and datatype
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime); //adding parameter and datatype'

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();//parameters is an array
                command.Parameters["@ExceptionMessage"].Value = ex.Message;// ex is object
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();//open connection
                command.ExecuteNonQuery();//"insert statement" so it is a nonquery


            }       
        }
        private static List<ExceptionEntity> ReadExceptions() // this method will query the database and return all the exceptions
        {
            string connectionString = @" Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; 
                                        ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TImeStamp From Exceptions";//asking for all exceptions
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            
            using (SqlConnection connection =  new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) //loops through each record and creates new exception entity object
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception); // adds to Exceptions list
                }
                connection.Close();
            }
            return Exceptions; 

        }
    }
}

