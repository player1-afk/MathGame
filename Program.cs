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

            //var ui = new ConsoleUI();
            //var player = new Player();
            //var generator = new MathTaskGenerator);

            //var game = new GameEngine(ui, player, generator);
        }
    }
}