using MathGame.Core;
using MathGame.Gameplay;
using MathGame.UI;
using MathGame.Player;
using System;

namespace MathGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var player = new Player.Player("Alice");
            Console.WriteLine(player.Name);
        }
    }
}