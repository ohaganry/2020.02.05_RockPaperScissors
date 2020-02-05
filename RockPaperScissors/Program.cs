using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player dopey = new Dopey();
            Player random = new RandomMan();
            Player chosen = null;
            int userNum = Validator.CheckRange(Validator.GetUserInput("Play against\n1. Dopey\n2. Random Man"), 1, 2);
            if(userNum == 1)
            {
                chosen = dopey;
            }
            if(userNum == 2)
            {
                chosen = random;
            }
            Console.WriteLine(RoshamboApp.Play(chosen, "Ryan"));
            Console.WriteLine($"{chosen.Name} throws {chosen.RPS}");
            
        }
    }
}
