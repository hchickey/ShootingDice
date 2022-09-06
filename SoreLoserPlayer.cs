using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                try
                {
                    int divideByZero = myRoll / 0;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"{Name} refuses to accept the results..");
                }

            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}