using System;

namespace RockPaperScissors
{
    public class RandomMan : Player
    {
        public RandomMan()
        {
            Name = "Random Man";
        }

        public override string GenerateRoshambo()
        {
           Random number = new Random();
           int num = number.Next(1, 4);
           RPS = Enum.GetName(typeof(Roshambo), num);
           return RPS;
        }
    }
}