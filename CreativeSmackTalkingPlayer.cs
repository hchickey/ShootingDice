using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunt = new List<string>()
        {
            "You are bad at dice", "Learn how to roll better", "You have a bad wrist"
        };

        public override int Roll()
        {
            int randomIndex = new Random().Next(Taunt.Count);
            string randomTaunt = Taunt[randomIndex];

            Console.WriteLine(randomTaunt);

            return new Random().Next(DiceSize) + 1;
        }
    }
}