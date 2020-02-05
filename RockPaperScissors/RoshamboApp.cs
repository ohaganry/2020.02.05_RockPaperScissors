namespace RockPaperScissors
{
    public class RoshamboApp
    {

        public static string Play(Player opponent, string name)
        {
            Player user = new UserPlayer(name);
            string opHand = opponent.GenerateRoshambo();
            string yourHand = user.GenerateRoshambo();
            if(yourHand == "Rock")
            {
                return Rock(opHand);
            }
            if(yourHand == "Paper")
            {
                return Paper(opHand);
            }
            else
            {
                return Scissors(opHand);
            }

        }

        private static string Rock(string opponentHand)
        {
            if(opponentHand == "Rock")
            {
                return "Draw!";
            }
            if(opponentHand == "Paper")
            {
                return "You Lose!";
            }
            if(opponentHand == "Scissors")
            {
                return "You Win!";
            }
            else{return "fail";}
        }
        private static string Paper(string opponentHand)
        {
            if(opponentHand == "Paper")
            {
                return "Draw!";
            }
            if(opponentHand == "Scissors")
            {
                return "You Lose!";
            }
            if(opponentHand == "Rock")
            {
                return "You Win!";
            }
            else{return "fail";}
        }
        private static string Scissors(string opponentHand)
        {
            if(opponentHand == "Scissors")
            {
                return "Draw!";
            }
            if(opponentHand == "Rock")
            {
                return "You Lose!";
            }
            if(opponentHand == "Paper")
            {
                return "You Win!";
            }
            else{return "fail";}
        }
    }
}