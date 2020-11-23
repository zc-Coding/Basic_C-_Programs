using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Player<T>
    {
        public List<T> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //public static Game operator +(Game game, Player<T> player)
        //{
        //    game.Players.Add(player);
        //    return game;
        //}
        //public static Game operator -(Game game, Player<T> player)
        //{
        //    game.Players.Remove(player);
        //    return game;
        //}
    }
}
