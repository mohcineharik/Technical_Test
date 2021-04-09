using System;

namespace Technical_Test.Models
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string[] acceptedChoices { get; set; }

        protected Player(string name)
        {
            Name = name;
        }

        //Display info player and round (have to be overrited to implement the player choice)
        public virtual string playRound(int round)
        {
            Console.WriteLine("||                         Round {0}  Player : {1}                           ||", round, Name);
            Console.WriteLine("||                                                                              ||");
            Console.WriteLine("||  Choose : S:Scissors    |   P:Paper   |  R:Rock     |  F:Flamethrower        ||");
            Console.WriteLine("||                                                                              ||");
            return string.Empty;
        }
    }
}
