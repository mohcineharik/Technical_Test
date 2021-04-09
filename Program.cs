using Technical_Test.Core;
using Technical_Test.Presentation;

namespace Technical_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Menu
            var _menu = new Menu();
            _menu.displayMenu();
            var _menuChoice = _menu.getMenuChoice();

            //Launch the game
            var game = new Game(_menuChoice);
            game.playTheGame();
        }
    }
}
