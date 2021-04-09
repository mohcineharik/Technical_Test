using System;

namespace Technical_Test.Models
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string name, bool isRandom) : base(name)
        {
            HasRandomChoice = isRandom;
        }
        public bool HasRandomChoice { get; set; }

        //Computer choice depending of his type random or not 
        public override string playRound(int round)
        {
            base.playRound(round);
            Random random = new Random();
            int n = random.Next(0, acceptedChoices.Length);
            if (HasRandomChoice)
                return acceptedChoices[n];
            else
                return acceptedChoices[round % acceptedChoices.Length];
        }
    }
}
