namespace RockPaperScissors
{
    public abstract class Player
    {
        public string Name {get; set;}
        public string RPS {get; set;}

        public Player(){}

        public abstract string GenerateRoshambo();
    }
}