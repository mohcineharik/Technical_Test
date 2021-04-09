using System;
using System.Linq;

namespace Technical_Test.Models
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        //Player choice 
        public override string playRound(int round)
        {
            base.playRound(round);
            var choice = "";
            do
            {
                choice = Console.ReadLine().ToLower();
            } while (!acceptedChoices.Contains(choice));
            return choice;
        }
    }
}
