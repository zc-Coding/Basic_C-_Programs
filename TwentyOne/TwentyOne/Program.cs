using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Flying Tiger Casino. Let's start of by getting your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money will you be playing with?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Have a nice day!");
            Console.ReadLine();
        }
    }
}
