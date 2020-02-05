namespace RockPaperScissors
{
    public class Dopey : Player
    {
        public Dopey()
        {
            Name = "Dopey";
        }

        public override string GenerateRoshambo()
        {
            RPS = Roshambo.Rock.ToString();
            return RPS;
        }
    }
}