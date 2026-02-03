using System;

namespace MathGame.Player
{
    internal class Player
    {
        public string Name { get; }

        public Player(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Player name is required.", nameof(name));

            Name = name;
        }
    }
}

