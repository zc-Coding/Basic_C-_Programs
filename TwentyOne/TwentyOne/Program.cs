using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck.Shuffle(3);



            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);




            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Zach" };
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame();
            //Player player = new Player();
            //game.Players = new List<Player>();
            
            //player.Name = "Jesse";
            //game += player;
            //game -= player;


        }



        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;

    }
}
