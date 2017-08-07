using System;

namespace TicTacToe
{
    public class Program
    {
        private static void Main()
        {
            var gameSetup = new GameSetup();
            var gameBoard = gameSetup.NewBoard;
            var players = gameSetup.PlayerNames;

            gameSetup.EnterPlayers(players);
            gameSetup.PrintBoard(gameBoard);

            foreach (var name in players)
                Console.WriteLine(name);

            Console.WriteLine(GameMechanics.WinLoseDraw("Mike"));

            Console.Write("Press any key to continue");
            Console.ReadKey();
        }
    }
}
