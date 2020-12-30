using System;
using Casino;
using Casino.TwentyOne;
using System.IO;
using System.Data;

using System.Data.SqlClient;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Landing for the App allows admin to view log of exceptions and details
            Console.WriteLine("Welcome to the Flying Tiger Casino. Let's start of by getting your name.");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.ID + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            // Establishes the amount of money the player brought which is assigned to the variable bank
            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits that are whole numbers only");
            }
            // Prompt for starting game
            Console.WriteLine("hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
            {
                Player player = new Player(playerName, bank);
                player.ID = Guid.NewGuid();
                // Logs every card dealt to who they were dealt and at what time to a text file
                using (StreamWriter file = new StreamWriter(@"C:\Users\zachc\Documents\TechAcademy\text logs\log.txt", true)) 
                {
                    file.WriteLine(player.ID);
                }
                // starts new game of twenty one class
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine("Security has been called please stay where you are to avoid severe injury"); //Casino security is threatening, just the name of the game
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Have a nice day!");
            Console.ReadLine();
        }
        // Database methods for update and viewing exceptions
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions(ExceptionType, ExceptionMessage, TimeStamp) VALUES " +
                                 @"(@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();


            }
        }
           
        private static List<ExceptionEntity> ReadExceptions()
        { 
           string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                   Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                   ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

           string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

           List<ExceptionEntity> exceptions = new List<ExceptionEntity>();

           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               SqlCommand command = new SqlCommand(queryString, connection);

               connection.Open();

               SqlDataReader reader = command.ExecuteReader();

               while (reader.Read())
               {
                   ExceptionEntity exception = new ExceptionEntity();
                   exception.ID = Convert.ToInt32(reader["ID"]);
                   exception.ExceptionType = reader["ExceptionType"].ToString();
                   exception.ExceptionMessage = reader["ExceptionType"].ToString();
                   exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                   exceptions.Add(exception);
               }
               connection.Close();
           }
           return exceptions;
        }
    }
}

