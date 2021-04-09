using System;

namespace Technical_Test.Presentation
{
    public enum MenuGame
    {
        TwoPlayers = 1,
        Computer = 2,
        Random = 3,
        Quit = 4
    }
    public class Menu
    {
        //Display Main Menu
        public void displayMenu()
        {
            Console.WriteLine(" ===============================================================================");
            Console.WriteLine("||                                                                              ||");
            Console.WriteLine("||                Rock, Paper, Scissors, flamethrower Game                      ||");
            Console.WriteLine("||                                                                              ||");
            Console.WriteLine(" ===============================================================================");
            Console.WriteLine("||                                                                              ||");
            Console.WriteLine("||      Choose Game Mode :                                                      ||");
            Console.WriteLine("||                      1| Two Players                                          ||");
            Console.WriteLine("||                      2| Against Computer                                     ||");
            Console.WriteLine("||                      3| Player with random choices                           ||");
            Console.WriteLine("||                                                                              ||");
            Console.WriteLine("||                      4| To quit                                              ||");
            Console.WriteLine("||                                                                              ||");
            Console.WriteLine(" ===============================================================================");
        }

        //Loop until we have a valid choice
        public MenuGame getMenuChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 4 || choice < 1 )
            {
                Console.WriteLine("||                                                                              ||");
                Console.WriteLine("||                  Invalid choice, try again                                   ||");
                Console.WriteLine("||                                                                              ||");
            }
            return (MenuGame)choice;
        }

    }
}
